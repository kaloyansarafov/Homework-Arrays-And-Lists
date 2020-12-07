using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Arithmetics
{
    class MainMenu
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("To pick an option enter its number");
                Console.WriteLine("1. Option 1");
                Console.WriteLine("2. Option 2");
                Console.WriteLine("3. Option 3");
                Console.WriteLine("4. Option 4");
                Console.WriteLine("5. Option 5");
                Console.WriteLine("6. Option 6");
                Console.WriteLine("7. Option 7");
                Console.WriteLine("To exit type exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        MainMethods.Option1();
                        break;
                    case "2":
                        MainMethods.Option2();
                        break;
                    case "3":
                        MainMethods.Option3();
                        break;
                    case "4":
                        MainMethods.Option4();
                        break;
                    case "5":
                        MainMethods.Option5();
                        break;
                    case "6":
                        MainMethods.Option6();
                        break;
                    case "7":
                        MainMethods.Option7();
                        break;
                    case "exit":
                        return;
                    default:
                        break;
                }
            }

        }
    }
}
