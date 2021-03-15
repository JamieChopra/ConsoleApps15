using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Jamie Chopra version 0.1
    /// </author>
    public class DistanceConverter
    {

        private double miles;

        private double feet;

        public const int FEET_IN_MILES = 5280;

        /**
         *  Method that stores other methods and can be called within other classes
         */
        public void Run() 
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /*
         * Recieves user input for amount of miles the user wishes to convert.
         * Input must be given as a double number
         */
        private void InputMiles() 
        {
            Console.Write("Please input the number of miles: ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /**
         * Converts miles input by user into Feet
         */
        private void CalculateFeet() 
        {
            feet = miles * FEET_IN_MILES;
        }

        /**
         * Outputs the calculation of miles to feet.
         */
        private void OutputFeet() 
        {
            Console.WriteLine(miles + " miles is " + feet + " feet.");
        }

        private void OutputHeading() 
        {
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("   Converting Miles to feet  ");
            Console.WriteLine("       by Jamie Chopra       ");
            Console.WriteLine("=============================");
            Console.WriteLine();
        }
    }
}
