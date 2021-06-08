using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;


namespace NoteApp.UnitTests
{
	/// <summary>
	/// Юнит-тест для класса "ProjectManager".
	/// </summary>
	[TestFixture]
	public class ProjectManagerTest
	{
		/// <summary>
		/// Поле класса "ProjectManagerTest", содержащее объект класса "Note".
		/// </summary>
		private Note _testNote1;

		/// <summary>
		/// Поле класса "ProjectManagerTest", содержащее объект класса "Note".
		/// </summary>
		private Note _testNote2;

		/// <summary>
		/// Поле класса "ProjectManagerTest", содержащее объект класса "Project".
		/// </summary>
		private Project _testProject;

		[SetUp]
		public void Init()
		{
			DateTime CreationTime = new DateTime(2019, 12, 10);
			DateTime ModifiedTime = new DateTime(2019, 12, 11);

			_testProject = new Project();
			_testNote1 = new Note(CreationTime, ModifiedTime);
			_testNote2 = new Note(CreationTime, ModifiedTime);
		}

		[Test(Description = "Тест на сериализацию")]
		public void TestSaveToFile_CorrectValuе()
		{
			_testProject.Notes.Add(_testNote1);
			_testProject.Notes.Add(_testNote2);

			string name = @"\NotesApp.notes";
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string file = path + name;
			var actual = File.ReadAllText(file);

			ProjectManager.SaveToFile(_testProject, file);

			var expected = File.ReadAllText(file);

			Assert.AreEqual(expected, actual, "Ошибка сериализации");
		}

		[Test(Description = "Тест на десериализацию")]
		public void TestLoadFromFile_CorrectValue()
		{
			_testProject.Notes.Add(_testNote1);
			_testProject.Notes.Add(_testNote2);

			string name = @"\NotesApp.notes";
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string file = path + name;

			var expected = _testProject.Notes;
			var testProject = ProjectManager.LoadFromFile(file);
			var actual = testProject.Notes;

			for(int testIndex = 0; testIndex < expected.Count; testIndex++)
			{
				bool isClone = expected[testIndex].Equals(actual[testIndex]);
				Assert.IsTrue(isClone);
			}
		}
	}
}
