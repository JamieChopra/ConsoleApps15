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

        public static int SelectChoice(string[] choices) 
        {
            int choiceNo = 0;

            foreach(string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($" {choiceNo}. {choice}\n");
            }
            return 0;
        }
    }
}
