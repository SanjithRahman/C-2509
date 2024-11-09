using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimentional
{
    internal class Program
    {
        //5th Create a method IncreaseScore that takes a ref integerCreate a method IncreaseScore that takes a ref integer
        public static void IncreaseScore(ref int score)
        {
            score += 10;
            Console.WriteLine($"Score inside method: {score}");
        }

        //12-custom execption
        public static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeException();
            }
            else
            {
                Console.WriteLine($"Number is valid: {number}");
            }
        }
        static void Main(string[] args)
        {
            //1st
            //Library library = new Library(5);
            //library.AddBook(0, "The covanant of water");
            //library.AddBook(1, "famous five");
            //library.AddBook(2, "half girlfriend");
            //library.AddBook(3, "Malgudi Days");
            //library.AddBook(4, "how to train your dragon");
            //library.DisplayBooks();
            //Classroom classroom = new Classroom(2, 2);
            //classroom.AssignSeat(0, 0, "Sanju");
            //classroom.AssignSeat(0, 1, "Nihad");
            //classroom.AssignSeat(1, 0, "Harsh");
            //classroom.AssignSeat(1, 1, "Harshit");
            //classroom.DisplaySeating();

            //2nd
            //Movie mv1 = new Movie("Lucky Bhaskar", 2024);
            //Movie mv2 = new Movie("kishkkkkiinda kandham", 2024);
            //Movie mv3 = new Movie("pani", 2024);
            //MovieLibrary librarys = new MovieLibrary(3);
            //librarys.AddMovie(0, mv1);
            //librarys.AddMovie(1, mv2);
            //librarys.AddMovie(2, mv3);
            //librarys.DisplayMovies();


            //3rd
            //Order od1 = new Order(101, OrderStatus.Pending);
            //Order od2 = new Order(102, OrderStatus.Shipped);
            //Order od3 = new Order(103, OrderStatus.Delivered);
            //od1.DisplayOrder();
            //od2.DisplayOrder();
            //od3.DisplayOrder();

            //4th  Identify the need for value types and reference types
            //Circle circle1 = new Circle(5.0);
            //Circle circle2 = circle1;
            //circle2.Radius = 10.0;

            //Console.WriteLine("Circle Struct:");
            //circle1.Display();
            //circle2.Display();

            //Shape shape1 = new Shape(5.0);
            //Shape shape2 = shape1;
            //shape2.Radius = 10.0;

            //Console.WriteLine("\nShape Class:");
            //shape1.Display();
            //shape2.Display();

            //5th   pass by reference 
            //int playerScore = 50;
            //Console.WriteLine($"Initial Score: {playerScore}");
            //IncreaseScore(ref playerScore);
            //Console.WriteLine($"Score after method call: {playerScore}");

            //6th   need for out keyword
            //int number1 = 20;
            //int number2 = 3;
            //int quotient, remainder;

            //Calculator calculator = new Calculator();

            //calculator.Divide(number1, number2, out quotient, out remainder);
            //Console.WriteLine($" {number1}/ {number2}");
            //Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");

            //7th
            //DisplayException ex1 = new DisplayException();
            //ex1.DisplayFileNotFound();
            //ex1.DisplayIndexOutOfRange();

            //8th -correctinput 
            //CorrectInput cr1 = new CorrectInput();
            //int validInput = cr1.GetUserInput();

            //9th Multiple Catch Blocks
            //Division div = new Division();
            //div.CalculateDivision();

            //10th   finally block to ensure the file is closed
            //FinallyQuestion fn = new FinallyQuestion();
            //fn.ReadFile();

            //11th  Difference between throw and throws
            //try
            //{
            //    ClassThrow classThrow = new ClassThrow();
            //    classThrow.ValidateAge(15);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //12th-custom exceptionof negative numbers.............
            //try
            //{
            //    // Check for negative number
            //    CheckNumber(-5);
            //    CheckNumber(10);



            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //13.log4net

            //14th same as 12 th question 

            //15.a
            FileProcessor file1 = new FileProcessor();
            file1.ReadFileContent("C:\\Users\\sanjjith rahman\\source\\repos\\Multidimentional\\Multidimentional\\IAMSanju.txt");

            //b. Math Operation with Exception Handling
            try
            {
                MathOps mathOps = new MathOps();
                int result = mathOps.Divide(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //c.

            try
            {
                Person person = new Person();
                Console.Write("Enter age: ");
                int inputAge = int.Parse(Console.ReadLine());
                person.SetAge(inputAge);
                Console.WriteLine($"Age set to: {person.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




















            Console.ReadLine();
        }
    }
}
