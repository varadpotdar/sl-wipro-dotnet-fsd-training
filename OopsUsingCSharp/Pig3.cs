using System;
using System.Collections.Generic;
using System.Text;

namespace OopsUsingCSharp
{
    internal class Pig3 : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig (implementing IAnimal) says: wee wee");
        }
    }
}
