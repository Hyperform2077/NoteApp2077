using Newtonsoft.Json;
using System;


namespace NoteApp
{
	/// <summary>
	/// Класс заметки, хранящий информацию о её названии, категории, тексте,
	/// времени создания, времени последнего изменения.
	/// </summary>
	public class Note : ICloneable
	{
		/// <summary>
		/// Поле класса "Note", содержащее название заметки.
		/// </summary>
		private string _title = "Без названия";

		/// <summary>
		/// Поле класса "Note", содержащее категорию заметки.
		/// </summary>
		private NoteType _type = NoteType.Stuff;

		/// <summary>
		/// Поле класса "Note", содержащее текст заметки.
		/// </summary>
		private string _text = "";

		/// <summary>
		/// Поле класса "Note", содержащее время создания заметки.
		/// </summary>
		private DateTime _creationTime = DateTime.Now;

		/// <summary>
		/// Поле класса "Note", содержащее время изменения заметки.
		/// </summary>
		private DateTime _modifiedTime = DateTime.Now;
		public Note() { }

		public Note(DateTime CT, DateTime MT)
		{
			_creationTime = CT;
			_modifiedTime = MT;
		}
		/// <summary>
		/// Возвращает и задаёт название заметки (не более 50 символов).
		/// </summary>
		public string Title
		{
			get
			{
				return _title;
			}

			set
			{

				if (value.Length > 50)
				{
					throw new ArgumentException("Название не должно превышать 50 символов.\n" +
						" Количество символов: " + Title.Length);
				}
				if (value == "")
				{
					throw new ArgumentException("Название строки не должно быть пустой строкой");
				}
				_title = value;
				ModifiedTime = DateTime.Now;
			}
		}

		/// <summary>
		/// Возвращает и задаёт категорию заметки.
		/// </summary>
		public NoteType Type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
				ModifiedTime = DateTime.Now;
			}
		}

		/// <summary>
		/// Возвращает и задаёт текст заметки.
		/// </summary>
		public string Text
		{
			get
			{
				return _text;
			}
			set
			{
				_text = value;
				ModifiedTime = DateTime.Now;
			}
		}

		/// <summary>
		/// Возвращает дату создания заметки (доступно только для чтения).
		/// </summary>
		[JsonProperty]
		public DateTime CreationTime
		{
			get
			{
				return _creationTime;
			}
			private set
			{
				_creationTime = value;
			}
		}

		/// <summary>
		/// Возвращает и задаёт время изменения заметки.
		/// </summary>
		[JsonProperty]
		public DateTime ModifiedTime
		{
			get
			{
				return _modifiedTime;
			}

			private set
			{
				_modifiedTime = value;
			}
		}

		/// <summary>
		/// Реализует возможность создавать копии существующих заметок.
		/// </summary>
		/// <returns>Возвращает новую заметку с существующим названием.</returns>
		public object Clone()
		{
			return new Note()
			{ 
				Title = Title,
				Type = Type,
				Text = Text,
				CreationTime = CreationTime,
				ModifiedTime = ModifiedTime
			};
		}

		public override bool Equals(object obj)
		{
			if (obj.GetType() != GetType()) return false;

			Note note = (Note)obj;
			return (Title == note.Title & 
					Type == note.Type &
					Text == note.Text &
					CreationTime == note.CreationTime &
					ModifiedTime == note.ModifiedTime);
		}
	}
}