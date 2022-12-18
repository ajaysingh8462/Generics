using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class program
    {
        public static void Main(string[] args)
        {

            int maxint = FindMax.FindIntMax(3, 2, 1);
            Console.WriteLine("The maximum number of in  is :" + maxint);

            float maxfloat = FindMax.FindFloatMax(3.1f, 2.1f, 1.1f);
            Console.WriteLine("The maximum number of float is :" + maxfloat);


        }

    }
}