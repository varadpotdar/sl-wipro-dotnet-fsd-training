using System;
using System.Collections.Generic;
using System.Text;

namespace OopsUsingCSharp
{
    internal class Pig : Animal
    {
        public override void animalSound()
        {
            base.animalSound();
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
