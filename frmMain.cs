using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JWT;
using JWT.Serializers;
using JWT.Algorithms;
using System.Net;

namespace TwitchExtensionPushTester
{
	public partial class frmMain : Form
	{
		HttpClient _client = new HttpClient();

		public frmMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtClientId.Text = Properties.Settings.Default.ClientId;
			txtChannelId.Text = Properties.Settings.Default.Channel;
			txtSecret.Text = Properties.Settings.Default.Secret;
			txtPushPayload.Text = Properties.Settings.Default.Payload;
			txtEbsUrl.Text = Properties.Settings.Default.EbsUrl;
			txtEbsPostBody.Text = Properties.Settings.Default.EbsPostBody;
			for (int itemIndex = 0; itemIndex < cboEbsVerb.Items.Count; itemIndex++)
			{
				if (cboEbsVerb.Items[itemIndex].ToString().Equals(Properties.Settings.Default.EbsVerb))
				{
					cboEbsVerb.SelectedIndex = itemIndex;
				}
			}
			
			txtProxy.Text = Properties.Settings.Default.Proxy;
			chkEbsIsAuthenticated.Checked = bool.Parse(Properties.Settings.Default.EbsIsAuthenticated);
			txtEbsUserId.Text = Properties.Settings.Default.EbsUserId;
		}

		public class PubsubPerms
		{
			public List<string> send;
		}

		readonly PubsubPerms _perms = new PubsubPerms()
		{
			send = new List<string>() { "broadcast" }
		};

		public class PushMessageJWT
		{
			public long exp;
			
			[JsonProperty("user_id")]
			public string userId;

			public string role;

			[JsonProperty("channel_id")]
			public string channelId;

			[JsonProperty("pubsub_perms")]
			public PubsubPerms perms;
		}

		public class TwitchJWT
		{
			public long exp;

			[JsonProperty("user_id")]
			public string userId;

			[JsonProperty("opaque_user_id")]
			public string opaqueUserId;

			[JsonProperty("is_unlinked")]
			public bool isUnlinked;

			public string role;

			[JsonProperty("channel_id")]
			public string channelId;
		}

		public class PushMessageBody
		{
			[JsonProperty("content_type")]
			public string contentType;

			public string message;

			public List<string> targets;
		}

		private void btnPushExecute_Click(object sender, EventArgs e)
		{
			btnPushExecute.Enabled = false;
			HandleAction();

			var message = new PushMessageJWT()
			{
				channelId = txtChannelId.Text,
				exp = (long)(DateTime.UtcNow - DateTime.UnixEpoch).TotalSeconds + 60,
				perms = _perms,
				role = "external",
				userId = txtChannelId.Text
			};
			
			string jwt = CreateJWT(message);

			txtPushJWT.Text = jwt;

			var messageHttp = new HttpRequestMessage(HttpMethod.Post, $"https://api.twitch.tv/extensions/message/{txtChannelId.Text}");
			messageHttp.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);
			messageHttp.Headers.Add("Client-Id", txtClientId.Text);

			var newMessageBody = new PushMessageBody()
			{
				contentType = "application/json",
				targets = new List<string>() { "broadcast" },
				message = txtPushPayload.Text.Trim()
			};

			string messageBodyText = JsonConvert.SerializeObject(newMessageBody);
			txtPushMessage.Text = messageBodyText;

			var content = new StringContent(messageBodyText, Encoding.UTF8, "application/json");
			messageHttp.Content = content;
			var task = _client.SendAsync(messageHttp);

			task.Wait();

			string resultBody = task.Result.Content.ReadAsStringAsync().Result;

			txtPushResponse.Text = $"RESULT: {(int)task.Result.StatusCode}: {task.Result.StatusCode}{Environment.NewLine}{Environment.NewLine}{resultBody}";

