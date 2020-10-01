using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnClasss
{
    class Employee
    {
        //class-variables
        public string Eid;
        public string Ename;
        public DateTime JoinDate;
        private int Exp;
        public double Salary;
        public Employee() //default construnctor
        {
            Eid = "E40943";
            Ename = "Mic";
            JoinDate = DateTime.Parse("2.2.2020");
            Exp = 1;
            Salary = 14000;
        }
        public Employee(string id,string name,DateTime date,int exp,double sal)
        {
            //assing parameter values to class-varaible
            Eid = id;
            Ename = name;
            JoinDate = date;
            Exp = exp;
            Salary = sal;
        }
       
        public void Display()
        {
            //display employee values
            Console.WriteLine("ID:{0} Name:{1} JoinDate:{2} Salary {3}",
                    Eid, Ename, JoinDate, Salary);
        }
    }
    class Test_Employee
    {
        static void Main()
        {
            Employee e1 = new Employee(); //default construnctor invokes 
           // e1.Display();
            Employee e2 = new Employee("E009","David",DateTime.Parse("12.2.2019"),2,23000);
            //e2.Display();
            Employee e3 = new Employee("E9987", "Peter", DateTime.Parse("3.10.2019"), 2, 30000);
            Employee[] list = new Employee[3] { e1, e2, e3 };
            foreach(Employee e in list)
            {
                e.Display();
                Console.WriteLine("---------------------------");
            }
        }
    }
    
}
