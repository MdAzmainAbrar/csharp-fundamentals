//Smart Warehouse Management System.
//This project is a perfect sandbox because it requires organizing data (OOP),
//filtering it (LINQ), and handling different logic branches (Switch).
using Project19;


internal class Program
{
    private static void Main(string[] args)
    {
        var manager = new InventoryManager();

        // Adding data
        manager.AddProduct(new Product(101, "OLED TV", "Electronics", 1200.00, 5));
        manager.AddProduct(new Product(102, "Laptop", "Electronics", 800.00, 15));
        manager.AddProduct(new Product(201, "Organic Apple", "Food", 2.50, 50));

        // 1. Display All
        Console.WriteLine("Current Inventory:");
        manager.ShowInventory();

        // 2. Use Switch Logic
        var tv = new Product(101, "OLED TV", "Electronics", 1200.00, 5);
        double discounted = DiscountService.GetDiscountedPrice(tv);
        Console.WriteLine($"\nDiscount check: {tv.Name} original: {tv.Price:C}, after discount: {discounted:C}");

        // 3. Run LINQ Report
        manager.RunReport();
    }
}