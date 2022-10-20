using System;
using System.Collections.Generic;
namespace DelegateDemo
{
    class Program
    {

        //--Simple Demo
        //  public delegate int myCalculator(int x, int y);

        //     static int Addition(int x, int y)
        //     {
        //         return x + y;
        //     }

        //     static int Subtraction(int x, int y)
        //     {
        //         return x - y;
        //     }

        //     static int Multiplication(int x, int y)
        //     {
        //         return x * y;
        //     }

        //     static int Division(int x, int y)
        //     {
        //         return x / y;
        //     }

        //     static int Modulo(int x, int y)
        //     {
        //         return x % y;
        //     }

        // static void Main(string[] args)
        // {
           
        //         myCalculator a = new myCalculator(Program.Addition);
        //         myCalculator b = new myCalculator(Program.Subtraction);
        //         myCalculator c = new myCalculator(Program.Multiplication);
        //         myCalculator d = new myCalculator(Program.Division);
        //         myCalculator e = new myCalculator(Program.Modulo);
        //         Console.WriteLine(c(10,5));

        //         //Console.Readkey();  --> It generate an error;
            
        // }

        static void Main()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee(){ID=1, Name="Jay", Experience=0});
            employees.Add(new Employee(){ID=2, Name="Fayzan", Experience=2});
            employees.Add(new Employee(){ID=3, Name="Smit", Experience=1});
            employees.Add(new Employee(){ID=4, Name="Mitesh", Experience=20});

            Employee.filterEmployees(employees);
        }

    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        public static void filterEmployees(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if(employee.Experience > 1)
                {
                    Console.WriteLine("Experienced Employees : " + employee.Name);
                }
            }
        }
    }
}
