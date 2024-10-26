using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{

    class ShoppingCart
    {
        private List<Product> products;
        public ShoppingCart()
        {
            products = new List<Product>();
        }
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
        public void AddProduct(string name, double price, int quantity)
        {
            products.Add(new Product(name, price, quantity));
        }
        public void CalculatePr()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price * product.Quantity;
            }
            Console.WriteLine($"Total Price: {total}");
        }
        public void DisplayCart()
        {
            Console.WriteLine("Products in Cart:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
           
        }


    }
}
