using System;
using System.Text;
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

        public double Stone { get; set; }

        public double Pounds { get; set; }

        public double Feet { get; set; }

        public double Inches { get; set; }

        public double Metres { get; set; }

        public double Centimetres { get; set; }

        public double Kilograms { get; set; }

        public const string FEET_AND_STONE = "Feet and Stone";

        public const string METRES_AND_KILOGRAMS = "Metres and Kilograms";

        //Choose between metric and imperial
        public string SystemChoice;

        public double BMIResult { get; set; }

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

        public void BMICalculator() 
        {
            OutputHeading();

            SystemChoice = selectSystem("\nPlease choose between the system conversions: ");

            storeValue();

            ConvertingValuesForCalculation();

            calculateBMI();

            Console.WriteLine("\nYour current BMI is " + BMIResult);

            GetHealthMessage();

            BAMEMessage();

            WHOStatus();
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

        public void ConvertingValuesForCalculation() 
        {
            Pounds = Pounds + (Stone * STONE_TO_POUNDS);
            Inches = Inches + (Feet * FEET_TO_INCHES);
            Metres = Centimetres / 100;
        }

        public void CalculateMetricBMI()
        {
            ConvertingValuesForCalculation();
            BMIResult= Kilograms / (Metres * Metres);
        }


        public void CalculateImperialBMI() 
        {
            ConvertingValuesForCalculation();
            BMIResult = Pounds * 703 / (Inches * Inches);
        }

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

        public string BAMEMessage() 
        {
            StringBuilder message = new StringBuilder("\n");

            message.Append($"If you are Black, Asian or any and other " +
                $"minority ethnic groups, or pregnant with a BMI over 25 " +
                $"then your BMI is putting you at a high health risk.");
          
            return message.ToString();
        }

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


        private void OutputHeading() 
        {
            Console.WriteLine("\n=============================");
            Console.WriteLine("         BMI Calculator      ");
            Console.WriteLine("         by Jamie Chopra     ");
            Console.WriteLine("=============================\n");
        }
    }


}
