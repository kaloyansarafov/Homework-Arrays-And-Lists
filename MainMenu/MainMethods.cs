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
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
                a[i] = int.Parse(Console.ReadLine());
            
            Console.Write(a.Sum() + " ");
            Console.Write(a.Max() + " ");
            Console.Write(a.Min() + " ");
            Console.Write(a.Average() + " ");
        }
        
        public static void Option2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m > n)
            {
                int b;
                b = n;
                n = m;
                m = b;
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
            List<int> a = new List<int>();
            while (n != -1)
            {
                a.Add(n);
                n = int.Parse(Console.ReadLine());
            }
            List<int> b = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                for (int g = a.Count - 2; g >= 0; g--)
                {
                    if (a[g] > a[g + 1])
                    {
                        int u;
                        u = a[g + 1];
                        a[g + 1] = a[g];
                        a[g] = u;
                    }
                }
            }
            for (int i = 0; i < a.Count; i++)
                Console.Write(a[i] + " ");
        }

        public static void Option4()
        {
            List<int> a = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToList();
            a.Remove(a.Min());
            Console.WriteLine(a.Min());
            a.Remove(a.Max());
            Console.WriteLine(a.Max());
        }

        public static void Option5()
        {
            List<double> a = Console.ReadLine().Split(", ").Select(x => double.Parse(x)).ToList();
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
            int[] arr2 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            int[] arr3 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            int[] arr4 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            SortingAlgorithms.IntArrayBubbleSort(arr1);
            SortingAlgorithms.IntArrayBubbleSort(arr2);
            SortingAlgorithms.IntArrayBubbleSort(arr3);
            SortingAlgorithms.IntArrayBubbleSort(arr4);

            double spanbubble = (DateTime.Now - StartTime).TotalSeconds;
            Console.WriteLine("Bubble Sort Time: " + spanbubble + " seconds.");

            DateTime InsertionStartTime = DateTime.Now;
            arr1 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            arr2 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            arr3 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            arr4 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            SortingAlgorithms.IntArrayInsertionSort(arr1);
            SortingAlgorithms.IntArrayInsertionSort(arr2);
            SortingAlgorithms.IntArrayInsertionSort(arr3);
            SortingAlgorithms.IntArrayInsertionSort(arr4);

            double spaninsertion = (DateTime.Now - InsertionStartTime).TotalSeconds;
            Console.WriteLine("Insertion Sort Time: " + spaninsertion + " seconds.");

            DateTime SelectionStartTime = DateTime.Now;
            arr1 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            arr2 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            arr3 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            arr4 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            SortingAlgorithms.IntArraySelectionSort(arr1);
            SortingAlgorithms.IntArraySelectionSort(arr2);
            SortingAlgorithms.IntArraySelectionSort(arr3);
            SortingAlgorithms.IntArraySelectionSort(arr4);
            double spanselection = (DateTime.Now - SelectionStartTime).TotalSeconds;
            Console.WriteLine("Selection Sort Time: " + spanselection + " seconds.");

            DateTime SortStartTime = DateTime.Now;
            arr1 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            arr2 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            arr3 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            arr4 = SortingAlgorithms.RandomArrayCreator(100000, -100, 100);
            Array.Sort(arr1);
            Array.Sort(arr2);
            Array.Sort(arr3);
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
