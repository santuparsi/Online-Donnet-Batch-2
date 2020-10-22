using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnMethods
{
    class Compute
    {
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static double Add(double a)
        {
            return 2 * a;
        }
        public static double Add(double i,double j)
        {
            return i + j;
        }
        public static int Add(int a,int b,int c)
        {
            return a + b + c;
        }
    }

    class Demo2
    {
        static void Main()
        {
            Console.WriteLine(Compute.Add(12.3));
            Console.WriteLine(Compute.Add(1, 2));
            Console.WriteLine(Compute.Add(12.3, 34.5));
            Console.WriteLine(Compute.Add(1, 2, 4));
        }
    }
}
