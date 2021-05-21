
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

        [TestMethod]
        public void TestCalculateMin() 
        {
            converter.Marks = testMarks;
            int expectedMin = 10;

            converter.CalculateStats();

            Assert.AreEqual(expectedMin, converter.Minimum);
        }

        [TestMethod]
        public void TestCalculateMax()
        {
            converter.Marks = testMarks;
            int expectedMax = 100;

            converter.CalculateStats();

            Assert.AreEqual(expectedMax, converter.Maximum);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            converter.Marks = testMarks;
            bool expectedProfile = false;

            converter.CalculateGradeProfile();

            expectedProfile= ((converter.GradeProfile[0] == 3) &&
                             (converter.GradeProfile[1] == 1) &&
                             (converter.GradeProfile[2] == 1) &&
                             (converter.GradeProfile[3] == 1) &&
                             (converter.GradeProfile[4] == 4));

            Assert.IsTrue(expectedProfile);
        }
    }
}
