using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
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

                NetworkApp app04 = new NetworkApp();

                Console.ForegroundColor = ConsoleColor.Yellow;

                ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020-2021!\n");

                string[] choices = { "Distance Converter", "BMI Calculator", "Student Grades", "Social Network", "Quit" };

                int choiceNo = ConsoleHelper.SelectChoice(choices);

                /**
                 * Uses if statements and a while loop and list of strings to allow user to
                 * decide on which application they wish to use based upon their inputted number
                 * 1-4
                 * 5 Is a Quit choice which will break the loop and end the application
                 */

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
                    app04.DisplayMenu();
                }
                else if (choiceNo == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nYou have entered an invalid choice");
                }
            }
        }
    }
}
