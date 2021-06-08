using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
			this.MaximumSize = this.MinimumSize = new Size(410, 300);
		}

		private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.GitHubLinkLabel.LinkVisited = true;
			System.Diagnostics.Process.Start("https://github.com/Paul9819/NoteApp");
		}

		private void CopyRightLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
