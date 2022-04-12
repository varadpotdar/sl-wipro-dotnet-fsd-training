using System;
using System.Collections.Generic;
using System.Text;

namespace OopsUsingCSharp
{
    internal class Dog3 : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The dog (implementing IAnimal) says: bow wow");
        }
    }
}
