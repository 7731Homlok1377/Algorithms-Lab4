using System;
using System.Collections.Generic;

namespace Lab4_Alg
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "gfhfh aaAAAd jfjkdjv, hHh, AAAaa hhhk aa aa bb bb bbc";
            //Checker.GetWordsList(str);
            //int[] arr = new int[100];

            //Random rd = new Random();
            //for (int i = 0; i < arr.Length; ++i)
            //{
            //    arr[i] = rd.Next(0, 100);
            //}
            string[] str = { "ba", "ac", "DA", "cd", "ba" };
            System.Console.WriteLine("The array before sorting:");
            foreach (string x in str)
            {
                System.Console.Write(x + " ");
            }
            
            //RadixSort.Sorting(str, 10, 2);
            RadixSort.sorting(str, 10, 2);
            System.Console.WriteLine("\n\nThe array after sorting:");
            //foreach (double x in arr)
            //{
            //    System.Console.Write(x + " ");
            //}
            foreach (string x in str)
            {
                System.Console.Write(x + " ");
            }
            //List<string> t = new List<string>();
            //t.Add("a");
            //t.Add("b");
            //t.Add("c");
            //t.Add("a");
            //Checker.Counords(t);
            System.Console.WriteLine("\n\nPress the <Enter> key");
            System.Console.ReadLine();
        }
    }
}
