namespace NoteAppUI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.NotesListBox = new System.Windows.Forms.ListBox();
			this.EditButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.ShowCategoryComboBox = new System.Windows.Forms.ComboBox();
			this.ShowCategoryLabel = new System.Windows.Forms.Label();
			this.TextRichTextBox = new System.Windows.Forms.RichTextBox();
			this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.ModifiedLabel = new System.Windows.Forms.Label();
			this.CreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.CreatedTimeLabel = new System.Windows.Forms.Label();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(881, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addNoteToolStripMenuItem
			// 
			this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
			this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
			this.addNoteToolStripMenuItem.Text = "Add Note";
			this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
			// 
			// editNoteToolStripMenuItem
			// 
			this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
			this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
			this.editNoteToolStripMenuItem.Text = "Edit Note";
			this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
			// 
			// removeNoteToolStripMenuItem
			// 
			this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
			this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
			this.removeNoteToolStripMenuItem.Text = "Remove Note";
			this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 28);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.NotesListBox);
			this.splitContainer1.Panel1.Controls.Add(this.EditButton);
			this.splitContainer1.Panel1.Controls.Add(this.RemoveButton);
			this.splitContainer1.Panel1.Controls.Add(this.AddButton);
			this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryComboBox);
			this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.TextRichTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.ModifiedDateTimePicker);
			this.splitContainer1.Panel2.Controls.Add(this.ModifiedLabel);
			this.splitContainer1.Panel2.Controls.Add(this.CreateDateTimePicker);
			this.splitContainer1.Panel2.Controls.Add(this.CreatedTimeLabel);
			this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.TitleLabel);
			this.splitContainer1.Size = new System.Drawing.Size(881, 502);
			this.splitContainer1.SplitterDistance = 292;
			this.splitContainer1.TabIndex = 1;
			// 
			// NotesListBox
			// 
			this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NotesListBox.FormattingEnabled = true;
			this.NotesListBox.ItemHeight = 16;
			this.NotesListBox.Location = new System.Drawing.Point(15, 43);
			this.NotesListBox.Name = "NotesListBox";
			this.NotesListBox.Size = new System.Drawing.Size(270, 404);
			this.NotesListBox.TabIndex = 6;
			this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
			// 
			// EditButton
			// 
			this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.EditButton.FlatAppearance.BorderSize = 0;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.Image = global::NoteAppUI.Properties.Resources.icons8_edit_file_16;
			this.EditButton.Location = new System.Drawing.Point(40, 467);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(22, 22);
			this.EditButton.TabIndex = 5;
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RemoveButton.FlatAppearance.BorderSize = 0;
			this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveButton.Image = global::NoteAppUI.Properties.Resources.icons8_file_delete_16;
			this.RemoveButton.Location = new System.Drawing.Point(68, 467);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(22, 22);
			this.RemoveButton.TabIndex = 4;
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddButton.FlatAppearance.BorderSize = 0;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddButton.Image = global::NoteAppUI.Properties.Resources.icons8_add_file_16;
			this.AddButton.Location = new System.Drawing.Point(12, 467);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(22, 22);
			this.AddButton.TabIndex = 3;
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// ShowCategoryComboBox
			// 
			this.ShowCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ShowCategoryComboBox.FormattingEnabled = true;
			this.ShowCategoryComboBox.Location = new System.Drawing.Point(125, 13);
			this.ShowCategoryComboBox.Name = "ShowCategoryComboBox";
			this.ShowCategoryComboBox.Size = new System.Drawing.Size(160, 24);
			this.ShowCategoryComboBox.TabIndex = 1;
			this.ShowCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ShowCategoryComboBox_SelectedIndexChanged);
			// 
			// ShowCategoryLabel
			// 
			this.ShowCategoryLabel.AutoSize = true;
			this.ShowCategoryLabel.Location = new System.Drawing.Point(12, 16);
			this.ShowCategoryLabel.Name = "ShowCategoryLabel";
			this.ShowCategoryLabel.Size = new System.Drawing.Size(107, 17);
			this.ShowCategoryLabel.TabIndex = 0;
			this.ShowCategoryLabel.Text = "Show Category:";
			// 
			// TextRichTextBox
			// 
			this.TextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextRichTextBox.BackColor = System.Drawing.SystemColors.Menu;
			this.TextRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TextRichTextBox.Location = new System.Drawing.Point(17, 109);
			this.TextRichTextBox.Name = "TextRichTextBox";
			this.TextRichTextBox.ReadOnly = true;
			this.TextRichTextBox.Size = new System.Drawing.Size(562, 388);
			this.TextRichTextBox.TabIndex = 7;
			this.TextRichTextBox.Text = "";
			// 
			// ModifiedDateTimePicker
			// 
			this.ModifiedDateTimePicker.Enabled = false;
			this.ModifiedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.ModifiedDateTimePicker.Location = new System.Drawing.Point(297, 83);
			this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
			this.ModifiedDateTimePicker.Size = new System.Drawing.Size(123, 22);
			this.ModifiedDateTimePicker.TabIndex = 6;
			// 
			// ModifiedLabel
			// 
			this.ModifiedLabel.AutoSize = true;
			this.ModifiedLabel.Location = new System.Drawing.Point(226, 83);
			this.ModifiedLabel.Name = "ModifiedLabel";
			this.ModifiedLabel.Size = new System.Drawing.Size(65, 17);
			this.ModifiedLabel.TabIndex = 5;
			this.ModifiedLabel.Text = "Modified:";
			// 
			// CreateDateTimePicker
			// 
			this.CreateDateTimePicker.Enabled = false;
			this.CreateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.CreateDateTimePicker.Location = new System.Drawing.Point(85, 83);
			this.CreateDateTimePicker.Name = "CreateDateTimePicker";
			this.CreateDateTimePicker.Size = new System.Drawing.Size(123, 22);
			this.CreateDateTimePicker.TabIndex = 4;
			// 
			// CreatedTimeLabel
			// 
			this.CreatedTimeLabel.AutoSize = true;
			this.CreatedTimeLabel.Location = new System.Drawing.Point(17, 83);
			this.CreatedTimeLabel.Name = "CreatedTimeLabel";
			this.CreatedTimeLabel.Size = new System.Drawing.Size(62, 17);
			this.CreatedTimeLabel.TabIndex = 3;
			this.CreatedTimeLabel.Text = "Created:";
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(82, 53);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(37, 17);
			this.CategoryLabel.TabIndex = 2;
			this.CategoryLabel.Text = "Stuff";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Category:";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLabel.Location = new System.Drawing.Point(14, 13);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(220, 33);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Название заметки";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(881, 530);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "NoteApp";
			this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label ShowCategoryLabel;
		private System.Windows.Forms.ComboBox ShowCategoryComboBox;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
		private System.Windows.Forms.Label ModifiedLabel;
		private System.Windows.Forms.DateTimePicker CreateDateTimePicker;
		private System.Windows.Forms.Label CreatedTimeLabel;
		private System.Windows.Forms.Label CategoryLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox TextRichTextBox;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.ListBox NotesListBox;
	}
}