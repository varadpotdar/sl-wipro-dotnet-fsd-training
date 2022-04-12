using System;
using System.Collections.Generic;
using System.Text;

namespace OopsUsingCSharp
{
    internal class Dog : Animal
    {
        
        public override void animalSound()
        {
            base.animalSound();

            Console.WriteLine("The dog says: bow wow");
        }
    }
}
