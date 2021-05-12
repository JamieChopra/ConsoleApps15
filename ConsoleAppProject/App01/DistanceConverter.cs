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
        //Constant to store conversion rate of metres to feet
        public const double METRES_IN_FEET = 3.28084;

        //Constant to store the string Feet which is used to identify when choosing a unit to convert
        public const string FEET = "Feet";
        //Constant to store the string Metres which is used to identify when choosing a unit to convert
        public const string METRES = "Metres";
        //Constant to store the string Miles which is used to identify when choosing a unit to convert
        public const string MILES = "Miles";

        //String to store variable of the unit you wish to convert
        private string fromUnit;
        //String to store variable of the unit you wish to convert to
        private string toUnit;

        //String to store variable of the distance of the unit in which you enter
        private double fromDistance;
        //String to store variable of the distance of the unit you have converted to
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
            OutputHeading();

            fromUnit = SelectUnit("\nPlease enter the unit you wish to convert: ");
            toUnit = SelectUnit("\nPlease enter the unit you wish to convert: ");

            Console.WriteLine($"\nConverting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" \nPlease input the number of {fromUnit}: ");

            CalculateDistance();
            OutputDistance();
        }

        /**
         * Method that determines which units will be used and therefore 
         * which calculation will take place
         */
        private string SelectUnit(string prompt)
        {
            string choice = chooseUnit(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\nYou have chosen {unit}");
            return unit;
        }

        /**
         * Method that allows for user input to determine which unit has been selected
         */
        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }

            else if (choice.Equals("2"))
            {
                return METRES;
            }

            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        /**
         * Method that assigns each unit with a number
         * The user can enter a number associated to a unit
         * The number is read by the method and stored in a variable
         */
        private static string chooseUnit(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
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
         * Contains if statements in which the units are determined by user input
         * The method scans the if statements to identify which calculation will be used.
         */
        private void CalculateDistance() 
        {
            if (fromUnit == MILES && toUnit == FEET) 
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }

            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * MILES_IN_METRES;
            }

            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }

            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / METRES_IN_FEET;
            }

            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * METRES_IN_FEET;
            }

            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / MILES_IN_METRES;
            }
        }

        /**
         * Method for printing a heading
         */
        private void OutputHeading() 
        {
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("      Distance Converter     ");
            Console.WriteLine("       by Jamie Chopra       ");
            Console.WriteLine("=============================");
            Console.WriteLine();
        }

    }
}
