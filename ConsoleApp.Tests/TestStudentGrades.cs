
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{   [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        [TestMethod]
        public void TestConvert0ToGradeF() 
        {

            Grades expectedGrade = Grades.F;

            Grades actualGrade = converter.ConvertToGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }
    }
}
