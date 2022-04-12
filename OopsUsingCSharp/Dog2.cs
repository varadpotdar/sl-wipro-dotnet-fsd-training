using System;
using System.Collections.Generic;
using System.Text;

namespace OopsUsingCSharp
{
    internal class Dog2 : AbstractAnimal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog (implementing AbstractAnimal) says: bow wow");
        }
    }
}
