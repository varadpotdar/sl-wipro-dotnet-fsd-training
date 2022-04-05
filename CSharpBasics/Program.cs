using System;
using System.IO;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Main, Program is starting ========");

            PrimitiveDemo();

            DayOfWeek(5);

            LoopDemo();

            DateDemo();

            TextFileDemo();

            Console.WriteLine("Program has ended, this was the last line ========");
        }

        static void PrimitiveDemo()
        {
            Console.WriteLine("Demonstrating Primitives...");

            int x = 100;
            string s = "My Test string";
            bool b = false;
            
            const float HUNDRED_PERCENT = 100.00f;
            float f = 99.00f;

            if (b)
            {
                Console.WriteLine("b is true");
            }
            else
            {
                Console.WriteLine("b is false");
            }

            if (x > 100)
                Console.WriteLine("x more than 100");
            else
                Console.WriteLine("x less than or equal to 100");

            if (s == "test")
                Console.WriteLine("s equals 'test'");
            else
                Console.WriteLine("s doesn't equal 'test'");

            if (f == HUNDRED_PERCENT)
                Console.WriteLine("f is hundred percent");
            else
                Console.WriteLine("f is less than or equal to 100%");
        }

        static void DayOfWeek(int day) //Switch demo
        {
            switch (day)
            {
                case 1: 
                    Console.WriteLine("Day Sunday");
                    break;
                case 2: 
                    Console.WriteLine("Day Monday");
                    break;
                case 3:
                    Console.WriteLine("Day Tue");
                    break;
                case 4:
                    Console.WriteLine("Day Wed");
                    break;
                case 5:
                    Console.WriteLine("Day Thu");
                    break;
                case 6:
                    Console.WriteLine("Day Fri");
                    break;
                case 7:
                    Console.WriteLine("Day Sat");
                    break;
                default: 
                    Console.WriteLine("Invalid Day");
                    break;
            }
        }

        static void LoopDemo()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Value of i = " + i.ToString());
            //    DayOfWeek(i);
            //}

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("Value of j = " + j.ToString());
                DayOfWeek(j);
                j++;
            }
        }

        static void DateDemo()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Current date and time :" + dt.ToString());
            Console.WriteLine("Formatted short date:" + dt.ToShortDateString());
            Console.WriteLine("Formatted long  date:" + dt.ToLongDateString());
            Console.WriteLine("Formatted custom date strings:");
            Console.WriteLine(dt.ToString("d"));
            Console.WriteLine(dt.ToString("D"));
            Console.WriteLine(dt.ToString("F"));
            Console.WriteLine(dt.ToString("y"));

            Console.WriteLine("Adding 5 days to today:" + dt.AddDays(5).ToShortDateString());

            DateTime date1 = new DateTime(2019, 1, 2, 4, 0, 15);
            DateTime date2 = new DateTime(2019, 1, 2, 14, 0, 15);
            TimeSpan value = date2.Subtract(date1);
            Console.WriteLine("TimeSpan between two dates is {0} hours", value);
        }

        static void TextFileDemo()
        {
            //Create full file name and path
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";

            //check if the file exists or not. if not create it
            if (File.Exists(filename))
                Console.WriteLine(filename + " exists");
            else
            {
                Console.WriteLine(filename + " does not exist");

                using (StreamWriter wrt = File.CreateText(filename))
                {
                    wrt.WriteLine("This is line one");
                    wrt.WriteLine("This is line two");
                    wrt.WriteLine("This is line three");
                    wrt.WriteLine("This is line four");
                }
                
                Console.WriteLine(filename + " created");
            }

            //read the file line by line and display each line
            Console.WriteLine("Display the file line by line ------------");
            string[] lines = File.ReadAllLines(filename);
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Display the file in one go ------------");
            string text = File.ReadAllText(filename);
            Console.WriteLine(text);

            //File.Delete(filename);
            //Console.WriteLine(filename + " was deleted");
        }
    }
}
