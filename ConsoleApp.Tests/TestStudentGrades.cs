
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{   [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        private int[] testMarks;

        public TestStudentGrades() 
        {
            testMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }

        [TestMethod]
        public void TestConvert0ToGradeF() 
        {

            Grades expectedGrade = Grades.F;

            Grades actualGrade = converter.ConvertToGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {

            Grades expectedGrade = Grades.F;

            Grades actualGrade = converter.ConvertToGrade(39);

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestCalculateMean()
        {
            converter.Marks = testMarks;

            double expectedMean = 55.0;

            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
        }

    }
}
