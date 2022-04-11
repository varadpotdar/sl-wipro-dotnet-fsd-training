using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayDemo();

            //LinkedListDemo();

            //Linear Search ==================
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

            //sort numbers =====================
            //int[] target = { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };

            //Console.WriteLine("Unsorted array ------");
            //ShowArray(target);

            ////SelectionSort(target);
            ////BubbleSort(target);
            ////MergeSort(target, 0, 9);
            //QuickSort(target, 0, 9);

            //Console.WriteLine("Sorted array ------");
            //ShowArray(target);

            //binary search =====================
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

            //Student Project =====================
            string[] cities = StudentProject.ReadCities();
            Console.WriteLine("Unsorted cities ------");
            StudentProject.DisplayCities(cities);
            StudentProject.SortCities(cities);
            Console.WriteLine("Sorted cities ------");
            StudentProject.DisplayCities(cities);

            string input = "";
            do
            {
                Console.Write("Enter city to search and press enter: ");
                input = Console.ReadLine();
                Console.WriteLine($"City {input} was found at position {StudentProject.FindCity(cities, input)} in the array.");
            }
            while (input != "end");
        }

        #region Searching
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

        #endregion 

        #region Sorting

        static void MergeSort(int[] targetArray, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort(targetArray, p, q);
                MergeSort(targetArray, q + 1, r);
                Merge(targetArray, p, q, r);
            }
        }

        static void Merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            //1. Select a pivot point.
            int pivot = array[high];

            int lowIndex = (low - 1);

            //2. Reorder the collection.
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;

                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                //3. Recursively continue sorting the array
                QuickSort(array, low, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, high);
            }
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

        #endregion

        #region Array Demo

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

        #endregion 

        #region Singly Linked List Demo

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

        #endregion

    }
}
