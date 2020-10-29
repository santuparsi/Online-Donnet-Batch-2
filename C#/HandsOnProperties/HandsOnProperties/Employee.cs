using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnProperties
{
    class Employee
    {
        private int eid; //eid should not be -ve or 0
        private string ename; //should not be null
        public int EID
        {
            get { return eid; }
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("Invalid Eid");
                }
                else
                {
                    eid = value;
                }
            }
        }
        public string ENAME
        {
            get { return ename; }
            set
            {
                if (value != null)
                {
                    ename = value;
                }
                else
                    Console.WriteLine("Name should not be null");
            }
        }


    }
    class Test
    {
        static void Main()
        {
            Employee obj = new Employee();
            obj.EID = 1890;
            obj.ENAME = null;
            Employee[] list = new Employee[10];
            list[0] = obj;
        }
    }

}
