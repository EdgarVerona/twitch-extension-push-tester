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
			txtPayload.Text = Properties.Settings.Default.Payload;
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

		public class PushMessageBody
		{
			[JsonProperty("content_type")]
			public string contentType;

			public string message;

			public List<string> targets;
		}

		private void btnExecut_Click(object sender, EventArgs e)
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
			Properties.Settings.Default.Payload = txtPayload.Text;
			Properties.Settings.Default.Save();

			var message = new PushMessageJWT()
			{
				channelId = txtChannelId.Text,
				exp = (long)(DateTime.UtcNow - DateTime.UnixEpoch).TotalSeconds + 60,
				perms = _perms,
				role = "external",
				userId = txtChannelId.Text
			};

			var encoder = new JwtEncoder(new HMACSHA256Algorithm(), new JsonNetSerializer(), new JwtBase64UrlEncoder());

			string jwt = encoder.Encode(message, Convert.FromBase64String(txtSecret.Text.Trim()));
			txtJWT.Text = jwt;

			var messageHttp = new HttpRequestMessage(HttpMethod.Post, $"https://api.twitch.tv/extensions/message/{txtChannelId.Text}");
			messageHttp.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);
			messageHttp.Headers.Add("Client-Id", txtClientId.Text);

			var newMessageBody = new PushMessageBody()
			{
				contentType = "application/json",
				targets = new List<string>() { "broadcast" },
				message = txtPayload.Text.Trim()
			};

			string messageBodyText = JsonConvert.SerializeObject(newMessageBody);
			txtMessage.Text = messageBodyText;

			var content = new StringContent(messageBodyText, Encoding.UTF8, "application/json");
			messageHttp.Content = content;
			var task = _client.SendAsync(messageHttp);

			task.Wait();

			string resultBody = task.Result.Content.ReadAsStringAsync().Result;

			txtResponse.Text = $"RESULT:{task.Result.StatusCode}\n\n{resultBody}";
		}
	}
}
