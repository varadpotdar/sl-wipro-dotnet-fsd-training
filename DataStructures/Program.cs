using System;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayDemo();

            //LinkedListDemo();

            //Linear Search
            //int search = 0;
            //Console.WriteLine("Marks list: { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 }");
            //do
            //{
            //    Console.Write("Enter marks to search and press enter: ");
            //    string input = Console.ReadLine();
            //    search = Int32.Parse(input);
            //    Console.WriteLine($"Marks {search} was found at position {FindThroughLinearSearch(search)} in the array.");
            //}
            //while (search > 0);

            //sort numbers
            int[] target = { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };

            Console.WriteLine("Unsorted array ------");
            ShowArray(target);

            BubbleSort(target);

            Console.WriteLine("Sorted array ------");
            ShowArray(target);

            //binary search
            //int search = 0;
            //Console.WriteLine("Marks list: 56 67 67 76 79 82 83 88 90 98");
            //do
            //{
            //    Console.Write("Enter marks to search and press enter: ");
            //    string input = Console.ReadLine();
            //    search = Int32.Parse(input);
            //    Console.WriteLine($"Marks {search} was found at position {FindThroughBinarySearch(search)} in the array.");
            //}
            //while (search > 0);
        }

        static int FindThroughBinarySearch(int findNumber)
        {
            int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };

            SelectionSort(marks);

            int minNum = 0;
            int maxNum = marks.Length - 1;

            int foundElem = -1;

            while (minNum <= maxNum && foundElem == -1)
            {
                int mid = (minNum + maxNum) / 2;
                if (findNumber == marks[mid])
                {
                    foundElem = mid;
                    break;
                }
                else if (findNumber < marks[mid])
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

        static void SelectionSort(int[] targetArray)
        {
            for (int i = 0; i < targetArray.Length - 1; i++)
            {
                for (int j = i + 1; j < targetArray.Length; j++)
                {
                    if (targetArray[i] > targetArray[j])
                    {
                        Swap(targetArray, i, j);
                    }
                }
            }

        }

        static void BubbleSort(int[] targetArray)
        {
            for (int i = 1; i < targetArray.Length; i++)
            {
                for (int j = 0; j < targetArray.Length - i; j++)
                {
                    if (targetArray[j] > targetArray[j + 1])
                    {
                        Swap(targetArray, j, j + 1);
                    }
                }
                Console.Write($"Pass {i}: ");
                ShowArray(targetArray);
            }
        }

        static void Swap(int[] targetArray, int i, int j)
        {
            int temp = targetArray[i];
            targetArray[i] = targetArray[j];
            targetArray[j] = temp;
        }
        

        static void ShowArray(int[] targetArray)
        {
            //Way 1
            //string arrayString = "";
            //for (int i = 0; i < targetArray.Length; i++)
            //{
            //    arrayString += targetArray[i].ToString() + ",";
            //}

            //Console.WriteLine($"Array: {arrayString.Substring(0, arrayString.Length - 1)}");

            //way 2
            for (int i = 0; i < targetArray.Length; i++)
                Console.Write(targetArray[i] + " ");
            Console.WriteLine();
        }

        static void ArrayDemo()
        {
            string[] students3A, students3B;

            students3A = new string[10] { "Rahul", "Sheela", "Mukesh", "Afzal", "Ramesh", "Geeta", "Jason", "Robert", "Gopal", "Meera" };
            students3B = new string[10] { "Pinky", "Rakesh", "Rafi", "Mumtaz", "Derek", "Sukhwinder", "Gopi", "Tulsi", "Chandrika", "Ann" };

            string[] subjects = new string[6];
            subjects[0] = "Physics";
            subjects[1] = "Chemistry";
            subjects[2] = "Biology";
            subjects[3] = "Calculus";
            subjects[4] = "Computer Science";
            subjects[5] = "Algebra";

            int[] marks = new int[6];
            marks[0] = 67;
            marks[1] = 90;
            marks[2] = 80;
            marks[3] = 55;
            marks[4] = 71;
            marks[5] = 92;

            Console.WriteLine("Students of Class 3A:");
            foreach (string s in students3A)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Students of Class 3B:");
            foreach (string s in students3B)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Marks of Kamal:");
            int total = 0;
            for (int i = 0; i < 6; i++)
            {
                total += marks[i];
                Console.WriteLine(subjects[i] + " = " + marks[i]);
            }
            Console.WriteLine("TOTAL = " + total + "/600 = " + (total * 100 / 600) + " percent");
        }

 
        static void LinkedListDemo()
        {
            //declare LL and node objects
            SingleLinkedList list = new SingleLinkedList();
            
            Node n = new Node();
            
            //prepare the LL by inserting elements
            n.Data = "root";
            list.Add(n);
            for (int i = 0; i < 10; i++)
            {
                Node node = new Node();
                node.Data = Convert.ToString(i);
                list.Add(node);
            }

            Console.WriteLine("length of singly linked list=" + list.GetLengthOfList());

            //display the elements inthe LL
            n = list.GetRoot();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.GetNext();
            }
        }

        /// <summary>
        /// Search the passed number in an array of number using Linear Search
        /// </summary>
        /// <param name="findNumber"></param>
        /// <returns>Returns position in the array or -1</returns>
        static int FindThroughLinearSearch(int findNumber)
        {
            int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
            
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == findNumber)
                    return i;
            }
            return -1;
        }
        
    }
}
