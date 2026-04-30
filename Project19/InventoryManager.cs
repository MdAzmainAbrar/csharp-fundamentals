using System.Linq;
using Project19;

public class InventoryManager
{
    private readonly List<Product> _products = new();

    public void AddProduct(Product product) => _products.Add(product);

    public void ShowInventory()
    {
        // Foreach loop to iterate through the collection
        foreach (var product in _products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public void RunReport()
    {
        // LINQ: Filter for low stock and sort by price
        var lowStockItems = _products
            .Where(p => p.Stock < 10)
            .OrderBy(p => p.Price);

        Console.WriteLine("\n--- Low Stock Report ---");
        foreach (var item in lowStockItems)
        {
            Console.WriteLine($"{item.Name} needs restocking! (Only {item.Stock} left)");
        }
    }
}
