using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    class ProductCategory
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public ProductCategory(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public ProductCategory()
        {
            Name = "Default Product";
            Price = 0.0;
            Category = "General";
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Category: {Category}");
        }

        public static ProductCategory Create(string name, double price, string category)
        {
            return new ProductCategory(name, price, category);
        }
    }

}
