using System;

namespace HandsOnProperties
{
    class Sample
    {
        private int a;
        private int b;
        //properties
        public int A
        {
            get { return a; }
            set
            {
                a = value;
            }
        }
        public int B {
            get { return b; }
            set { b = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sample obj = new Sample();
            obj.A = 19;
            int k = obj.A;
            
        }
    }
}
