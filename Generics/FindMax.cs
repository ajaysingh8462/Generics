using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMax<T> where T : IComparable
    {
        public T num1, num2, num3; 
        public FindMax(T num1,T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        
        public static T FindMaxNUM(T num1, T num2, T num3) 
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
            return default;
        }
    }
}
