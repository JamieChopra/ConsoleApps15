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
         * Method for converting feet into miles
         */
        public void ConvertFeetToMiles()
        {
            OutputHeading("Convert Feet to Miles");
            feet = InputDistance("Please input the number of feet: "); ;

            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        /**
         * Converts user input miles to metres and displays the result.
         */
        public void ConvertMilesToMetres()
        {
            OutputHeading("Convert Miles to Metres");
            miles = InputDistance("Please input the number of Miles: ");

            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        /*
         * Recieves user input for amount of miles the user wishes to convert.
         * Input must be given as a double number
         */
        public void ConvertMilesToFeet() 
        {
            OutputHeading("Convert Miles to Feet");
            miles = InputDistance("Please input the number of miles: ");

            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        /**
         * Converts miles input by user into Feet
         */
        private void CalculateFeet() 
        {
            feet = miles * FEET_IN_MILES;
        }

        /**
         * Calcuates the amount of miles based on the amount of feet the user has input
         */
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /**
         * Method for calculating the amount of metres
         */
        private void CalculateMetres()
        {
            metres = miles * MILES_IN_METRES;
        }

        /**
         * Method for reading line input and storing the value to be converted.
         */
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /**
         * Method for printing the amount of distance in each unit when converted
         */
        private void OutputDistance(double fromDistance, string fromUnit, double toDistance, string toUnit) 
        { 
            Console.WriteLine($" {fromDistance}  {fromUnit} is {toDistance} {toUnit}" );
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
