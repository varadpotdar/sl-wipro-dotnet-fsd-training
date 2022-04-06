using System;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayDemo();
            
            LinkedListDemo();
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

    }
}
