using System;
using System.Collections.Generic;
using System.Text;

namespace OopsUsingCSharp
{
    internal abstract class AbstractAnimal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}
