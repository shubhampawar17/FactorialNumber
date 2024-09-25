using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorialNumber.model;


namespace FactorialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter a Number:");
                

                while (true)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("Please enter a positive number:");
                    }
                        break; 
                }

                long factorial = Factorial.CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}");

                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Check another number");
                Console.WriteLine("2. Exit");
                //int choice = Convert.ToInt32(Console.ReadLine());

                //exit = (choice == 2) ? true : false;

                int choice;

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Program exited.");
        }

        
    }
    
}
