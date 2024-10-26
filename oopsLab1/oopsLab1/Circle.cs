using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    //1st
    public class Circle
    {
        private double Radius;
       
        public double radius
        {
            get { return Radius; }
            set
            {
                if(value < 0)
                {
        
                    throw new ArgumentException("radius cannot be zero ");

                }
                Radius = value;

            }
        }

    }
    //2nd 
    public class Employee
    {
        public string empName;
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary Cannot be zero");

                }
                salary = value;
            }
        }
    }

    //3rd -Library management service
    //books

    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }
    //library
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();

        }
        public void AddBook(Book book)
        {
            books.Add(book);
          

        }
        public void RemoveBook(string isbn)
        {
            books.RemoveAll(a => a.ISBN == isbn);
        }
        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }


    //4th question












}
