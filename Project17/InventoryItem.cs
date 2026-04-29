using System;
using System.Collections.Generic;
using System.Text;
// The Base Class (Abstraction & Encapsulation)
//We start with an abstract class. This means you can't create a generic "Item"—it has to be a specific type of product. We use Encapsulation by making price private and providing a public property to access it safely.
namespace Project17
{
    public abstract class InventoryItem
    {
        // Encapsulation: Properties protect the data
        public string Name { get; set; }
        private double _price;

        public double Price
        {
            get => _price;
            set => _price = value > 0 ? value : 0; // Logic to prevent negative prices
        }

        public InventoryItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Polymorphism: This method can be overridden by child classes
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Item: {Name} | Price: {Price:C}");
        }
    }
}
