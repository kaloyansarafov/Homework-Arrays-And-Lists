using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace Arithmetics
{
    class MainMethods
    {
        //prints sum, smallest number, biggest number and average
        public static void Option1()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
            
            Console.Write("Sum: " + arr.Sum() + " ");
            Console.Write("Max: " + arr.Max() + " ");
            Console.Write("Min: " + arr.Min() + " ");
            Console.Write("Avg: " + arr.Average() + " ");
        }
        
        public static void Option2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m > n)
            {
                int temp;
                temp = n;
                n = m;
                m = temp;
            }
            int[] arr = SortingAlgorithms.RandomArrayCreator(100, m, n);
            for (int i = 0; i < 10; i++)
            {
                arr = SortingAlgorithms.RandomArrayCreator(100, m, n);
                Console.WriteLine(arr.Average());
            }
        }

        public static void Option3()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            while (n != -1)
            {
                list.Add(n);
                n = int.Parse(Console.ReadLine());
            }
            List<int> b = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                for (int g = list.Count - 2; g >= 0; g--)
                {
                    if (list[g] > list[g + 1])
                    {
                        SortingAlgorithms.ListExchange(list, g, g + 1);
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");
        }

        public static void Option4()
        {
            List<int> list = Console.ReadLine()
                .Split(", ")
                .Select(x => int.Parse(x))
                .ToList();
            list.Remove(list.Min());
            Console.WriteLine(list.Min());
            list.Remove(list.Max());
            Console.WriteLine(list.Max());
        }

        public static void Option5()
        {
            List<double> a = Console.ReadLine()
                .Split(", ")
                .Select(x => double.Parse(x))
                .ToList();
            List<double> b = new List<double>();
            double current;
            for (int i = 0; i < a.Count; i++)
            {
                current = a[i];
                while (true)
                {
                    if (current == 2.00)
                    {
                        if (b.Contains(a[i]))
                            break;
                        else
                        {
                            b.Add(a[i]);
                            break;
                        }
                    }
                    else if (current < 2)
                        break;

                    current = current / 2.0;
                }
            }
            Console.WriteLine(string.Join(" ", b));
        }

        public static void Option6()
        {
            DateTime StartTime = DateTime.Now;

            int[] arr1 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            int[] arr2 = arr1;
            int[] arr3 = arr1;
            int[] arr4 = arr1;
            SortingAlgorithms.IntArrayBubbleSort(arr1);

            double spanbubble = (DateTime.Now - StartTime).TotalSeconds;
            Console.WriteLine("Bubble Sort Time: " + spanbubble + " seconds.");


            DateTime InsertionStartTime = DateTime.Now;

            SortingAlgorithms.IntArrayInsertionSort(arr2);

            double spaninsertion = (DateTime.Now - InsertionStartTime).TotalSeconds;
            Console.WriteLine("Insertion Sort Time: " + spaninsertion + " seconds.");


            DateTime SelectionStartTime = DateTime.Now;

            SortingAlgorithms.IntArraySelectionSort(arr3);

            double spanselection = (DateTime.Now - SelectionStartTime).TotalSeconds;
            Console.WriteLine("Selection Sort Time: " + spanselection + " seconds.");


            DateTime SortStartTime = DateTime.Now;

            Array.Sort(arr4);

            double spansort = (DateTime.Now - SortStartTime).TotalSeconds;
            Console.WriteLine("Array Sort Time: " + spansort + " seconds.");


            double span = (DateTime.Now - StartTime).TotalSeconds;
            Console.WriteLine("Total Time: " + span + " seconds.");
        }
        public static bool Option7()
        {
            string egn = Console.ReadLine();
            char[] egnchars = egn.ToCharArray();
            int[] egnarray = Array.ConvertAll(egnchars, c => (int)Char.GetNumericValue(c));
            if (egn.Length != 10)
            {
                Console.WriteLine("Inserted EGN is not of the correct length.");
                return false;
            }
            if (EGNMethods.IsAllDigits(egn) == false)
            {
                return false;
            }
            if (EGNMethods.CorrectDate(egn) == false)
            {
                return false;
            }
            if (EGNMethods.IsEGN(egnarray, egn) == false)
            {
                return false;
            }
            Console.WriteLine("The entered EGN is correct.");
            return true;
        }
    }
}
