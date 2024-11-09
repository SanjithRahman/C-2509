using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PartialClass;

namespace PartialClass
{
    internal class Program
    {
        //10.creating a divide method and using dividebyzero exception
        static double Divide(int numerator, int denominator)
        {
           
            if (denominator == 0)
            {
                throw new DivideByZeroException(); 
            }


            return (double)numerator / denominator;
        }
        static void Main(string[] args)
        {
            //1st->abstract class with concrete methods  and its inheritence
            //Car myCar = new Car();
            //Motorcycle myMotorcycle = new Motorcycle();
            //myCar.StartEngine();         
            //myCar.StopEngine();         
            //myMotorcycle.StartEngine(); 
            //myMotorcycle.StopEngine();


            //2ND  virtual overide example
            //Dog myDog = new Dog(); 
            //Cat myCat = new Cat();
            //myCat.MakeSound();
            //myDog.MakeSound();

            //3rd  interface inheritence in Car and truck
            //Cars myCar = new Cars();
            //Truck myTruck = new Truck(); 
            //myCar.Drive(); 
            //myTruck.Drive();

            //4th abstract (ovride in child class ) vs interface
            //Duck duck = new Duck();
            //duck.Swim();
            //duck.Fly();

            //5th  static method without creating instance of the class..........
            //int sum1 = MathOperations.Add(2, 3);
            //int product1 = MathOperations.Multiply(6, 6);
            //Console.WriteLine($"sum is {sum1}");
            //Console.WriteLine($"product is {product1}");

            //6th --extension methods of int
            //int num1 = 22;
            //int num2 = 3;
            //num1.IsEven();
            //num2.IsEven();

            //7th partial class-one class metho declaration other method definition
            //method definition

            //Person person = new Person("sanjith");
            //person.ShowDetails();

            //8th --partial class methods example

            //Employee employee = new Employee("sanju", 20, 15);

            //employee.ShowSalary();

            //9th
            Library library = new Library(3);
            //library[0] = new Book("the covenant of water", "Abraham Vargeese");
            //library[1] = new Book("famous five","ENID BLYTON");
            //library[2] = new Book("Malgudi Days ", "R.K.Naranayana");
            //library.DisplayBooks();

            //10th
            //try
            //{
            //    double result = Divide(2, 0);
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException ex)
            //{ 
            //    Console.WriteLine(ex.Message);
            //}

            //11.
            //Carss sedan = new Carss(CarType.Sedan);
            //sedan.DisplayCarType();
            //Carss  truck = new Carss(CarType.Truck);
            //truck.DisplayCarType();
            //Carss coupe=new Carss(CarType.Coupe);

            //coupe.DisplayCarType();

            //12.

           
            Type calculatorType = typeof(Calculator);
            var classAttributes = calculatorType.GetCustomAttributes(false);
            foreach (DeveloperAttribute attr in classAttributes)
            {
                Console.WriteLine($"Class Develped by: {attr.Name}, Last Modified: {attr.LastModified}\n");
            }

            // Retrieve Method Attribute
            var methodInfo = calculatorType.GetMethod("Add");
            var methodAttributes = methodInfo.GetCustomAttributes(false);
            foreach (DeveloperAttribute attr in methodAttributes)
            {
                Console.WriteLine($"Method Develped by: {attr.Name}, Last Modified: {attr.LastModified}");
            }
            Console.ReadLine();


            Console.ReadLine();

        }
    }
}
