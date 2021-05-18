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

        private double Stone;

        private double Pounds;

        private double Feet;

        private double Inches;

        private double Centimetres;

        private double Kilograms;

        public const string FEET_AND_STONE = "Feet and Stone";

        public const string METRES_AND_KILOGRAMS = "Metres and Kilograms";

        //Choose between metric and imperial
        private string SystemChoice;

        //Stores double value to then be used in calculation
        private double firstValue;
        //Stores second double value to then be used in calculation
        private double secondValue;
        //Stores third double value to then be used in calculation
        private double thirdValue;
        //Stores fourth double value to then be used in calculation
        private double fourthValue;

        private double BMIResult;

        public void BMICalculator() 
        {
            OutputHeading();

            SystemChoice = selectSystem("\nPlease choose between the system conversions: ");

            storeValue();
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

        private void storeValue() 
        {
            if (SystemChoice == FEET_AND_STONE)
            {
                firstValue = InputValue("\nPlease input the number of Feet: ");
                secondValue = InputValue("\nPlease input the number of Inches: ");
                thirdValue = InputValue("\nPlease input the number of Stone: ");
                fourthValue = InputValue("\nPlease input the number of Pounds: ");
                Feet = firstValue;
                Inches = secondValue;
                Stone = thirdValue;
                Pounds = fourthValue;
            }
            else if (SystemChoice == METRES_AND_KILOGRAMS)
            {
                firstValue = InputValue("\nPlease input the number of Centimetres: ");
                secondValue = InputValue("\nPlease input the number of Kilograms: ");
                Centimetres = firstValue;
                Kilograms = secondValue;
            }
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
