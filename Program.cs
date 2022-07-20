using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1_ReadData
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = @"C:\Users\Admin\source\repos\Phase1_ReadData\test.txt";

           // string[] lines = File.ReadAllLines(filepath);
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
            lines.Add("Varad, Div-A, 12, varad@gmail.com");
            File.WriteAllLines(filepath,lines);
            Console.ReadLine();
        }
    }
}
