using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dessert_Choice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            code();
        }

        static void code()
        {
            Console.WriteLine("Would you like dessert? ");

            string choice = Console.ReadLine();

            if (choice == "yes")
            {
                Console.WriteLine("Awesome, I'll grab you a dessert menu.");
                Thread.Sleep(1000);
                Console.WriteLine("Here is your list.");
                Thread.Sleep(1000);
                Console.WriteLine("1 Rose water rice pudding");
                Thread.Sleep(1000);
                Console.WriteLine("2 Tres Leches Cake");
                Thread.Sleep(1000);
                Console.WriteLine("3 Bread pudding");
                Thread.Sleep(1000);
                Console.WriteLine("and 4 Beignets");

                string choice2 = Console.ReadLine();

                Console.WriteLine($"Excellent choice, I will grab {choice2} right away.");
            }

            else if (choice == "no") 
            {
                Console.WriteLine("No worries, I'll grab you the check");
            }

            else 
            {
                Console.WriteLine("GET OUT");
            }

            Console.ReadLine();
        }
    }
}
