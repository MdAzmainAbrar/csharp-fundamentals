using System;
using System.Collections.Generic;
using System.Text;

namespace Project11
{
    public class Cart
    {
        //field 
        private string? _cartId;
        private Dictionary<string, double> _items; //dictionary of <string,double> such as <"lolipoop",2.5>

        //constructor

        public Cart()
        {

        }
        public Cart(string cartId)
        {
            _cartId = cartId;
            _items = new Dictionary<string, double>();
        }

        //methods
        public void AddItem(string item, double price)
        {
            _items.Add(item,price); //adds an item to the cart
        }

        public void RemoveItem(string item)
        {
            _items.Remove(item); //remove items from the cart
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var item in _items) //(KeyValuePair<string, double> item in _items)
            {
                total += item.Value; //returns the total cost of the items in the cart
            }
            return total;
        }

        public override string ToString()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Cart ID: {_cartId}");
            //sb.AppendLine("Items:");
            //foreach (var item in _items)
            //{
            //    sb.AppendLine($"{item.Key}: ${item.Value}");
            //}
            //sb.AppendLine($"Total: ${GetTotal()}");
            //return sb.ToString();
            string result = $"Cart ID: {_cartId}\nItems:\n";
            foreach (var item in _items)
            {
               result += $"{item.Key}: ${item.Value.ToString("F2")}\n";
            }
            result += $"Total {GetTotal().ToString("F2")}\n";
            return result;
        }
    }
}
