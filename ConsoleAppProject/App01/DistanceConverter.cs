using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This application will recieve a value from the user of an amount of miles the user wishes to convert into feet,
    /// the application using the conversion rate will calculate and output the amount in feet to the user.
    /// </summary>
    /// <author>
    /// Jamie Chopra version 0.1
    /// </author>
    public class DistanceConverter
    {
        //Variable to store miles in decimals
        private double miles;

        //Variable to store feet in decimals
        private double feet;

        //Variable to store metres in decimals
        private double metres;

        //Constant to store conversion rate of miles to feet
        public const int FEET_IN_MILES = 5280;
        //Constant to store conversion rate of miles to metres
        public const int MILES_IN_METRES = 1609;

        /**
         *  Method that stores other methods and can be called within other classes
         */
        public void Run()
        {
            OutputHeading("Distance Converter");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /**
         * Method for converting feet into miles
         */
        public void ConvertFeetToMiles()
        {
            OutputHeading("Convert Feet to Miles");

            Console.Write("Please input the number of feet: ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
            CalculateMiles();
            OutputMiles();
        }

        /**
         * Method for printing the amount of miles based on feet the user has input
         */
        private void OutputMiles()
        {
            Console.WriteLine($"{feet} feet is  {miles} miles.");
        }

        /**
         * Calcuates the amount of miles based on the amount of feet the user has input
         */
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
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

        /**
         * Converts user input miles to metres and displays the result.
         */
        public void ConvertMilesToMetres() 
        {
            OutputHeading("Convert Miles to Metres");

            Console.Write("Please input the number of Miles: ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            CalculateMetres();
            OutputMetres();
        }

        /**
         * Method for calculating the amount of metres
         */
        private void CalculateMetres()
        {
            metres = miles * MILES_IN_METRES;
        }

        /**
         * Prints string presenting the amount of metres in the amount of miles the user has input.
         */
        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres.");
        }

        /**
         * Method for printing a heading
         */
        private void OutputHeading(string title) 
        {
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine($"   {title}  ");
            Console.WriteLine("       by Jamie Chopra       ");
            Console.WriteLine("=============================");
            Console.WriteLine();
        }
    }
}
