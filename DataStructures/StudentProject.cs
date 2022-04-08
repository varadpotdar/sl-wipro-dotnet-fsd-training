using System;

namespace DataStructures
{
    /// <summary>
    /// Student Project:
    /// Step 1: Create a text file with following city values - one value per line:
    ///    Mumbai, Delhi, Bangalore , Hyderabad, Ahmedabad, Chennai, Kolkata, Surat, Pune, Jaipur, Lucknow, Kanpur, Nagpur, Indore, Thane
    /// Step 2: Read the text file into an array of strings
    /// Step 3: Display the contents of the array
    /// Step 4: Sort the array using Selection or Bubble sort algorithm
    /// Step 5: Display the sorted array
    /// Step 6. Enable searching through the array using Binary search
    /// </summary>
    public class StudentProject
    {
        public static string[] ReadCities()
        {
            string citiesFileName = "C:\\Training\\cities.txt";
            return System.IO.File.ReadAllLines(citiesFileName);
        }

        public static void DisplayCities(string[] cities)
        {
            foreach (string city in cities)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();
        }

        public static void SortCities(string[] cities)
        {
            for (int i = 0; i < cities.Length - 1; i++)
            {
                for (int j = i + 1; j < cities.Length; j++)
                {
                    if (string.Compare(cities[i], cities[j]) > 0)
                        Swap(cities, i, j);
                }
            }
        }
        public static int FindCity(string[] cities, string city)
        {
            SortCities(cities);

            int minNum = 0;
            int maxNum = cities.Length - 1;

            int foundElem = -1;

            while (minNum <= maxNum && foundElem == -1)
            {
                int mid = (minNum + maxNum) / 2;

                if (city.Equals(cities[mid], StringComparison.OrdinalIgnoreCase))
                {
                    foundElem = ++mid;
                    break;
                }
                else if (city.CompareTo(cities[mid]) < 0)
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }

            return foundElem;
        }
        static void Swap(string[] cities, int i, int j)
        {
            string temp = cities[i];
            cities[i] = cities[j];
            cities[j] = temp;
        }
    }
}
