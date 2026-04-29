public class HRDashboard
{
    private List<Employee> _employees = new List<Employee>();

    // CREATE
    public void AddEmployee(Employee emp)
    {
        _employees.Add(emp);
        Console.WriteLine("Employee added successfully.");
    }

    // READ
    public void DisplayAll()
    {
        Console.WriteLine("\n--- Employee Records ---");
        if (_employees.Count == 0) Console.WriteLine("No records found.");
        foreach (var emp in _employees) Console.WriteLine(emp);
    }

    // UPDATE
    public bool UpdateSalary(int id, double newSalary)
    {
        var emp = _employees.Find(e => e.Id == id);
        if (emp != null)
        {
            emp.Salary = newSalary;
            return true;
        }
        return false;
    }

    // DELETE
    public bool RemoveEmployee(int id)
    {
        var emp = _employees.Find(e => e.Id == id);
        if (emp != null)
        {
            _employees.Remove(emp);
            return true;
        }
        return false;
    }
}