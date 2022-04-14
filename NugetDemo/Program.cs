using Newtonsoft.Json.Linq;
using System;
using WiproExtensions;

namespace NugetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JArray array = new JArray();
            JValue text = new JValue("Manual text");
            JValue date = new JValue(new DateTime(2000, 5, 23));

            array.Add(text);
            array.Add(date);

            string json = array.ToString();
            Console.WriteLine(json);

            Console.WriteLine(StringHelper.GetWordCount("How many words are there in this line?"));
        }
    }
}
