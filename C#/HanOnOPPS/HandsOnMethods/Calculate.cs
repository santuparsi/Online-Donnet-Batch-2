using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnMethods
{
    class Calculate
    {
       public int result;
        public void f()
        {
            Console.WriteLine("I am a Method");
        }
        public int Add(int a,int b)
        {
            result = a + b;
            return result;
        }
        public string Greet(string name)
        {
            if(name==null)
            {
                return "Hello Anonymous User..";
            }
            else
            {
                return "Hello " + name;
            }
        }
    }
    class Test_Calculate
    {
        static void Main()
        {
            Calculate obj = new Calculate();
           
            obj.f(); //calling method f
                     //Console.WriteLine(obj.result);
            Console.WriteLine(obj.result);
            obj.Add(12, 4);
            Console.WriteLine("Addition: " + obj.result);
            Calculate obj1 = new Calculate();
            Console.WriteLine(obj1.Greet(null));
            Console.WriteLine(obj1.Greet("Sachin"));
            Console.WriteLine(obj1.result);
        }
    }
}
