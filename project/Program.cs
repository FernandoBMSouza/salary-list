using System;
using System.Collections.Generic;
using System.Globalization;

namespace Fernando
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            System.Console.Write("How many employees will be registred: ");
            int quant = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quant; i++)
            {
                System.Console.WriteLine($"Employee #{i}");
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.WriteLine();

                employees.Add(new Employee(id, name, salary));
            }

            System.Console.Write("Enter the employee id that will have salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());

            Employee choosenEmployee = employees.Find(x => x.Id == employeeId);

            if(choosenEmployee != null)
            {
                System.Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                choosenEmployee = employees.Find(x => x.Id == employeeId);
                choosenEmployee.IncreaseSalary(percentage);
            }
            else
            {
                System.Console.WriteLine("This id does not exist!");
            }

            System.Console.WriteLine();

            foreach(Employee e in employees)
            {
                System.Console.WriteLine(e);
            }
        }
    }
}
