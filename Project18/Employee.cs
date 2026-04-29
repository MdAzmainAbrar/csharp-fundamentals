public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string role, double salary)
    {
        Id = id;
        Name = name;
        Role = role;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"ID: {Id} | Name: {Name} | Role: {Role} | Salary: {Salary:C}";
    }
}