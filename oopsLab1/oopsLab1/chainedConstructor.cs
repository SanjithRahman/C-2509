using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    class BookDetails
    {
        public string title;
        public string author;
        public double price;
        public int year;

        //title;
        public BookDetails(string title)
        {
            this.title = title;
            this.author = "unknown";
            this.price = 0;
            this.year = 0;
        }
        //title and author
        public BookDetails(string title,string author) : this(title)
        {
            this.author = author;

        }
        //title,author,price;
        public BookDetails(string title, string author,double price) :this(title,author)
        {
            this.price = price;
            
         }
        //all fields
        public BookDetails(string title, string author, double price,int year) : this(title, author,price)
        {
            this.year = year;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Title :{title},Author:{author},Price{price},year:{year}");
        }
    }

    
}
