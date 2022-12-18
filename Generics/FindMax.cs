using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMax<T> where T : IComparable
    {
        public T num1, num2, num3 ,num4 ,num5; 
        public FindMax(T num1,T num2, T num3, T num4, T num5)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
            this.num5 = num5;
            
        }
        
        public static T FindMaxNUM(T num1, T num2, T num3, T num4, T num5) 
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 && num1.CompareTo(num4) > 0 && num1.CompareTo(num5) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 && num2.CompareTo(num4) > 0 && num2.CompareTo(num5) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 && num3.CompareTo(num4) > 0 && num3.CompareTo(num5) > 0)
            {
                return num3;
            }
            if (num4.CompareTo(num1) > 0 && num4.CompareTo(num2) > 0 && num4.CompareTo(num3) > 0 && num4.CompareTo(num5) > 0)
            {
                return num4;
            }
            if (num5.CompareTo(num1) > 0 && num5.CompareTo(num2) > 0 && num5.CompareTo(num3) > 0 && num5.CompareTo(num4) > 0)
            {
                return num5;
            }
            return default;
        }
    }
}
