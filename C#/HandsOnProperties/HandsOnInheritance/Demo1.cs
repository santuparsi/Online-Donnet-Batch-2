using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnInheritance
{
    class X
    {
        public int a;
    }
    class Y:X
    {
        public int b;
    }
    class Z:Y
    {
        public int c;

    }

    class Demo1
    {
        static void Main()
        {
            Y obj = new Y();
            obj.a = 10;
            obj.b = 20;
            Z obj1 = new Z();
            obj1.a = 10;
            obj1.b = 34;
            obj1.c = 90;
        }
    }
}
