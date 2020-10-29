using System;

namespace HandsOnInheritance
{
    class A
    {
        private int a;
        public int b;
        protected int c;
        internal int d;
        private string name;
        public A()
        {
            Console.WriteLine("I am Class A Constuctror");
        }
        public A(string name)
        {
            this.name = name;
            Console.WriteLine("Hello " + name);
        }
    }
    class B:A
    {
        public void f()
        {
            b = 10;
            c = 30;
            d = 35;
            A obj = new A(); //private and protected data is not accessable using class object.
            obj.b = 90;
            obj.d = 79;
        }
        public B()
        {
            Console.WriteLine("I am Class B Constructor");
        }
        public B(string name):base(name)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            B obj = new B();
            obj.b = 45;
            obj.d = 36;
            obj.f();
            A obj1 = new B(); //access only class A members and override members of Class B
            B obj2 = new B("Sachin");
            
        }
    }
}
