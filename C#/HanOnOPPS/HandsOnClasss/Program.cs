using System;

namespace HandsOnClasss
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.ReadKey(); //Read console output
            //Instantiate Employee
            Employee employee = new Employee();
            //set values to Employee
            employee.Eid = "E9237";
            employee.Ename = "David";
            employee.JoinDate = DateTime.Parse("12.2.2018");
            employee.Salary = 45000;
            Employee employee1 = new Employee() //Object Initializer
            {
                Eid = "E3243",
                Ename = "Jeson",
                JoinDate = Convert.ToDateTime("12.3.2019")
            };
            Employee employee2 = new Employee() //Object Initializer
            {
                Eid = "E3243",
                Ename = "Karan",
                JoinDate = Convert.ToDateTime("12.3.2019")
            };
            //Employee Array
            Employee[] list = new Employee[3] { employee, employee1, employee2 };
            Console.WriteLine("Employee Details");
            foreach (Employee e in list)
            {

                Console.WriteLine("ID:{0} Name:{1} JoinDate:{2} Salary {3}",
                    e.Eid, e.Ename, e.JoinDate, e.Salary);
                Console.WriteLine("---------------------");
            }
         
            

        }
    }
}
