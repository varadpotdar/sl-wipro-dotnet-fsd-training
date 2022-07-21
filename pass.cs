using System;

namespace ParameterExample
{
    class Program
    {

        public void SetValue(out int n)
        {
            n = 20;
            n += 1;
        }
        public void Display(in int k)
        {
            Console.WriteLine("{0} is protected", k);
        }
        public void SetGoodValue(ref int m)
        {
            if (m % 2 != 0)
                m += 1;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int j;
            p.SetValue(out j);
            Console.WriteLine(j);
            p.Display(j);
            p.SetGoodValue(ref j);
            p.Display(j);
        }
    }
}
