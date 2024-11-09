using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{

    //1st question -> concrete methods-->stopEngine()  and its inheritence in derived class


    public abstract class Vehicle
    {
        public abstract void StartEngine();
        public void StopEngine()
        {
            Console.WriteLine("Vehicle Engine .");
        }
    }
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine .");
        }
    }


    public class Motorcycle : Vehicle
    {

        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine.");
        }
    }
    //2ND   viertual ovveride example with animal base and dog and cat as derived


    public class Animal
    {

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound.");
        }
    }


    public class Dog : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }


    public class Cat : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
    //3rd   class cars and truct inherits Interface IDrive and its demonstration 
    public interface IDrive
    {
        void Drive();
    }


    public class Cars : IDrive
    {

        public void Drive()
        {
            Console.WriteLine("Car has started and moved.");
        }
    }

    public class Truck : IDrive
    {

        public void Drive()
        {
            Console.WriteLine("Truck went oout of petrol.");
        }
    }
    //4th  abstaract class and interface implementation ,overide in  child of abstract parent
    public abstract class Bird
    {
        public abstract void Fly();
    }
    public interface ISwim
    {
        void Swim();
    }
    public class Duck : Bird, ISwim
    {

        public override void Fly()
        {
            Console.WriteLine("Duck flies.");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swims.");
        }
    }
    //static class
    public static class MathOperations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

    }
    //extension methods using static and using integer class and modifying for even
    public static class IntExtensions
    {
       
        public static void IsEven(this int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }

    //7th partial class method definition class
    public partial class Person
    {
        public string Name { get; set; }
        public Person(String name)
        {
            Name = name;
        }
       
    }
    //8th demonstarting partial methods 
    public partial class Employee
    {
        public string Name { get; set; }
        public int TotalDays { get; set; }
        public int PerDayRate { get; set; }
        public Employee(   string name,int days,int rate)
        {
            Name=name;
            TotalDays = days;
            PerDayRate = rate;
        }

       
        partial void CalculateSalary();
        //partial method should be private and used another public method to extend partial methods
        public void ShowSalary()
        {
            CalculateSalary(); 
        }
    }

    //9 Index of books
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    public class Library
    {
        private Book[] books;
        public Library(int size)
        {
            books = new Book[size];
        }
        public Book this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }
        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"title-->{book.Title} Author --->{book.Author}");

            }


        }
    }
    //11.enum types 
    public enum CarType
    {
        Sedan,
        SUV,
        Truck,
        Coupe
    }
    public class Carss
    {
        public CarType Type { get; set; }
        public Carss(CarType type)
        {
            Type = type;
        }

        public void DisplayCarType()
        {
            switch (Type)
            {
                case CarType.Sedan:
                    Console.WriteLine("this is sedan");
                    break;
                case CarType.SUV:
                    Console.WriteLine("this is suv");
                    break;
                case CarType.Truck:
                    Console.WriteLine("this is truck");
                    break;
                case CarType.Coupe:
                    Console.WriteLine("This is Coupe");
                    break;
            }
        }
    }
    //12
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class DeveloperAttribute : Attribute
    {
        public string Name { get; }
        public string LastModified { get; }

        public DeveloperAttribute(string name, string lastModified)
        {
            Name = name;
            LastModified = lastModified;
        }
    }
    [Developer("sanjith rahman", "2024-10-26")]
    public class Calculator
    {
        [Developer("Naveen", "2024-10-29")]
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }











}
