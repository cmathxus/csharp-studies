namespace exercicio10;

public class Employee
{
    public int Id { get;set;}
    private string _name;
    public double Salary {get;set;}

    public override string ToString()
    {
        return "Id: "
            + Id 
            + ", Name: "
            + Name 
            + ", Salary: "
            + Salary;
    }

    public string Name {
        get { return _name; }
        set {
            if (value.Length < 3) {
                throw new ArgumentException("Name must be at least 3 characters long.");
            }
            _name = value;
        }
    }
}
