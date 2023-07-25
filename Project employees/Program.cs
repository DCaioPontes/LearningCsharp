using System;
using Base;

namespace App
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            var quantityEmployees = int.Parse(Console.ReadLine());

            List<Funcionarios> kromos = new List<Funcionarios>();
            for (var i = 0; i < quantityEmployees; i++)
            {
                var employees = i + 1;
                Console.WriteLine($"Employee #{employees}");
                Console.Write("ID: ");
                var id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Salary: ");
                var salary = double.Parse(Console.ReadLine());
                kromos.Add(new Funcionarios(id, name, salary));
            }

            Console.Write("Enter the employees id that will have salary increase: ");
            var idCheck = int.Parse(Console.ReadLine());
            Funcionarios employee = kromos.Find(x => x.Id == idCheck);
            kromos.Remove(employee);

            if (employee != null)
            {
                Console.Write("Enter the percentage to upgrade: ");
                var percent = double.Parse(Console.ReadLine());
                employee.Upgrade(percent);
                kromos.Add(employee);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees;");
            foreach (var employees in kromos)
            {
                Console.WriteLine(employees);
            }
        }
    }
}