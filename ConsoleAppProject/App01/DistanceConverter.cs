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
        public string FromUnit { get; set; }
        //String to store variable of the unit you wish to convert to
        public string ToUnit { get; set; }

        //Double to store variable of the distance of the unit in which you enter
        public double FromDistance { get; set; }
        //Double to store variable of the distance of the unit you have converted to
        public double ToDistance { get; set; }


        //Constructor to set starting values
        public DistanceConverter() 
        {
            FromUnit = MILES;
            ToUnit = FEET;
        }


        /*
         * Recieves user input for amount of miles the user wishes to convert.
         * Input must be given as a double number
         */
        public void ConvertingDistance() 
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit("\nPlease enter the unit you wish to convert: ");
            ToUnit = SelectUnit("\nPlease enter the unit you wish to convert: ");

            Console.WriteLine($"\nConverting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" \nPlease input the number of {FromUnit}: ");

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
            else 
            {
                Console.WriteLine("You have entered an invalid value.");
                return null;
            }
            
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
            Console.WriteLine($" {FromDistance}  {FromUnit} is {ToDistance} {ToUnit}" );
        }

        /**
         * Contains if statements in which the units are determined by user input
         * The method scans the if statements to identify which calculation will be used.
         */
        public void CalculateDistance() 
        {
            if (FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }

            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance * MILES_IN_METRES;
            }

            else if (FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }

            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance / METRES_IN_FEET;
            }

            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance * METRES_IN_FEET;
            }

            else if (FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance / MILES_IN_METRES;
            }
            else 
            {
                Console.WriteLine("You have entered an invalid value.");
            }
        }

       

    }
}
