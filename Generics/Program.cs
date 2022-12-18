using Generics;
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
            Console.WriteLine("Test case 1 find max of int (50,40,30,20,10)");
            int maxint = FindMax<int>.FindMaxNUM(50, 40, 30, 20, 10);
            Console.WriteLine("The maximum number of int is :" + maxint);

            Console.WriteLine("Test case 1 find max of float (50.7,50.1,50.2,50.8,50.0)");
            float Maxfloat = FindMax<float>.FindMaxNUM(50.7f, 50.1f, 50.2f,50.8f,50.0f);
            Console.WriteLine("The maximum number of float is :" + Maxfloat);

            Console.WriteLine("Test case 1 find max value of string (Raj,Rahul,Ajay,Teena,Priya)");
            string Maxstring = FindMax<string>.FindMaxNUM("Raj", "Rahul", "Ajay","Teena","Priya");
            Console.WriteLine("The maximum value of string is :" + Maxstring);

        }

    }
}