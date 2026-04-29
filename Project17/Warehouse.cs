using System;
using System.Collections.Generic;
using System.Text;

namespace Project17
{
    public class Warehouse
    {
        private List<InventoryItem> _items = new List<InventoryItem>();

        public void AddItem(InventoryItem item)
        {
            _items.Add(item);
            Console.WriteLine($"{item.Name} added to warehouse.");
        }

        public void ShowAllItems()
        {
            Console.WriteLine("\n--- Current Inventory ---");
            foreach (var item in _items)
            {
                item.DisplayDetails(); // Calls the correct version (Polymorphism)
            }
        }
    }
}
