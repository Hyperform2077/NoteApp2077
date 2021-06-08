using System.Collections.Generic;
using NUnit.Framework;


namespace NoteApp.UnitTests
{
	/// <summary>
	/// Юнит-тест для класса Project.
	/// </summary>
	[TestFixture]
	public class ProjectTest
	{
		[Test(Description = "Позитивный тест геттера Notes")]
		public void TestNotesGet_CorrectValue()
		{
			Project project = new Project();
			var expected = new List<Note>();
			project.Notes = expected;
			var actual = project.Notes;

			Assert.AreEqual(expected, actual, "Геттер Notes возвращает неправильное значение");
		}
	}
}
