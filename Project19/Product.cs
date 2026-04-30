namespace Project19;

// Modern C#: Primary Constructor
public class Product(int id, string name, string category, double price, int stock)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public string Category { get; } = category;
    public double Price { get; } = price;
    public int Stock { get; set; } = stock;

    // ToString Override using String Interpolation
    public override string ToString() =>
        $"[{Id}] {Name,-15} | Category: {Category,-10} | Price: {Price:C} | Stock: {Stock}";
}