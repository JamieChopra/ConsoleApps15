﻿using ConsoleAppProject.Helpers;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This application allows a list of marks to be added to a list of students
    /// and converts their marks into grades based upon their boundary.
    /// It also calculates and prints the mean mark, maximum mark and minimum mark.
    /// </summary>
    /// <author>
    /// Jamie Chopra version 0.1
    /// </author>
    public class StudentGrades
    {
        //Constants to store the values of each grade boundary
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //String list to store student names
        public string[] Students { get; set; }
        //Int list to store student marks
        public int[] Marks { get; set; }
        //Int list to store students grade
        public int[] GradeProfile { get; set; }
        //Double used to store mean
        public double Mean { get; set; }
        //Int used to store minimum mark
        public int Minimum { get; set; }
        //Int used to store maximum mark
        public int Maximum { get; set; }
        /*
         * Constructor to create a new students list and added 10 students
         * Gradeprofile added utilising Grades enumeration
         * New list of marks created to match the length of the students list
         */
        public StudentGrades()
        {
            Students = new string[]
            {
                "Mark", "Steve", "Luke", "Jessica",
                "Jake", "Samantha", "George", "Clare",
                "Harry", "Abdul"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];


        }
        /**
         * Method for inputting a mark in which is then stored in the array
         */
        public int[] InputMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(Students[i] + ":");
                string results = Console.ReadLine();
                Marks[i] = Convert.ToInt32(results);
            }

            return Marks;

        }
        /**
         * Method for outputting the marks along with the students names
         */
        public void OutputMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(Students[i] + ": " + Marks[i]);
            }
        }
        /**
         * Converts students marks to grades
         */
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            else return Grades.X;
        }
        /**
         * Calculates the mean grade for the students
         */
        public void CalculateStats()
        {
            Maximum = Marks[0];
            Minimum = Marks[0];

            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total = total + mark;
            }

            Mean = total / Marks.Length;
        }

        /**
         * Goes through list of students marks converts it to a grade
         * Grade is added to a students profile
         * Amount of students with grade is calculated
         */
        public void CalculateGradeProfile()
        {
            for (int i = 0; i > GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }


        /**
         * Goes through the list of grades and calculates their percentage
         */
        private void OutputGradeProfile()
        {
            Grades grade = Grades.X;
            
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}\n");
                grade++;
            }
        }

        /**
         * Outputs (prints) the minimum, maximum and mean marks.
         */
        public void OutputStats()
        {
            CalculateStats();
            Console.WriteLine("\nThe Minimum mark inputted was: " + Minimum);
            Console.WriteLine("\nThe Maximum mark inputted was: " + Maximum);
            Console.WriteLine("\nThe Mean mark is: " + Mean);
        }

        /**
         * Method created to test the use of the enumeration
         */
        public void TestGradesEnumeration()
        {
            Grades grade = Grades.C;

            Console.WriteLine($"Grade = {grade}");
            Console.WriteLine($"Grade No = {(int)grade}");

            Console.WriteLine("\nDiscovered by Andrei!\n");
            var gradeName = grade.GetAttribute<DisplayAttribute>().Name;
            Console.WriteLine($"Grade Name = {gradeName}");

            var gradeDescription = grade.GetAttribute<DescriptionAttribute>().Description;
            Console.WriteLine($"Grade Description = {gradeDescription}");

            string testDescription = EnumHelper<Grades>.GetDescription(grade);
            string testName = EnumHelper<Grades>.GetName(grade);

            Console.WriteLine();
            Console.WriteLine("Discovered by Derek Using EnumHelper\n");
            Console.WriteLine($"Name = {testName}");
            Console.WriteLine($"Description = {testDescription}");

        }

        /**
         * Method with a while loop to allow user to choose between the method they want to use
         * Quit option breaks the loop and returns the user back to the list of applications.
         */
        public void ChooseMethod() 
        {

            while (true)
            {

                ConsoleHelper.OutputHeading("   Student Grades\n");

                string[] choices = { "Input Marks", "Output Marks", "Output Stats", "Output Grade Profile", "Quit" };

                int choiceNo = ConsoleHelper.SelectChoice(choices);

                if (choiceNo == 1)
                {
                    InputMarks();
                }

                else if (choiceNo == 2)
                {
                    OutputMarks();
                }

                else if (choiceNo == 3)
                {
                    OutputStats();
                }
                else if (choiceNo == 4)
                {
                    CalculateGradeProfile();
                    OutputGradeProfile();
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
