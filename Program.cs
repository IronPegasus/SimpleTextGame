using System;

namespace SimpleTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while(choice != 0)
            {
                PrintSelectionMenu();
                choice = GetUserInput();

                switch(choice)
                {
                    case -1 : Console.WriteLine("You must enter a number value!");
                              break;
                    case 1 : break;
                    case 0 : break;
                    default :  Console.WriteLine("You must enter an option from the menu!");
                               break;
                }

                Console.WriteLine();
            }
        }

        static void PrintSelectionMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("   1. Reprint Menu");
            Console.WriteLine("   0. Quit");
            Console.Write(">>> ");
        }

        static int GetUserInput()
        {
            int choice;
            string value = Console.ReadLine();
            
            if(int.TryParse(value, out choice))
            {
                return choice;
            }
            else
            {
                return -1;
            }
        }
    }
}
