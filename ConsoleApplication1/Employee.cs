using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employee
    {
        private string name;
        private string address;
        private int salary;
        public Employee()
        {
            Console.WriteLine("wlecome to our conpany");
            this.name = "Unkown";
            this.address = "Mukalla";
            this.salary = 3000;
        }


        public Employee (string name):this()
        {
            this.name = name;
            Console.WriteLine(name);
        }
        public Employee (string name,string address):this(name)
        {
            this.address = address;
           Console.WriteLine(address);
        }
        public Employee(string name, string address,int salary):this(name,address)
       {
            this.salary = salary;
            Console.WriteLine(salary);
        }
       
       


    }
}
