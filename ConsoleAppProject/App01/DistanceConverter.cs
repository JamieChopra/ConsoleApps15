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

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private string fromUnit;
        private string toUnit;

        private double fromDistance;
        private double toDistance;

        //Constructor to set starting values
        public DistanceConverter() 
        {
            fromUnit = MILES;
            toUnit = FEET;
        }


        /*
         * Recieves user input for amount of miles the user wishes to convert.
         * Input must be given as a double number
         */
        public void ConvertingDistance() 
        {
            fromUnit = SelectUnit("Please select from distance unit ");
            toUnit = SelectUnit("Please select the to distance unit ");

            OutputHeading($"Convert {fromUnit} to {toUnit}");
            fromDistance = InputDistance($"Please input the number of {fromUnit}: ");

            //CalculateFeet();
            OutputDistance();
        }

        private string SelectUnit(string prompt)
        {
            throw new NotImplementedException();
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
        private void OutputDistance() 
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
