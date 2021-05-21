using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Jamie Chopra 14/12/2020
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020-2021!\n");

            string[] choices = { "Distance Converter", "BMI Calculator", "Student Grades" };

            ConsoleHelper.SelectChoice(choices);

            Console.Write("Please enter your choice of Applications >");
            string choice = Console.ReadLine();


            DistanceConverter converter = new DistanceConverter();

            BMI bmi = new BMI();

            // Using an extension method for any enumeration
            StudentGrades grades = new StudentGrades();
            

            if (choice.Equals("1"))
            {
                converter.ConvertingDistance();
            }

            else if (choice.Equals("2"))
            {
                bmi.BMICalculator();
            }

            else if (choice.Equals("3"))
            {
                grades.TestGradesEnumeration();
            }

            /**
            // Using an extension method for each enumeration
            Console.WriteLine("Using MyEnum Extension Method!\n");
            Console.WriteLine("MyEnum Value = " + MyEnum.FirstValue);
            Console.WriteLine("MyEnum Friendly Value = " + MyEnum.FirstValue.EnumValue());
            Console.WriteLine();
            */

           

        }
    }
}
