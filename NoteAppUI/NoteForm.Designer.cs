namespace NoteAppUI
{
	partial class NoteForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
			this.TitleLabel = new System.Windows.Forms.Label();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.CreatedTimeLabel = new System.Windows.Forms.Label();
			this.CreatedTimePicker = new System.Windows.Forms.DateTimePicker();
			this.ModifiedLabel = new System.Windows.Forms.Label();
			this.ModifiedTimePicker = new System.Windows.Forms.DateTimePicker();
			this.CancelButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.CategoryComboBox = new System.Windows.Forms.ComboBox();
			this.NoteTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Location = new System.Drawing.Point(13, 13);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(39, 17);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Title:";
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TitleTextBox.Location = new System.Drawing.Point(88, 8);
			this.TitleTextBox.MaxLength = 51;
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(453, 22);
			this.TitleTextBox.TabIndex = 1;
			this.TitleTextBox.Text = "Без названия";
			this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(12, 41);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
			this.CategoryLabel.TabIndex = 2;
			this.CategoryLabel.Text = "Category:";
			// 
			// CreatedTimeLabel
			// 
			this.CreatedTimeLabel.AutoSize = true;
			this.CreatedTimeLabel.Location = new System.Drawing.Point(13, 71);
			this.CreatedTimeLabel.Name = "CreatedTimeLabel";
			this.CreatedTimeLabel.Size = new System.Drawing.Size(62, 17);
			this.CreatedTimeLabel.TabIndex = 4;
			this.CreatedTimeLabel.Text = "Created:";
			// 
			// CreatedTimePicker
			// 
			this.CreatedTimePicker.Enabled = false;
			this.CreatedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.CreatedTimePicker.Location = new System.Drawing.Point(88, 66);
			this.CreatedTimePicker.Name = "CreatedTimePicker";
			this.CreatedTimePicker.Size = new System.Drawing.Size(177, 22);
			this.CreatedTimePicker.TabIndex = 5;
			// 
			// ModifiedLabel
			// 
			this.ModifiedLabel.AutoSize = true;
			this.ModifiedLabel.Location = new System.Drawing.Point(293, 71);
			this.ModifiedLabel.Name = "ModifiedLabel";
			this.ModifiedLabel.Size = new System.Drawing.Size(65, 17);
			this.ModifiedLabel.TabIndex = 6;
			this.ModifiedLabel.Text = "Modified:";
			// 
			// ModifiedTimePicker
			// 
			this.ModifiedTimePicker.Enabled = false;
			this.ModifiedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.ModifiedTimePicker.Location = new System.Drawing.Point(364, 66);
			this.ModifiedTimePicker.Name = "ModifiedTimePicker";
			this.ModifiedTimePicker.Size = new System.Drawing.Size(177, 22);
			this.ModifiedTimePicker.TabIndex = 7;
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelButton.Location = new System.Drawing.Point(466, 468);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 9;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// OkButton
			// 
			this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OkButton.Location = new System.Drawing.Point(385, 468);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 10;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CategoryComboBox
			// 
			this.CategoryComboBox.FormattingEnabled = true;
			this.CategoryComboBox.Location = new System.Drawing.Point(88, 38);
			this.CategoryComboBox.Name = "CategoryComboBox";
			this.CategoryComboBox.Size = new System.Drawing.Size(177, 24);
			this.CategoryComboBox.TabIndex = 11;
			this.CategoryComboBox.Text = "Stuff";
			// 
			// NoteTextBox
			// 
			this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteTextBox.Location = new System.Drawing.Point(13, 92);
			this.NoteTextBox.Name = "NoteTextBox";
			this.NoteTextBox.Size = new System.Drawing.Size(528, 370);
			this.NoteTextBox.TabIndex = 12;
			this.NoteTextBox.Text = "";
			// 
			// NoteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 503);
			this.Controls.Add(this.NoteTextBox);
			this.Controls.Add(this.CategoryComboBox);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.ModifiedTimePicker);
			this.Controls.Add(this.ModifiedLabel);
			this.Controls.Add(this.CreatedTimePicker);
			this.Controls.Add(this.CreatedTimeLabel);
			this.Controls.Add(this.CategoryLabel);
			this.Controls.Add(this.TitleTextBox);
			this.Controls.Add(this.TitleLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NoteForm";
			this.Text = "Add/Edit Note";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.Label CategoryLabel;
		private System.Windows.Forms.Label CreatedTimeLabel;
		private System.Windows.Forms.DateTimePicker CreatedTimePicker;
		private System.Windows.Forms.Label ModifiedLabel;
		private System.Windows.Forms.DateTimePicker ModifiedTimePicker;
		private new System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.ComboBox CategoryComboBox;
		private System.Windows.Forms.RichTextBox NoteTextBox;
	}
}