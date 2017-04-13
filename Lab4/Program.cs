using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Welcome Message
            Console.WriteLine("Welcome to the Factorial Calculator!");
            Console.WriteLine();


            // Declare Variables
            long factorial = 1;
            string Continue;
            int number;
            int min = 1;
            int max = 10;  


            // Loop if User Chooses to Continue
            while (true)
            {
                number = GetRange(min, max);
                // Process - For Loop Decrements to Get Integers Before Number Entered to Find Factorial
                factorial = number;

                for (long i = number - 1; i >= 1; i--)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("The Factorial of " + number + " is:  " + factorial);
                Console.WriteLine();


                //Continue Loop
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Continue?  (y/n)");
                    Continue = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    if (Continue == "Y")
                        break;

                    if (Continue == "N")
                        return;

                    else
                        Console.WriteLine("Please Enter Y or N");
                }
            }
        }


        // Method to Get Input and Validate That Number is Between 1 and 10.
        public static int GetRange(int min, int max)
        {
            Console.WriteLine("Please Enter an Integer from 1 to 10: ");
            int number = GetValidInt();
            // Input
          

            while (number < 1 || number > 10)
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter a Number That is in Between 1 and 10!");
                number = GetValidInt();
            }
            return number;

        }



        // Method to Validate Input
        public static int GetValidInt()
        {

            int number;
            // Validate Input
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();
                Console.WriteLine("That is Not an Integer!  Please Enter an Integer:  ");
          
            }
            return number;
        }
    }

}
