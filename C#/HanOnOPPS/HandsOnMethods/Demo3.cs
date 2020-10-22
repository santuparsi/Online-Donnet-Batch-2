using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnMethods
{
    class Demo3
    {
        public static void M(int a)
        {
            a = a * a;
            Console.WriteLine(a);
        }
        public static void M1(ref int a)
        {
            a = a * a;
            Console.WriteLine(a);
        }
        static void Main()
        {
            int a = 10;
            Console.WriteLine("a value before Calling M() " + a);
            Demo3.M(a);
            Console.WriteLine("a value after Calling M() " + a);
            Console.WriteLine("a value before Calling M1() " + a);
            Demo3.M1(ref a);
            Console.WriteLine("a value after Calling M1() " + a);
        }
    }

}
