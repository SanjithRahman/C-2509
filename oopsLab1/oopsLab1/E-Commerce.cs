using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    public class Product
    {
        public string Name { get; set; }
        private double price;
        private int stockQty;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price cannot be negative.");
                }
                else
                {
                    price = value;
                }
            }
        }

        public int  StockQty
        {
            get { return stockQty; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("stock  cannot be negative.");
                }
                else
                {
                    stockQty=value;
                }
            }
        }
        public Product(string name,double price,int stockQty )
        {
            Name = name;
            Price = price;
            StockQty=stockQty;

        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Stock: {StockQty}");
        }
    }



    public class Order
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Order(string productName, int quantity)
        {
            ProductName = productName;
            Quantity = quantity;
        }
        public void PlaceOrder(List<Product> productlist)
        {
            foreach (Product product in productlist)
            {
                if (product.Name == ProductName)
                {
                    product.StockQty -= Quantity;
                    Console.WriteLine($"Order processed for {Quantity} of {ProductName}. Remaining stock: {product.StockQty}");
                }

            }


        }
    }
}
