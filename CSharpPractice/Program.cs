using System;

namespace CSharpPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convert minutes to seconds ------------------
            //ConvertToSeconds(5);

            //Invoke Area of a Triangle ------------------
            //Console.WriteLine("To find area of a triangle:");

            //Console.Write("Enter side:");
            //float side = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Enter height:");
            //float height = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine($"Area of a triangle with side {side} units and height {height} units equals {AreaOfTriangle(side, height)} square units.");

            //Invoke IsSumLessThanHundred ------------------
            //IsSumLessThanHundred(10, 90);
            //IsSumLessThanHundred(99, 0);
            //IsSumLessThanHundred(100, 1);

            //Console.WriteLine("Check if the sum of two numbers is less than 100 or not:");

            //Console.Write("Enter number1: ");
            //int n1 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Enter number2: ");
            //int n2 = Convert.ToInt16(Console.ReadLine());

            //IsSumLessThanHundred(n1, n2);

            //Name shuffle ----------------
            //NameShuffle("Rajeev Sharma");
            //NameShuffle("Rosie O'Donnell");

            //demo Factorial
            //int number = 0;

            //do
            //{
            //    Console.Write("Please enter the number to calculate factorial: ");
            //    number = Convert.ToInt16(Console.ReadLine());
            //    if (number <= 0)
            //    {
            //        Console.WriteLine("To calculate factorial please enter a positive integer.");
            //    }
            //}
            //while (number <= 0);

            //Console.WriteLine($"{number}! = {Factorial(number)}");

            Collatz(10);
            Collatz(100);
        }

        /// <summary>
        /// Repeatedly evaluate following operations, until reaching 1 and display the number of steps it took.
        /// If n is even -> n / 2, If n is odd -> n * 3 + 1
        /// </summary>
        /// <param name="number"></param>
        static void Collatz(uint number)
        {
            int steps = 0;
            uint n = number;
            while (n > 1)
            {
                string evenOrOddString;
                string stepDescriptionString;

                if (n % 2 == 0) //check if the number is even
                {
                    evenOrOddString = "even";
                    stepDescriptionString = $"{n} / 2 = ";
                }
                else
                {
                    evenOrOddString = "odd";
                    stepDescriptionString = $"{n} * 3 + 1 = ";
                }
                
                uint previousNo = n; //save the number to display it later
                n = (n % 2 == 0) ? (n / 2) : (n * 3 + 1); //collatz step based on the requirement
                steps++;

                //10 is even - 10 / 2 = 5
                //5 is odd - 5 * 3 + 1 = 16
                Console.WriteLine($"{steps}. {previousNo} is {evenOrOddString} - {stepDescriptionString}{n} ");
            }
            
            Console.WriteLine($"Totals steps for Collatz({number}) is {steps}.");
        }

        /// <summary>
        /// Calculates the factorial of the passed hnumber
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static long Factorial(int number)
        {
            //non recursive way
            long factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;

            //recursive way
            //if (number > 0) //terminating condition for recursion
            //    return number * Factorial(number - 1);

            //return 1;
        }

        static void ConvertToSeconds(int minutes)
        {
            Console.WriteLine($"{minutes} minutes equals {minutes * 60} seconds");
        }

        static double AreaOfTriangle(float side, float height)
        {
            return (double)(side * height / 2);
        }

        /// <summary>
        /// Checks if the sum of two numbers is less than 100 or not
        /// </summary>
        /// <param name="number1">Number 1</param>
        /// <param name="number2">Number 2</param>
        static void IsSumLessThanHundred(int number1, int number2)
        {
            //string.Format("{0} + {1} is LESS THAN 100", number1, number2);

            if (number1 + number2 < 100)
                Console.WriteLine($"{number1} + {number2} is LESS THAN 100");
            else
                Console.WriteLine($"{number1} + {number2} is NOT LESS THAN 100");
        }

        /// <summary>
        /// Accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
        /// Assumption: There will be exactly one space between the first and last name.
        /// </summary>
        /// <param name="fullName"></param>
        static void NameShuffle(string fullName)
        {
            //way 1
            //string[] nameArray = fullName.Split(' ');
            //Console.WriteLine($"\"{fullName}\" --> {nameArray[1]} {nameArray[0]}");

            //way 2
            int spacePosition = fullName.IndexOf(' ');

            Console.WriteLine($"\"{fullName}\" --> {fullName.Substring(spacePosition+1)} {fullName.Substring(0, spacePosition)}");
        }

        
    }
}
