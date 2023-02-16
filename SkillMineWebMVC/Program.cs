using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }
        public string DeptName { get; set; }

        public override string ToString()
        {
            return $"ID=> {Id}, Name=> {Name}, Salary=> {Salary},Department Name=> {DeptName}";
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id=121,Name="Payal Bannagare",Salary=34000,DeptName="Marketing"},
                new Employee{Id=122,Name="Vivek Khanke",Salary=37000,DeptName="HR"},
                new Employee{Id=123,Name="Chanchal Sorte",Salary=30000,DeptName="Sales"},
                new Employee{Id=124,Name="Bhushan Pusadkar",Salary=32000,DeptName="Marketing"},
                new Employee{Id=125,Name="Vaishnavi Ingale",Salary=35000,DeptName="Development"},
                new Employee{Id=126,Name="Rolly Kawale",Salary=34000,DeptName="HR"},
                new Employee{Id=127,Name="Ritika Lad",Salary=37000,DeptName="Sales"},
                new Employee{Id=128,Name="Ajay Patil",Salary=33000,DeptName="Development"},
                new Employee{Id=129,Name="Arun Tarle",Salary=38000,DeptName="Marketing"},
                new Employee{Id=130,Name="Rahul Kale",Salary=32000,DeptName="HR"},
                new Employee{Id=131,Name="Gaurav Jain",Salary=33000,DeptName="Sales"},

            };

            //Display all employee

            var result1 = from e in employees
                          select e;

            foreach(Employee e in result1)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            //Display emp from hr dept

            var result2 = from e in employees
                          where e.DeptName == "HR"
                          select e;

            foreach(Employee e in result2)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");


            //Display emp salary in desc order

            var result3 = from e in employees
                          orderby e.Salary descending
                          select e;

            foreach(Employee e in result3)
            {
                Console.WriteLine(e);
                
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Display emp whose name start with p

            var result4 = from e in employees
                          where e.Name.StartsWith("P")
                          select e;

            foreach(Employee e in result4)
            { 
                Console.WriteLine(e);
                
            }

            Console.WriteLine("--------------------------------------------------------------------------------");
            //Display emp whose dept is development & sort the list by name asc

            var result5 = from e in employees
                          where e.DeptName== "Development"
                          orderby e.Name ascending
                          select e;

            foreach(Employee e in result5)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Display emp whose salary is in between 25000 to 35000

            var result6 = from e in employees
                          where e.Salary>=25000 && e.Salary<=35000
                          select e;

            foreach(Employee e in result6)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");




        }
    }
}
