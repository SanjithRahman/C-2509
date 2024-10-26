using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    public class Item
    {
        public string Name { get; set; }
        private int stock;
        private double price;
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {

                    Console.WriteLine("Stock canot be empty");

                }
                else
                {
                    stock = value;
                }

            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("price cannot be zero");


                }
                else
                {
                    price = value;
                }

            }
        }

        public Item(string name, int stock, double price)
        {
            Name = name;
            Stock = stock; 
            Price = price; 
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Item: {Name}, Stock: {Stock}, Price: {Price}");
        }

    }





    public class Inventory
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} has been added");

        }

        public void RemoveItem(string item)
        {
            items.RemoveAll(a => a.Name == item);
            Console.WriteLine($"{item} has been deleted");


        }
        public void UpdateItem(string itemName, int newStock , double newPrice )
        {
            
            Item toUpdate = items.Find(a => a.Name == itemName);

            if (toUpdate != null)
            {
                toUpdate.Stock = newStock;
                toUpdate.Price = newPrice;

                Console.WriteLine($"{itemName} has been updated");
            }
            else
            {
                Console.WriteLine($"{itemName} not found in inventory");
            }
        }


    }
}
