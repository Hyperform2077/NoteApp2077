using System;
using System.Collections.Generic;
using NoteApp;


namespace NoteApp
{
	/// <summary>
	/// Класс проекта, содержащий список всех заметок, созданных в приложении.
	/// </summary>
	public class Project
	{
		/// <summary>
		/// Поле класса "Project", содержащее список заметок.
		/// </summary>
		private List<Note> _notes = new List<Note>();

		/// <summary>
		/// Текущая заметка.
		/// </summary>
		public int CurrentNote = 0;

		/// <summary>
		/// Возвращает и создаёт список заметок.
		/// </summary>
		public List<Note> Notes
		{
			get
			{
				return _notes;
			}
			set
			{
				_notes = value;
			}
		}

		/// <summary>
		/// Сортировка заметок по категориям.
		/// </summary>
		public List<Note> SortNoteType(string value)
		{
			List<Note> NoteTypeList = new List<Note>();
			NoteType result;

			foreach (var note in Notes)
			{
				if (Enum.TryParse(value, out result) && (result == note.Type))
					NoteTypeList.Add(note);
			}
			return NoteTypeList;
		}

        /// <summary>
        /// Метод сортировки заметок по дате изменения
        /// </summary>
        public List<Note> SortModifiedTime()
        {
			List<Note> sortingList = Notes;

			sortingList.Sort((x, y) => y.ModifiedTime.CompareTo(x.ModifiedTime));
			return sortingList;
        }	
	}
}
