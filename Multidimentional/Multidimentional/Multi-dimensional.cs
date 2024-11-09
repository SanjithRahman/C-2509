using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimentional
{
    
    //1st__question
    public  class Library
    {
        public string[] books;
        public Library(int size) {
        
            books = new string[size];
        }
        public void AddBook(int index,string title)
        {
            if((index >= 0) && (index < books.Length))
            {
                books[index] = title;
            }
            else
            {
                Console.WriteLine("invalid indx");
            }
        }
        public void DisplayBooks()
        {
           
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Index {i}: {books[i]}");
            }
        }

    }
    public class Classroom
    {
        public string[,] seats;
        public Classroom(int rows, int columns)
        {
            seats = new string[rows, columns];
        }
        public void AssignSeat(int row, int col, string student)
        {
            if (row >= 0 && row < seats.GetLength(0) && col >= 0 && col < seats.GetLength(1))
            {
                seats[row, col] = student;
                Console.WriteLine($"Assigned {student} to seat ({row}, {col}).");
            }
            else
            {
                Console.WriteLine("Invalid seat position.");
            }
        }
        public void DisplaySeating()
        {
            Console.WriteLine("Classroom Seating:");
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    Console.Write($"{(seats[i, j] )}\t");
                }
                Console.WriteLine();
            }
        }


    }

    //2nd 
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
    }
    public class MovieLibrary
    {
        //created a  movie array
        public  Movie[] movies;

        public MovieLibrary(int size)
        {
            movies = new Movie[size];
        }
        //added movies 
        public void AddMovie(int index,Movie mv1)
        {
            if (index >= 0 && index < movies.Length)
            {
                movies[index] = mv1;
                
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        public void DisplayMovies()
        {
            foreach (var movie in movies)
            {       
                    Console.WriteLine($"Title: {movie.Title}, Year: {movie.Year}");
            }

        }
    }

    //3rd  enum
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }
    public class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int orderId,OrderStatus st1)
        {
            OrderId = orderId;
            Status = st1;

        }
        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}, Status: {Status}");
        }



    }

    //4th

    public struct Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Display()
        {
            Console.WriteLine($"Circle Radius: {Radius}");
        }
    }

    public class Shape
    {
        public double Radius { get; set; }

        public Shape(double radius)
        {
            Radius = radius;
        }

        public void Display()
        {
            Console.WriteLine($"Shape Radius: {Radius}");
        }
    }
    //5th

    //6th
    public class Calculator
    {

        public void Divide(int num1, int num2, out int quotient, out int remainder)
        {
            quotient = num1 / num2;
            remainder = num1 % num2;
        }
    }
    //7th
    public class DisplayException
    {
        public void DisplayFileNotFound()
        {
            try
            {

                string content = File.ReadAllText("abc.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("could not locate file"+ex.StackTrace);
            }
        }

        public void DisplayIndexOutOfRange()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };

                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

    //8th
    public class CorrectInput
    {
        public int GetUserInput()
        {
            int userInput;
            while (true)
            {
                Console.Write("Please enter an integer: ");
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            return userInput;
        }
    }

    //9th
    public class Division
    {
        public void CalculateDivision()
        {
            try
            {
                Console.Write("Enter number1: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter number2: ");
                int num2 = int.Parse(Console.ReadLine());

                int  result = num1 / num2;
                //Console.WriteLine($"Result: {num1} / {num2} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid integers.");
            }
        }
    }

    //10th finaly statements
    class FinallyQuestion
    {
        public void ReadFile()
        {
            string fileName = "C:\\Users\\sanjjith rahman\\source\\repos\\Multidimentional\\Multidimentional\\abc222.txt";

            StreamReader readFromFile = null;
            try
            {
                readFromFile = new StreamReader(fileName);
                string text = readFromFile.ReadToEnd();
                Console.WriteLine("text inside file:");
                Console.WriteLine(text);
                Console.WriteLine("----------------");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (readFromFile != null)
                {
                    readFromFile.Close();
                    Console.WriteLine("File closed");
                }
            }


        }
    }

        //11th
        public class ClassThrow
        {
            public void ValidateAge(int age)
            {

                if (age < 18)
                {
                    throw new ArgumentException("Age must be 18 or older.");
                }
                Console.WriteLine("Age is valid.");
            }
        }
    //12-customexception
    public class NegativeException : Exception
    {
        public NegativeException() {
            Console.WriteLine("Negative number exception occurred.");
        }
        
    }

    //15
    //a.runtime exceptions
    public class FileProcessor
    {
        public void ReadFileContent(string filePath)
        {
            try
            {
                StreamReader reader = new StreamReader(filePath);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line); 
                }
                reader.Close(); 
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
        }
    }
    //b.runtime exceptions
    public class MathOps
    {
        public int  Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
        }
    }


    //c.custom exception of invalid age
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
            Console.WriteLine("Invalid age entered");
        }


    }
    //creating a class person for setAge method
    public class Person
    {
        
        public int Age { get; set; }
       
        public void SetAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException();
            }
            Age = age; 
        }
    }


}



















