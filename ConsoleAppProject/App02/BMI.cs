using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        public const int STONE_TO_POUNDS = 14;

        public const int FEET_TO_INCHES = 12;

        private int Stone;

        private int Pounds;

        private int Feet;

        private int Inches;

        private int Centimetres;

        private double Kilograms;

        public const string FEET_AND_STONE = "Feet and Stone";

        public const string METRES_AND_KILOGRAMS = "Metres and Kilograms";

        //Choose between metric and imperial
        private string SystemChoice;

        private double Conversion;

        private double BMIResult;

        public void BMICalculator() 
        {
            OutputHeading();

            SystemChoice = selectSystem("\nPlease choose between the system conversions: ");

            Conversion = InputValue("\nPlease input the value of " + );
        }
        
        private string selectSystem(string prompt) 
        {
            string choice = chooseSystem(prompt);
            string unit = performChoice(choice);
            Console.WriteLine("\nYou are now calculating BMI using " + unit);
            return unit;
        }

        private static string chooseSystem(string prompt) 
        {
            Console.WriteLine($" 1. {FEET_AND_STONE}");
            Console.WriteLine($" 2. {METRES_AND_KILOGRAMS}\n");

            string choice = Console.ReadLine();
            return choice;
        }

        private static string performChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET_AND_STONE;
            }
            else if (choice.Equals("2"))
            {
                return METRES_AND_KILOGRAMS;
            }
            else
            {
                Console.WriteLine("\nYou have entered an invalid value.");
                BMI restartBMI = new BMI();
                restartBMI.BMICalculator();
                return null;
            }
        }

        private double InputValue(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private static string AllocatingUnit() 
        {
        }

        private void calculateBMI() 
        {
            if (SystemChoice == FEET_AND_STONE) 
            {
                BMIResult = Pounds * 703 / (Inches * Inches);
            }
            else if (SystemChoice == METRES_AND_KILOGRAMS)
            {

            }
        }

            private void OutputHeading() 
        {
            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("         BMI Calculator      ");
            Console.WriteLine("         by Jamie Chopra     ");
            Console.WriteLine("=============================");
            Console.WriteLine("");
        }
    }


}
