using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;


namespace NoteAppUI
{
	public partial class NoteForm : Form
	{
		/// <summary>
		/// Экземпляр класса Note.
		/// </summary>
		private Note _note;

		/// <summary>
		/// Возвращает и задаёт экземпляр заметки.
		/// </summary>
		public Note Note
		{
			get
			{
				return _note;
			}
			set
			{
				_note = value;
				if (_note != null)
				{
					TitleTextBox.Text = _note.Title;
					CategoryComboBox.SelectedItem = _note.Type;
					NoteTextBox.Text = _note.Text;
					CreatedTimePicker.Value = _note.CreationTime;
					ModifiedTimePicker.Value = _note.ModifiedTime;
				}
			}
		}
		public NoteForm()
		{
			InitializeComponent();
			CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

			var values = Enum.GetValues(typeof(NoteType));
			foreach(var value in values)
			{
				CategoryComboBox.Items.Add(value);
			}
		}

		private void TitleTextBox_TextChanged(object sender, EventArgs e)
		{
			if (TitleTextBox.Text.Length > 50)
			{
				this.TitleTextBox.ForeColor = Color.Red;
				MessageBox.Show("Название не должно превышать 50 символов.");
				TitleTextBox.Text = "Без названия";
			}
			else
			{
				this.TitleTextBox.ForeColor = Color.Black;
						}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			_note.Title = TitleTextBox.Text;
			_note.Type = (NoteType)CategoryComboBox.SelectedItem;
			_note.Text = NoteTextBox.Text;
			DialogResult = DialogResult.OK;
		}
	}
}