using System;


namespace NoteApp
{
	/// <summary>
	/// Перечисление категорий заметки.
	/// </summary>
	public enum NoteType
	{
		/// <summary>
		/// Категория "Документы".
		/// </summary>
		Documents = 1,

		/// <summary>
		/// Категория "Финансы".
		/// </summary>
		Finance,

		/// <summary>
		/// Категория "Здоровье и спорт".
		/// </summary>
		HealthNSport,

		/// <summary>
		/// Категория "Дом".
		/// </summary>
		Home,

		/// <summary>
		/// Категория "Люди".
		/// </summary>
		People,

		/// <summary>
		/// Категория "Работа".
		/// </summary>
		Job,

		/// <summary>
		/// Категория "Разное".
		/// </summary>
		Stuff
	}
}