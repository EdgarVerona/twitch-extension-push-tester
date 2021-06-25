
namespace TwitchExtensionPushTester
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPush = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPushPayload = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPushResponse = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPushJWT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPushMessage = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnPushExecute = new System.Windows.Forms.Button();
			this.tabEBSEndpoint = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtEbsResponse = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtEbsSentRequestInfo = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cboEbsVerb = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtEbsPostBody = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtEbsUrl = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtClientId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSecret = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtProxy = new System.Windows.Forms.TextBox();
			this.btnEbsExecute = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtChannelId = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtEbsUserId = new System.Windows.Forms.TextBox();
			this.chkEbsIsAuthenticated = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPush.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabEBSEndpoint.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPush);
			this.tabControl1.Controls.Add(this.tabEBSEndpoint);
			this.tabControl1.Location = new System.Drawing.Point(12, 142);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1068, 717);
			this.tabControl1.TabIndex = 17;
			// 
			// tabPush
			// 
			this.tabPush.Controls.Add(this.groupBox3);
			this.tabPush.Controls.Add(this.groupBox2);
			this.tabPush.Controls.Add(this.label9);
			this.tabPush.Controls.Add(this.btnPushExecute);
			this.tabPush.Location = new System.Drawing.Point(4, 24);
			this.tabPush.Name = "tabPush";
			this.tabPush.Padding = new System.Windows.Forms.Padding(3);
			this.tabPush.Size = new System.Drawing.Size(1060, 689);
			this.tabPush.TabIndex = 0;
			this.tabPush.Text = "Push Notifications";
			this.tabPush.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txtPushPayload);
			this.groupBox3.Location = new System.Drawing.Point(22, 54);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(584, 567);
			this.groupBox3.TabIndex = 34;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Request";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 26;
			this.label3.Text = "Payload:";
			// 
			// txtPushPayload
			// 
			this.txtPushPayload.Location = new System.Drawing.Point(6, 41);
			this.txtPushPayload.MaxLength = 5000;
			this.txtPushPayload.Multiline = true;
			this.txtPushPayload.Name = "txtPushPayload";
			this.txtPushPayload.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtPushPayload.Size = new System.Drawing.Size(559, 492);
			this.txtPushPayload.TabIndex = 25;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtPushResponse);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtPushJWT);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtPushMessage);
			this.groupBox2.Location = new System.Drawing.Point(612, 54);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(442, 567);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Response";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 380);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 15);
			this.label6.TabIndex = 34;
			this.label6.Text = "Response:";
			// 
			// txtPushResponse
			// 
			this.txtPushResponse.BackColor = System.Drawing.SystemColors.Control;
			this.txtPushResponse.Location = new System.Drawing.Point(19, 398);
			this.txtPushResponse.Multiline = true;
			this.txtPushResponse.Name = "txtPushResponse";
			this.txtPushResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtPushResponse.Size = new System.Drawing.Size(409, 158);
			this.txtPushResponse.TabIndex = 33;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 201);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 15);
			this.label5.TabIndex = 32;
			this.label5.Text = "Sent JWT:";
			// 
			// txtPushJWT
			// 
			this.txtPushJWT.BackColor = System.Drawing.SystemColors.Control;
			this.txtPushJWT.Location = new System.Drawing.Point(20, 219);
			this.txtPushJWT.Multiline = true;
			this.txtPushJWT.Name = "txtPushJWT";
			this.txtPushJWT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtPushJWT.Size = new System.Drawing.Size(409, 158);
			this.txtPushJWT.TabIndex = 31;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 15);
			this.label4.TabIndex = 30;
			this.label4.Text = "Sent Message:";
			// 
			// txtPushMessage
			// 
			this.txtPushMessage.BackColor = System.Drawing.SystemColors.Control;
			this.txtPushMessage.Location = new System.Drawing.Point(19, 41);
			this.txtPushMessage.Multiline = true;
			this.txtPushMessage.Name = "txtPushMessage";
			this.txtPushMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtPushMessage.Size = new System.Drawing.Size(409, 158);
			this.txtPushMessage.TabIndex = 29;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 18);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(565, 30);
			this.label9.TabIndex = 30;
			this.label9.Text = "This tab allows push notifications to be sent directly to Twitch for your Extensi" +
    "on.\r\nThe payload accepts any text, but check your expected format and properties" +
    " in the push you are sending!";
			// 
			// btnPushExecute
			// 
			this.btnPushExecute.Location = new System.Drawing.Point(22, 630);
			this.btnPushExecute.Name = "btnPushExecute";
			this.btnPushExecute.Size = new System.Drawing.Size(314, 53);
			this.btnPushExecute.TabIndex = 21;
			this.btnPushExecute.Text = "Send Push Notification through Twitch!";
			this.btnPushExecute.UseVisualStyleBackColor = true;
			this.btnPushExecute.Click += new System.EventHandler(this.btnPushExecute_Click);
			// 
			// tabEBSEndpoint
			// 
			this.tabEBSEndpoint.Controls.Add(this.btnEbsExecute);
			this.tabEBSEndpoint.Controls.Add(this.groupBox5);
			this.tabEBSEndpoint.Controls.Add(this.groupBox4);
			this.tabEBSEndpoint.Controls.Add(this.label10);
			this.tabEBSEndpoint.Location = new System.Drawing.Point(4, 24);
			this.tabEBSEndpoint.Name = "tabEBSEndpoint";
			this.tabEBSEndpoint.Padding = new System.Windows.Forms.Padding(3);
			this.tabEBSEndpoint.Size = new System.Drawing.Size(1060, 689);
			this.tabEBSEndpoint.TabIndex = 1;
			this.tabEBSEndpoint.Text = "Twitch EBS Endpoint";
			this.tabEBSEndpoint.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label15);
			this.groupBox5.Controls.Add(this.txtEbsResponse);
			this.groupBox5.Controls.Add(this.label17);
			this.groupBox5.Controls.Add(this.txtEbsSentRequestInfo);
			this.groupBox5.Location = new System.Drawing.Point(570, 55);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(470, 569);
			this.groupBox5.TabIndex = 35;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Response";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(19, 325);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(60, 15);
			this.label15.TabIndex = 34;
			this.label15.Text = "Response:";
			// 
			// txtEbsResponse
			// 
			this.txtEbsResponse.BackColor = System.Drawing.SystemColors.Control;
			this.txtEbsResponse.Location = new System.Drawing.Point(19, 343);
			this.txtEbsResponse.Multiline = true;
			this.txtEbsResponse.Name = "txtEbsResponse";
			this.txtEbsResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtEbsResponse.Size = new System.Drawing.Size(409, 208);
			this.txtEbsResponse.TabIndex = 33;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(19, 23);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(102, 15);
			this.label17.TabIndex = 30;
			this.label17.Text = "Sent Request Info:";
			// 
			// txtEbsSentRequestInfo
			// 
			this.txtEbsSentRequestInfo.BackColor = System.Drawing.SystemColors.Control;
			this.txtEbsSentRequestInfo.Location = new System.Drawing.Point(19, 41);
			this.txtEbsSentRequestInfo.Multiline = true;
			this.txtEbsSentRequestInfo.Name = "txtEbsSentRequestInfo";
			this.txtEbsSentRequestInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtEbsSentRequestInfo.Size = new System.Drawing.Size(409, 281);
			this.txtEbsSentRequestInfo.TabIndex = 29;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.chkEbsIsAuthenticated);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.txtEbsUserId);
			this.groupBox4.Controls.Add(this.cboEbsVerb);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.txtEbsPostBody);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.txtEbsUrl);
			this.groupBox4.Location = new System.Drawing.Point(19, 55);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(545, 569);
			this.groupBox4.TabIndex = 34;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Request";
			// 
			// cboEbsVerb
			// 
			this.cboEbsVerb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEbsVerb.FormattingEnabled = true;
			this.cboEbsVerb.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT"});
			this.cboEbsVerb.Location = new System.Drawing.Point(105, 59);
			this.cboEbsVerb.Name = "cboEbsVerb";
			this.cboEbsVerb.Size = new System.Drawing.Size(169, 23);
			this.cboEbsVerb.TabIndex = 40;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(66, 62);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(33, 15);
			this.label14.TabIndex = 39;
			this.label14.Text = "Verb:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(70, 26);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(31, 15);
			this.label13.TabIndex = 38;
			this.label13.Text = "URL:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(18, 146);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(140, 15);
			this.label12.TabIndex = 37;
			this.label12.Text = "Post Body (if Applicable):";
			// 
			// txtEbsPostBody
			// 
			this.txtEbsPostBody.Location = new System.Drawing.Point(18, 164);
			this.txtEbsPostBody.MaxLength = 5000;
			this.txtEbsPostBody.Multiline = true;
			this.txtEbsPostBody.Name = "txtEbsPostBody";
			this.txtEbsPostBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtEbsPostBody.Size = new System.Drawing.Size(521, 374);
			this.txtEbsPostBody.TabIndex = 36;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(-30, 45);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(31, 15);
			this.label11.TabIndex = 35;
			this.label11.Text = "URL:";
			// 
			// txtEbsUrl
			// 
			this.txtEbsUrl.Location = new System.Drawing.Point(105, 23);
			this.txtEbsUrl.Name = "txtEbsUrl";
			this.txtEbsUrl.Size = new System.Drawing.Size(434, 23);
			this.txtEbsUrl.TabIndex = 34;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(19, 13);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(790, 30);
			this.label10.TabIndex = 31;
			this.label10.Text = resources.GetString("label10.Text");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtChannelId);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtClientId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtSecret);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtProxy);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1064, 124);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Common Settings";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 63);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 15);
			this.label7.TabIndex = 39;
			this.label7.Text = "Twitch Extension Client ID:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtClientId
			// 
			this.txtClientId.Location = new System.Drawing.Point(162, 60);
			this.txtClientId.MaxLength = 300;
			this.txtClientId.Name = "txtClientId";
			this.txtClientId.Size = new System.Drawing.Size(266, 23);
			this.txtClientId.TabIndex = 37;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 15);
			this.label2.TabIndex = 38;
			this.label2.Text = "Twitch Extension Secret:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtSecret
			// 
			this.txtSecret.Location = new System.Drawing.Point(162, 31);
			this.txtSecret.MaxLength = 512;
			this.txtSecret.Name = "txtSecret";
			this.txtSecret.Size = new System.Drawing.Size(503, 23);
			this.txtSecret.TabIndex = 36;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(719, 34);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(130, 15);
			this.label8.TabIndex = 35;
			this.label8.Text = "Proxy Server (optional):";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtProxy
			// 
			this.txtProxy.Location = new System.Drawing.Point(855, 31);
			this.txtProxy.MaxLength = 300;
			this.txtProxy.Name = "txtProxy";
			this.txtProxy.Size = new System.Drawing.Size(203, 23);
			this.txtProxy.TabIndex = 34;
			// 
			// btnEbsExecute
			// 
			this.btnEbsExecute.Location = new System.Drawing.Point(19, 630);
			this.btnEbsExecute.Name = "btnEbsExecute";
			this.btnEbsExecute.Size = new System.Drawing.Size(274, 51);
			this.btnEbsExecute.TabIndex = 36;
			this.btnEbsExecute.Text = "Send EBS Request!";
			this.btnEbsExecute.UseVisualStyleBackColor = true;
			this.btnEbsExecute.Click += new System.EventHandler(this.btnEbsExecute_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 15);
			this.label1.TabIndex = 41;
			this.label1.Text = "Channel Twitch ID:";
			// 
			// txtChannelId
			// 
			this.txtChannelId.Location = new System.Drawing.Point(162, 89);
			this.txtChannelId.MaxLength = 15;
			this.txtChannelId.Name = "txtChannelId";
			this.txtChannelId.Size = new System.Drawing.Size(203, 23);
			this.txtChannelId.TabIndex = 40;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(18, 100);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(83, 15);
			this.label16.TabIndex = 42;
			this.label16.Text = "Twitch user ID:";
			// 
			// txtEbsUserId
			// 
			this.txtEbsUserId.Location = new System.Drawing.Point(105, 97);
			this.txtEbsUserId.Name = "txtEbsUserId";
			this.txtEbsUserId.Size = new System.Drawing.Size(169, 23);
			this.txtEbsUserId.TabIndex = 41;
			// 
			// chkEbsIsAuthenticated
			// 
			this.chkEbsIsAuthenticated.AutoSize = true;
			this.chkEbsIsAuthenticated.Checked = true;
			this.chkEbsIsAuthenticated.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkEbsIsAuthenticated.Location = new System.Drawing.Point(281, 100);
			this.chkEbsIsAuthenticated.Name = "chkEbsIsAuthenticated";
			this.chkEbsIsAuthenticated.Size = new System.Drawing.Size(135, 19);
			this.chkEbsIsAuthenticated.TabIndex = 43;
			this.chkEbsIsAuthenticated.Text = "Is authenticated user";
			this.chkEbsIsAuthenticated.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1090, 876);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmMain";
			this.Text = "Twitch Mock PubSub/EBS Requests";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPush.ResumeLayout(false);
			this.tabPush.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabEBSEndpoint.ResumeLayout(false);
			this.tabEBSEndpoint.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPush;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPushPayload;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPushResponse;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPushJWT;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPushMessage;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnPushExecute;
		private System.Windows.Forms.TabPage tabEBSEndpoint;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtClientId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSecret;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtProxy;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtEbsResponse;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtEbsSentRequestInfo;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox cboEbsVerb;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtEbsPostBody;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtEbsUrl;
		private System.Windows.Forms.Button btnEbsExecute;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtChannelId;
		private System.Windows.Forms.CheckBox chkEbsIsAuthenticated;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtEbsUserId;
	}
}

