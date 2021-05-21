using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDisanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            //Arrange - converter object created
            DistanceConverter converter = new DistanceConverter();


            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1.0;
            //Act - distance is calculated
            converter.CalculateDistance();

            double expectedDistance = 5280;
            //Assert - result is tested with the expected result
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            //Arrange - converter object created
            DistanceConverter converter = new DistanceConverter();


            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 5280;
            //Act - distance is calculated
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            //Assert - result is tested with the expected result
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void MilesToMetres()
        {
            //Arrange - converter object created
            DistanceConverter converter = new DistanceConverter();


            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.METRES;

            converter.FromDistance = 1;
            //Act - distance is calculated
            converter.CalculateDistance();

            double expectedDistance = 1609;
            //Assert - result is tested with the expected result
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void MetresToMiles()
        {
            //Arrange - converter object created
            DistanceConverter converter = new DistanceConverter();


            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 1609;
            //Act - distance is calculated
            converter.CalculateDistance();

            double expectedDistance = 1;
            //Assert - result is tested with the expected result
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void MetresToFeet()
        {
            //Arrange - converter object created
            DistanceConverter converter = new DistanceConverter();


            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1;
            //Act - distance is calculated
            converter.CalculateDistance();

            double expectedDistance = 3.28084;
            //Assert - result is tested with the expected result
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void FeetToMetres()
        {
            //Arrange - converter object created
            DistanceConverter converter = new DistanceConverter();


            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.METRES;

            converter.FromDistance = 3.28084;
            //Act - distance is calculated
            converter.CalculateDistance();

            double expectedDistance = 1;
            //Assert - result is tested with the expected result
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

    }
}
