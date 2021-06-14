
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
			this.txtChannelId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSecret = new System.Windows.Forms.TextBox();
			this.txtPayload = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnExecut = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtJWT = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtResponse = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtClientId = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtChannelId
			// 
			this.txtChannelId.Location = new System.Drawing.Point(186, 12);
			this.txtChannelId.MaxLength = 15;
			this.txtChannelId.Name = "txtChannelId";
			this.txtChannelId.Size = new System.Drawing.Size(203, 23);
			this.txtChannelId.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Channel Twitch ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Twitch Extension Secret:";
			// 
			// txtSecret
			// 
			this.txtSecret.Location = new System.Drawing.Point(186, 41);
			this.txtSecret.MaxLength = 512;
			this.txtSecret.Name = "txtSecret";
			this.txtSecret.Size = new System.Drawing.Size(503, 23);
			this.txtSecret.TabIndex = 1;
			// 
			// txtPayload
			// 
			this.txtPayload.Location = new System.Drawing.Point(38, 129);
			this.txtPayload.MaxLength = 5000;
			this.txtPayload.Multiline = true;
			this.txtPayload.Name = "txtPayload";
			this.txtPayload.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtPayload.Size = new System.Drawing.Size(612, 533);
			this.txtPayload.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Payload:";
			// 
			// btnExecut
			// 
			this.btnExecut.Location = new System.Drawing.Point(38, 668);
			this.btnExecut.Name = "btnExecut";
			this.btnExecut.Size = new System.Drawing.Size(145, 75);
			this.btnExecut.TabIndex = 4;
			this.btnExecut.Text = "SEND PUSH!";
			this.btnExecut.UseVisualStyleBackColor = true;
			this.btnExecut.Click += new System.EventHandler(this.btnExecut_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(656, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Sent Message:";
			// 
			// txtMessage
			// 
			this.txtMessage.BackColor = System.Drawing.SystemColors.Control;
			this.txtMessage.Location = new System.Drawing.Point(656, 129);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMessage.Size = new System.Drawing.Size(375, 158);
			this.txtMessage.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(657, 289);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "Sent JWT:";
			// 
			// txtJWT
			// 
			this.txtJWT.BackColor = System.Drawing.SystemColors.Control;
			this.txtJWT.Location = new System.Drawing.Point(657, 307);
			this.txtJWT.Multiline = true;
			this.txtJWT.Name = "txtJWT";
			this.txtJWT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtJWT.Size = new System.Drawing.Size(375, 158);
			this.txtJWT.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(656, 486);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = "Response:";
			// 
			// txtResponse
			// 
			this.txtResponse.BackColor = System.Drawing.SystemColors.Control;
			this.txtResponse.Location = new System.Drawing.Point(656, 504);
			this.txtResponse.Multiline = true;
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResponse.Size = new System.Drawing.Size(375, 158);
			this.txtResponse.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(34, 73);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "Twitch Extension Client ID:";
			// 
			// txtClientId
			// 
			this.txtClientId.Location = new System.Drawing.Point(186, 70);
			this.txtClientId.MaxLength = 300;
			this.txtClientId.Name = "txtClientId";
			this.txtClientId.Size = new System.Drawing.Size(266, 23);
			this.txtClientId.TabIndex = 2;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1044, 755);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtClientId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtResponse);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtJWT);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnExecut);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPayload);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSecret);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtChannelId);
			this.Name = "frmMain";
			this.Text = "Twitch Mock PubSub";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtChannelId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSecret;
		private System.Windows.Forms.TextBox txtPayload;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnExecut;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtJWT;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtResponse;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtClientId;
	}
}

