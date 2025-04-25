using System;

namespace exercicio10
{
    class Program
    {
        static void Main(String[] args)
        {
            System.Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Employee #{i + 1}: ");
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                while (list.Any(e => e.Id == id))
                {
                    System.Console.Write("This id already exists! Try again: ");
                    id = int.Parse(Console.ReadLine());
                }
                System.Console.Write("Name: ");
                string name = Console.ReadLine();

                System.Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Employee employee = new Employee(id, name, salary);
                list.Add(employee);
            }

            foreach (Employee emp1 in list)
            {
                System.Console.WriteLine(emp1);
            }

            System.Console.WriteLine("------------");

            System.Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if (emp != null)
            {
                System.Console.Write("Enter the percentage: ");
                int percent = int.Parse(Console.ReadLine());
                emp.IncreaseSalary(percent);
            }
            else
            {
                System.Console.WriteLine("This id does not exist!");
            }

            foreach (Employee emp1 in list)
            {
                System.Console.WriteLine(emp1);
            }
        }
    }
}