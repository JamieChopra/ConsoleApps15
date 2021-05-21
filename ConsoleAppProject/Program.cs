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
            while (true)
            {
                //Creating an object of the distance converter
                DistanceConverter converter = new DistanceConverter();
                //Creating an object of the BMI calculator
                BMI bmi = new BMI();

                //Creating an object of the student grades
                StudentGrades grades = new StudentGrades();


                Console.ForegroundColor = ConsoleColor.Yellow;

                ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020-2021!\n");

                string[] choices = { "Distance Converter", "BMI Calculator", "Student Grades", "Quit" };

                int choiceNo = ConsoleHelper.SelectChoice(choices);


                if (choiceNo == 1)
                {
                    converter.ConvertingDistance();
                }

                else if (choiceNo == 2)
                {
                    bmi.BMICalculator();
                }

                else if (choiceNo == 3)
                {
                    grades.ChooseMethod();
                }
                else if(choiceNo == 4) 
                {
                    break;
                }

                else
                {
                    Console.WriteLine("\nYou have entered an invalid choice");
                }
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
