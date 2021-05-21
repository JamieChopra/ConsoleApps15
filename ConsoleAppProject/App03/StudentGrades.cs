using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;


        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

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
        public void InputMarks() 
        {
            throw new NotImplementedException();
        }
        /**
         * Method for outputting the marks along with the students names
         */
        public void OutputMarks()
        {
            throw new NotImplementedException();
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
            else return Grades.D;
        }
        /**
         * Calculates the mean grade for the students
         */
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }

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
    }
}
