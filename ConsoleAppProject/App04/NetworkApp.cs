using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        /**
         * Displays a menu of choices, uses boolean to determine when
         * a user decides to quit the application.
         * Uses console helper choice selection to recreate choice descicion
         */
        public void DisplayMenu() 
        {
            ConsoleHelper.OutputHeading("Jamie Chopra News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Print All Posts", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: PrintAll(); break;
                    case 4: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void PrintAll()
        {
            throw new NotImplementedException();
        }

        private void PostImage()
        {
            throw new NotImplementedException();
        }

        private void PostMessage()
        {
            throw new NotImplementedException();
        }
    }
}
