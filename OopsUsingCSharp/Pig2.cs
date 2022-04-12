using System;
using System.Collections.Generic;
using System.Text;

namespace OopsUsingCSharp
{
    internal class Pig2 : AbstractAnimal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig (implementing AbstractAnimal) says: wee wee");
        }
    }
}
