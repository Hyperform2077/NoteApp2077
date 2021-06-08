namespace NoteAppUI
{
	partial class AboutForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.NoteAppLabel = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
			this.GitHubLabel = new System.Windows.Forms.Label();
			this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
			this.CopyRightLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// NoteAppLabel
			// 
			this.NoteAppLabel.AutoSize = true;
			this.NoteAppLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NoteAppLabel.Location = new System.Drawing.Point(13, 13);
			this.NoteAppLabel.Name = "NoteAppLabel";
			this.NoteAppLabel.Size = new System.Drawing.Size(112, 33);
			this.NoteAppLabel.TabIndex = 0;
			this.NoteAppLabel.Text = "NoteApp";
			// 
			// VersionLabel
			// 
			this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.VersionLabel.AutoSize = true;
			this.VersionLabel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VersionLabel.Location = new System.Drawing.Point(20, 46);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(47, 20);
			this.VersionLabel.TabIndex = 1;
			this.VersionLabel.Text = "v. 1.0.0";
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AuthorLabel.Location = new System.Drawing.Point(20, 100);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(133, 20);
			this.AuthorLabel.TabIndex = 2;
			this.AuthorLabel.Text = "Author: Alexander Tikhonov";
			// 
			// EmailLabel
			// 
			this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(20, 146);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(137, 17);
			this.EmailLabel.TabIndex = 4;
			this.EmailLabel.Text = "e-mail for feedback: ";
			// 
			// EmailLinkLabel
			// 
			this.EmailLinkLabel.AutoSize = true;
			this.EmailLinkLabel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EmailLinkLabel.Location = new System.Drawing.Point(147, 143);
			this.EmailLinkLabel.Name = "EmailLinkLabel";
			this.EmailLinkLabel.Size = new System.Drawing.Size(180, 20);
			this.EmailLinkLabel.TabIndex = 5;
			this.EmailLinkLabel.TabStop = true;
			this.EmailLinkLabel.Text = "alexander.hyperform@gmail.com";
			this.EmailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmailLinkLabel_LinkClicked);
			// 
			// GitHubLabel
			// 
			this.GitHubLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.GitHubLabel.AutoSize = true;
			this.GitHubLabel.Location = new System.Drawing.Point(21, 167);
			this.GitHubLabel.Name = "GitHubLabel";
			this.GitHubLabel.Size = new System.Drawing.Size(56, 17);
			this.GitHubLabel.TabIndex = 6;
			this.GitHubLabel.Text = "GitHub:";
			// 
			// GitHubLinkLabel
			// 
			this.GitHubLinkLabel.AutoSize = true;
			this.GitHubLinkLabel.Location = new System.Drawing.Point(72, 167);
			this.GitHubLinkLabel.Name = "GitHubLinkLabel";
			this.GitHubLinkLabel.Size = new System.Drawing.Size(127, 17);
			this.GitHubLinkLabel.TabIndex = 7;
			this.GitHubLinkLabel.TabStop = true;
			this.GitHubLinkLabel.Text = "Hyperform2077/NoteApp2077";
			// 
			// CopyRightLabel
			// 
			this.CopyRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CopyRightLabel.AutoSize = true;
			this.CopyRightLabel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CopyRightLabel.Location = new System.Drawing.Point(12, 289);
			this.CopyRightLabel.Name = "CopyRightLabel";
			this.CopyRightLabel.Size = new System.Drawing.Size(135, 20);
			this.CopyRightLabel.TabIndex = 8;
			this.CopyRightLabel.Text = "2021 Tikhonov Alexander ©";
			this.CopyRightLabel.Click += new System.EventHandler(this.CopyRightLabel_Click);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 318);
			this.Controls.Add(this.CopyRightLabel);
			this.Controls.Add(this.GitHubLinkLabel);
			this.Controls.Add(this.GitHubLabel);
			this.Controls.Add(this.EmailLinkLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.AuthorLabel);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.NoteAppLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AboutForm";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NoteAppLabel;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.LinkLabel EmailLinkLabel;
		private System.Windows.Forms.Label GitHubLabel;
		private System.Windows.Forms.LinkLabel GitHubLinkLabel;
		private System.Windows.Forms.Label CopyRightLabel;
	}
}