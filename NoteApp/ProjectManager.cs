using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;


namespace NoteApp
{
	/// <summary>
	/// Класс, хранящий метод сохранения объекта "Проект"
	/// в файл и загрузки объекта из файла.
	/// </summary>
	public static class ProjectManager
	{
		/// <summary>
		/// Поле класса "ProjectManager", содержащее название файла.
		/// </summary>
		private const string _name = @"\NotesApp.notes";

		/// <summary>
		/// Поле класса "ProjectManager", содержащее путь файла.
		/// </summary>
		private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

		/// <summary>
		/// Поле класса "ProjectManager", содержащее название файла и путь к нему.
		/// </summary>
		public static string _file = _path + _name;

		/// <summary>
		/// Реализует сохранение объекта "Проект" в файл.
		/// </summary>
		/// <param name="project">Указание проекта, который нужно сохранить.</param>
		/// <param name="file">Указание местоположения файла, который нужно сохранить.</param>
		public static void SaveToFile(Project project, string file)
		{
			_file = file;

			// Создаём экземпляр сериализатора.
			JsonSerializer serializer = new JsonSerializer();
			serializer.Formatting = Formatting.Indented;

			// Открываем поток для записи в файл с указанием пути.
			using (StreamWriter sw = new StreamWriter(_file))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				// Вызываем сериализацию и передаём объект, который хотим сериализовать.
				serializer.Serialize(writer, project);
			}
		}

		/// <summary>
		/// Реализует загрузку объекта "Проект" из файла.
		/// </summary>
		public static Project LoadFromFile(string file)
		{
			_file = file;

			// Создаём экземпляр сериализатора.
			JsonSerializer serializer = new JsonSerializer();
			serializer.Formatting = Formatting.Indented;

			// Открываем поток для чтения из файла с указанием пути.
			using (StreamReader sr = new StreamReader(_file))
			using (JsonReader reader = new JsonTextReader(sr))
			{
				// Вызываем десериализацию и явно преобразуем результат в целевой тип данных
				var project = (Project)serializer.Deserialize<Project>(reader);
				return project;
			}
		}
	}
}
