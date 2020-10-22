using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnMethods
{
    class Demo1
    {
        public static double Sqaure(double d) //static method
        {
            return d * d;
        }
        public bool isEven(int no)
        {
            if (no % 2 == 0)
                return true;
            else
                return false;
        }
        public static int[] getEvens(int []a)
        {
            //return even values from an array
            int[] res = new int[a.Length];
            int index = 0;
            foreach(int item in a)
            {
                if(item%2==0)
                {
                    res[index] = item;
                    index++;
                }
            }
            return res;
        }
        static void Main()
        {
            double result = Demo1.Sqaure(12.3);
            Console.WriteLine("Square: " + result);
            Demo1 obj = new Demo1();
            bool flag = obj.isEven(123);
            Console.WriteLine(flag ? "Even" :"Odd");
            int[] n = { 12, 23, 45, 56, 67, 78, 89 };
            foreach(int k in Demo1.getEvens(n))
            {
                Console.WriteLine(k);
            }

            
        }
    }
}
