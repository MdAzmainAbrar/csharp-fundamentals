//a CRUD operation of HR management dashboard
//This project will demonstrate CRUD (Create, Read, Update, Delete) operations while maintaining a clean, object-oriented structure.
class Program
{
    static void Main(string[] args)
    {
        HRDashboard hr = new HRDashboard();

        // 1. CREATE
        hr.AddEmployee(new Employee(101, "Alice Smith", "Developer", 75000));
        hr.AddEmployee(new Employee(102, "Bob Jones", "Manager", 90000));

        // 2. READ
        hr.DisplayAll();

        // 3. UPDATE
        Console.WriteLine("\nUpdating Alice's Salary...");
        if (hr.UpdateSalary(101, 80000))
            Console.WriteLine("Update successful.");
        hr.DisplayAll();

        // 4. DELETE
        Console.WriteLine("\nRemoving Bob...");
        hr.RemoveEmployee(102);

        // Final View
        hr.DisplayAll();

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}