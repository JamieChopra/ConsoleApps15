using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        /**
         * Method for printing a heading
         */
        public static void OutputHeading(string title) 
        {
                Console.WriteLine();
                Console.WriteLine("=============================");
                Console.WriteLine($"    {title}");
                Console.WriteLine("       by Jamie Chopra       ");
                Console.WriteLine("=============================");
                Console.WriteLine();
            
        }

        /**
         * Displays choices and recieves user input for their choice
         */
        public static int SelectChoice(string[] choices)
        {
            DisplayChoices(choices);

            Console.Write("Please enter your choice > ");
            string value = Console.ReadLine();
            int choiceNo = Convert.ToInt32(value);

            return choiceNo;

        }
        /**
         * Method for getting each choice from the array 
         * and displaying them in a list
         */
        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($" {choiceNo}. {choice}\n");
            }
        }
    }
}
