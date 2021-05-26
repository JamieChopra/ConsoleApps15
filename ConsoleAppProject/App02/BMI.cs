using System;
using System.Text;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This application allows the user to choose between imperial and metric
    /// units and calculate their bmi based upon their inputted weigth and height.
    /// </summary>
    /// <author>
    /// Jamie Chopra version 0.1
    /// </author>
    public class BMI
    {   //Constant to convert stone to pounds
        public const int STONE_TO_POUNDS = 14;
        //Constant to convert feet to inches
        public const int FEET_TO_INCHES = 12;
        //Double to store weight in stone
        public double Stone { get; set; }
        //Double to store weight in pounds
        public double Pounds { get; set; }
        //Double to store height in feet
        public double Feet { get; set; }
        //Double to store height in inches
        public double Inches { get; set; }
        //Double to store height in metres
        public double Metres { get; set; }
        //Double to store height in centimeres
        public double Centimetres { get; set; }
        //Double to store weight in kilograms
        public double Kilograms { get; set; }
        //Constant to store feet and stone string used when choosing a conversion option
        public const string FEET_AND_STONE = "Feet and Stone";
        //Constant to store metres and kilograms string used when choosing a conversion option
        public const string METRES_AND_KILOGRAMS = "Metres and Kilograms";

        //Choose between metric and imperial
        public string SystemChoice;
        //Stores BMI calculation result
        public double BMIResult { get; set; }
        //Constructor to initialize all variables
        public BMI() 
        {
            this.Stone = 0;
            this.Pounds = 0;
            this.Feet = 0;
            this.Inches = 0;
            this.Metres = 0;
            this.Centimetres = 0;
            this.Kilograms = 0;
        }
        /**
         * Method that stores and calls other methods in order for application
         */
        public void BMICalculator() 
        {
            ConsoleHelper.OutputHeading("BMI Calculator");

            SystemChoice = selectSystem("\nPlease choose between the system conversions: ");

            storeValue();

            ConvertingValuesForCalculation();

            calculateBMI();

            Console.WriteLine("\nYour current BMI is " + BMIResult);

            GetHealthMessageApp();

            BAMEMessageApp();

            WHOStatus();
        }

        /**
         * Method that calls the choosesystem and performchoice to gain user input
         * for a choice between units of measurement
        */
        private string selectSystem(string prompt) 
        {
            string choice = chooseSystem(prompt);
            string unit = performChoice(choice);
            Console.WriteLine("\nYou are now calculating BMI using " + unit);
            return unit;
        }
        /**
         * Prints the options and takes user input and stores it in choice
         * User can choose either 1 for imperial or 2 for metric
         */
        private static string chooseSystem(string prompt) 
        {
            Console.WriteLine($" 1. {FEET_AND_STONE}");
            Console.WriteLine($" 2. {METRES_AND_KILOGRAMS}\n");

            string choice = Console.ReadLine();
            return choice;
        }
        /**
         * The value gained from userinput in chooseSystem is applied to perform choice
         * in order to determine whether 1 or 2 has been chosen and applies the metric
         * or imperial methods.
         */
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
        /**
         * Takes user input for value they wish to convert
         */
        private double InputValue(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /**
         * Calls inputvalue and stores the user input in the unit based upon their
         * previous choice in selectSystem
         */
        private void storeValue() 
        {
            if (SystemChoice == FEET_AND_STONE)
            {
                Feet = InputValue("\nPlease input the number of Feet: ");
                Inches = InputValue("\nPlease input the number of Inches: ");
                Stone = InputValue("\nPlease input the number of Stone: ");
                Pounds = InputValue("\nPlease input the number of Pounds: ");
            }
            else if (SystemChoice == METRES_AND_KILOGRAMS)
            {
                Centimetres = InputValue("\nPlease input the number of Centimetres: ");
                Kilograms = InputValue("\nPlease input the number of Kilograms: ");
            }
        }
        /**
         * Converts stone and feet to pounds and inches for calculations
         * Converts centimetres to metres for calculations
         */
        public void ConvertingValuesForCalculation() 
        {
            Pounds = Pounds + (Stone * STONE_TO_POUNDS);
            Inches = Inches + (Feet * FEET_TO_INCHES);
            Metres = Centimetres / 100;
        }
        /**
         * Calculates the BMI based on user inputted kilograms and metres
         * Calls the ConvertingValuesForCalulation in order for the calculation
         * to be simpler (Used in Web API)
         */
        public void CalculateMetricBMI()
        {
            ConvertingValuesForCalculation();
            BMIResult= Kilograms / (Metres * Metres);
        }

        /**
         * Calculates the BMI based on user inputted pounds and inches
         * Calls the ConvertingValuesForCalulation in order for the calculation
         * to be simpler (Used in Web API)
         */
        public void CalculateImperialBMI() 
        {
            ConvertingValuesForCalculation();
            BMIResult = Pounds * 703 / (Inches * Inches);
        }
        /**
         * Calculates BMI (Used in Console Application)
         */
        private void calculateBMI() 
        {
            if (SystemChoice == FEET_AND_STONE) 
            {
                BMIResult = Pounds * 703 / (Inches * Inches);
            }
            else if (SystemChoice == METRES_AND_KILOGRAMS)
            {
                BMIResult = Kilograms / (Metres * Metres);
            }
        }
        /**
         * Prints message warning certain ethnicities about their risk at
         * a high BMI (Used in Web API)
         */
        public string BAMEMessage() 
        {
            StringBuilder message = new StringBuilder("\n");

            message.Append($"If you are Black, Asian or any and other " +
                $"minority ethnic groups, or pregnant with a BMI over 25 " +
                $"then your BMI is putting you at a high health risk.");
          
            return message.ToString();
        }

        /**
         * Prints message warning certain ethnicities about their risk at
         * a high BMI (Used in Console Application)
         */
        public void BAMEMessageApp()
        {
                Console.WriteLine($"\nIf you are Black, Asian or any and other ");
                Console.WriteLine("minority ethnic groups, or pregnant with a BMI over 25 ");
                Console.WriteLine("then your BMI is putting you at a high health risk.");
        }

        /**
         * Prints the WhoStatus for BMI results (used in Console Application)
         */
        public void WHOStatus() 
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("WHO WEIGHT STATUS===BMI kg/m2");
            Console.WriteLine("    Underweight || < 18.50");
            Console.WriteLine("         Normal || 18.5 - 24.9");
            Console.WriteLine("     Overweight || 25.0 - 29.9");
            Console.WriteLine("  Obese Class 1 || 30.0 - 34.9");
            Console.WriteLine("  Obese Class 2 || 35.0 - 39.9");
            Console.WriteLine("  Obese Class 3 || >= 40.0");
            Console.WriteLine("=================================\n");
        }   
        /**
         * Prints health message based upon their BMI result (Used in both Web API and Console Application)
         */
        public string GetHealthMessage()
        {
            StringBuilder message = new StringBuilder("\n");

            if (BMIResult < 18.50)
                {
                message.Append($"Your BMI is {BMIResult}, You are underweight.");
                }
            else if (BMIResult >= 18.5 && BMIResult < 25)
            {
                message.Append($"Your BMI is {BMIResult}, You are a normal weight.");
            }
            else if (BMIResult >= 20 && BMIResult < 30)
            {
                message.Append($"Your BMI is {BMIResult}, You are overweight.");
            }
            else if (BMIResult >= 30 && BMIResult < 35)
            {
                message.Append($"Your BMI is {BMIResult}, You are in obese class 1.");
            }
            else if (BMIResult >= 35 && BMIResult < 40)
            {
                message.Append($"Your BMI is {BMIResult}, You are in obese class 2.");
            }
            else if (BMIResult >= 40)
            {
                message.Append($"Your BMI is {BMIResult}, You are in obese class 3.");
            }
            return message.ToString();
        }

        /**
         * Prints health message based upon their BMI result (Used in Console Application)
         */
        public void GetHealthMessageApp()
        {
            if (BMIResult < 18.50)
            {
                Console.WriteLine($"\nYou are underweight.");
            }
            else if (BMIResult >= 18.5 && BMIResult < 25)
            {
                Console.WriteLine($"\nYou are a normal weight.");
            }
            else if (BMIResult >= 20 && BMIResult < 30)
            {
                Console.WriteLine($"\nYou are overweight.");
            }
            else if (BMIResult >= 30 && BMIResult < 35)
            {
                Console.WriteLine($"\nYou are in obese class 1.");
            }
            else if (BMIResult >= 35 && BMIResult < 40)
            {
                Console.WriteLine($"\nYou are in obese class 2.");
            }
            else if (BMIResult >= 40)
            {
                Console.WriteLine($"\nYou are in obese class 3.");
            }
        }

    }


}
