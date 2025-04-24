using System;

namespace exercicio10 {
    class Program { 
        static void Main (String [] args) {
            System.Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Employee employee = new Employee();
                System.Console.WriteLine($"Employee #{i + 1}: ");
                System.Console.Write("Id: ");
                employee.Id = int.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                employee.Name = Console.ReadLine();
                System.Console.Write("Salary: ");
                employee.Salary = double.Parse(Console.ReadLine());

                list.Add(employee);
            }

            foreach (Employee emp in list) {
                System.Console.WriteLine(emp);
            }
        }
    }
}