using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
     public class Print
    {
        public void PrintData(string data)
        {
            Console.WriteLine($"String: {data}");


        }
        public void PrintData(int data)
        {
            Console.WriteLine($"Integer: {data}");
        }

        public void PrintData(int[] arr)
        {
            Console.WriteLine("Array of Integers: ");
            foreach (var  num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); 
        }


    }


    class Rectangle
    {
        public void area(double height,double width )
        {
            Console.WriteLine("Area of rectable is " + (height * width));

        }
        public void area(double side)
        {
            Console.WriteLine("Area of square  is " + (side*side));
        }

    }
    public class Time
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public void WriteTime(int hrs,int min)
        {
            Hours = hrs;
            Minutes = min;
            Seconds = 0;
            Console.WriteLine("Time: " + Hours + ":" + Minutes + ":" + Seconds);
        }
        public void WriteTime(int sec)
        {
            Hours = sec / 3600;
            Minutes = (sec % 3600) / 60;
            Seconds = sec % 60;
            Console.WriteLine("Time: " + Hours + ":" + Minutes + ":" + Seconds);

        }


    }
    class ProductDetails
    {
        public string Name;
        public double Price { get; set; }
        public double Discount { get; set; }
        public ProductDetails(string name)
        {
            Name = name;
            Price = 0;           
            Discount = 0;       
        }
        public ProductDetails(string name, double price)
        {
            Name = name;
            Price = price;       
            Discount = 0;        
        }
        public ProductDetails(string name, double price, double discount)
        {
            Name = name;
            Price = price;       
            Discount = discount; 
        }
        public void CalculatePrice()
        {
            if (Discount>0)
            {
                double dist = Price*(Discount /100);
                Price = Price - dist;


            }
            Console.WriteLine($"final price aftr discount is  is {Price}");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"product name{Name} Price{Price} Discount {Discount}");

        }



    }


}
