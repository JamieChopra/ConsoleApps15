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

        /**
         *  Method that stores other methods and can be called within other classes
         */
        public void Run() 
        {
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
        
        }

        /**
         * Outputs the calculation of miles to feet.
         */
        private void OutputFeet() 
        {
        
        }
    }
}
