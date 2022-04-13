using System;

namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        public Singleton() //private constructor ensures that nobody can create an instance from outside
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public static Singleton GetInstance //get reference to the instance of class, if its not create it gets created on first access because of private constructor
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}