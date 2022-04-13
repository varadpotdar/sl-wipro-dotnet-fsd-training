using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Singleton fromTeachear = Singleton.GetInstance;
            fromTeachear.PrintDetails("From Teacher");
            
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            
            Console.ReadLine();
        }
    }
}
