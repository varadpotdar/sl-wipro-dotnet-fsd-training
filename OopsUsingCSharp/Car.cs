using System;

namespace OopsUsingCSharp
{
    internal class Car
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Car()
        {
            Console.WriteLine("Car constuctor invoked....");
            model = "Mustang"; // Set the initial value for model
        }
        
        public void Drive() //instance method, belong to the object
        {
            Console.WriteLine("Drive method called");
        }

        public static Car BuyCar() //static belong to the Class
        {
            return new Car();
        }
    }
}
