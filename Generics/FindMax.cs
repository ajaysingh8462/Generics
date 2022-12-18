using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMax
    {
        public static int FindIntMax(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return 0;
        }
        public static float FindFloatMax(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return 3;
        }
        public static String FindStringMax(string A, string B, string C)
        {
            if (A.CompareTo(B) > 0 && A.CompareTo(C) > 0)
            {
                return A;
            }
            if (B.CompareTo(A) > 0 && B.CompareTo(C) > 0)
            {
                return B;
            }
            if (C.CompareTo(A) > 0 && C.CompareTo(B) > 0)
            {
                return C;
            } 
            return null;
        }
    }
}