			btnPushExecute.Enabled = true;
		}

		private string CreateJWT(object message)
		{
			var encoder = new JwtEncoder(new HMACSHA256Algorithm(), new JsonNetSerializer(), new JwtBase64UrlEncoder());

			string jwt = encoder.Encode(message, txtSecret.Text.Trim());
			return jwt;
		}

		private void HandleAction()
		{
			if (string.IsNullOrEmpty(txtProxy.Text))
			{
				HttpClient.DefaultProxy = new WebProxy();
			}
			else
			{
				HttpClient.DefaultProxy = new WebProxy(txtProxy.Text);
			}

			Properties.Settings.Default.ClientId = txtClientId.Text;
			Properties.Settings.Default.Channel = txtChannelId.Text;
			Properties.Settings.Default.Secret = txtSecret.Text;
			Properties.Settings.Default.Payload = txtPushPayload.Text;
			Properties.Settings.Default.EbsUrl = txtEbsUrl.Text;
			Properties.Settings.Default.EbsPostBody = txtEbsPostBody.Text;
			Properties.Settings.Default.EbsVerb = cboEbsVerb.Text;
			Properties.Settings.Default.Proxy = txtProxy.Text;
			Properties.Settings.Default.EbsIsAuthenticated = chkEbsIsAuthenticated.Checked.ToString();
			Properties.Settings.Default.EbsUserId = txtEbsUserId.Text;
			Properties.Settings.Default.Save();
		}

		private void btnEbsExecute_Click(object sender, EventArgs e)
		{
			btnEbsExecute.Enabled = false;
			HandleAction();

			var jwtPayload = new TwitchJWT()
			{
				channelId = txtChannelId.Text,
				exp = (long)(DateTime.UtcNow - DateTime.UnixEpoch).TotalSeconds + 60,
				isUnlinked = !chkEbsIsAuthenticated.Checked,
				role = (txtEbsUserId.Text.Equals(txtChannelId.Text)) ? "broadcaster" : "viewer",
				userId = chkEbsIsAuthenticated.Checked ? txtEbsUserId.Text : null,
				opaqueUserId = (chkEbsIsAuthenticated.Checked ? "U" : "A") + txtEbsUserId.Text
			};

			string jwt = CreateJWT(jwtPayload);

			HttpMethod method = HttpMethod.Get;

			switch (cboEbsVerb.Text)
			{
				case "GET":
					method = HttpMethod.Get;
					break;
				case "PUT":
					method = HttpMethod.Put;
					break;
				case "POST":
					method = HttpMethod.Post;
					break;
			}

			var messageHttp = new HttpRequestMessage(method, txtEbsUrl.Text);
			messageHttp.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);

			var content = new StringContent(txtEbsPostBody.Text, Encoding.UTF8, "application/json");
			messageHttp.Content = content;

			string formattedJwtPayload = JsonConvert.SerializeObject(jwtPayload, Formatting.Indented).Replace("\n", Environment.NewLine);

			txtEbsSentRequestInfo.Text = $"URL: {txtEbsUrl.Text}{Environment.NewLine}{Environment.NewLine}Verb: {method}{Environment.NewLine}{Environment.NewLine}Auth: {messageHttp.Headers.Authorization.ToString()}{Environment.NewLine}{Environment.NewLine}JWT Payload: {formattedJwtPayload}{Environment.NewLine}{Environment.NewLine}Body:{Environment.NewLine}{txtEbsPostBody.Text}";

			try
			{
				var task = _client.SendAsync(messageHttp);

				task.Wait();

				string resultBody = task.Result.Content.ReadAsStringAsync().Result;

				txtEbsResponse.Text = $"RESULT: {(int)task.Result.StatusCode}: {task.Result.StatusCode}{Environment.NewLine}{Environment.NewLine}{resultBody}";
			}
			catch (Exception ex)
			{
				txtEbsResponse.Text = $"EXCEPTION:{Environment.NewLine}{Environment.NewLine}{ex}";
			}

			btnEbsExecute.Enabled = true;
		}
	}
}
