﻿using Generics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test case 1 find max of int (3,2,1)");
            int maxint = FindMax<int>.FindMaxNUM(3, 2, 1);
            Console.WriteLine("The maximum number of in  is :" + maxint);
            Console.WriteLine("Test case 2 find max of int (1,3,1)");
            int Maxint = FindMax<int>.FindMaxNUM(1, 3, 2);
            Console.WriteLine("The maximum number of in  is :" + Maxint);
            Console.WriteLine("Test case 3 find max of int (1,2,3)");
            int maxInt = FindMax<int>.FindMaxNUM(1, 2, 3);
            Console.WriteLine("The maximum number of in  is :" + maxInt);

            Console.WriteLine("Test case 1 find max of float (3.1,2.1,1.1)");
            float Maxfloat = FindMax<float>.FindMaxNUM(3.1f, 2.1f, 1.1f);
            Console.WriteLine("The maximum number of float is :" + Maxfloat);
            Console.WriteLine("Test case 2 find max of float (1.1,3.1,2.1)");
            float maxfloat = FindMax<float>.FindMaxNUM(1.1f, 3.1f, 2.1f);
            Console.WriteLine("The maximum number of float is :" + maxfloat);
            Console.WriteLine("Test case 3 find max of float (1.1,2.1,3.1)");
            float maxFloat = FindMax<float>.FindMaxNUM(1.1f, 2.1f, 3.1f);
            Console.WriteLine("The maximum number of float is :" + maxFloat);

            Console.WriteLine("Test case 1 find max value of string (Peach,Banana, Apple)");
            string Maxstring = FindMax<string>.FindMaxNUM("Peach", "Banana", "Apple");
            Console.WriteLine("The maximum value of string is :" + Maxstring);
            Console.WriteLine("Test case 2 find max value of string (Banana,Peach, Apple)");
            string MaxString = FindMax<string>.FindMaxNUM("Banana", "Peach", "Apple");
            Console.WriteLine("The maximum number of float is :" + MaxString);
            Console.WriteLine("Test case 2 find max value of string (Banana,Apple, Peach)");
            string Max_String = FindMax<string>.FindMaxNUM("Banana", "Apple", "Peach");
            Console.WriteLine("The maximum number of float is :" + Max_String);




        }

    }
}