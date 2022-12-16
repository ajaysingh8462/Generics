using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricDemo
{
    class program
    {
        public static void Main(string[] args)
        {

            int maxint = FindMax.FindIntMax(3, 2, 1);
            Console.WriteLine("The maximum number of in  is :" + maxint);
        }
    }
}