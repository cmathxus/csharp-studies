using System.Globalization;

namespace exercicio10;

public class Employee
{
    public int Id { get; set; }
    private string _name;
    public double Salary { get; private set; }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return "Id: "
            + Id
            + ", Name: "
            + Name
            + ", Salary: $"
            + Salary.ToString("F2", CultureInfo.InvariantCulture);
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name must be at least 3 characters long.");
            }
            _name = value;
        }
    }

    public void IncreaseSalary(double percent)
    {
        Salary += Salary * percent / 100.0;
    }
}
