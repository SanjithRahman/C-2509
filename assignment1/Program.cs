using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Hello world");
            Console.WriteLine("Enter your Name");
            string n1 = Console.ReadLine();
            Console.WriteLine("Hello " + n1);
            //2

            Console.WriteLine("Enter your  full NAME:");
            string n2 = Console.ReadLine();
            Console.WriteLine("Enter your AGE:");
            string n3 = Console.ReadLine();
            Console.WriteLine("Hello " + n2 + "your age is " + n3);
            Console.WriteLine("Enter your favorite color:");
            string n4 = Console.ReadLine();
            Console.WriteLine("Hello " + n2 + "your age is " + n3 + " And you color is " + n4);

            //3
            int sum1 = 0;
            Console.WriteLine("Enter 1st num");
            string n1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd num");
            string n2 = Console.ReadLine();
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            sum1 = num1 + num2;
            Console.WriteLine($"adddition {sum1}");
            if (num1 > num2)
            {
                sum1 = num1 - num2;
            }
            else
            {
                sum1 = num2 - num1;
            }
            Console.WriteLine($"Subtraction {sum1}");
            sum1 = num1 * num2;
            Console.WriteLine($"multiplicaiton {sum1}");
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine($"Divioson by zero");

            }
            else
            {
                double sum2 = (double)num1 / num2;

                Console.WriteLine($"Divioson is {sum2}");
            }



            //4
            double cel;
            Console.WriteLine("Enter Temperature in Cel");
            string n1 = Console.ReadLine();
            cel = double.Parse(n1);
            double fah = (cel * 9 / 5) + 32;
            Console.WriteLine($"Temparature in fah is {fah} ");

            Console.ReadLine();

            Console.WriteLine(".........Simple interest.......");
            Console.WriteLine("Enter simple inter");
            string n2 = Console.ReadLine();
            double inter = double.Parse(n2);
            Console.WriteLine("Enter principal amount");
            string n3 = Console.ReadLine();
            double pr = double.Parse(n3);
            Console.WriteLine("Enter time");
            string n4 = Console.ReadLine();
            double ti = double.Parse(n4);
            double sp = (inter * pr * ti) / 100;
            Console.WriteLine($"SI is {sp}");
            Console.ReadLine();

            Console.WriteLine("......Area calculation......");
            const double pi = 3.14;
            Console.WriteLine("Enter the radius");
            string n5 = Console.ReadLine();
            double rad = double.Parse(n5);
            double area = pi * rad * rad;
            Console.WriteLine($"Area is {area}");

            //seconds caluclations

            Console.WriteLine("Enter the Seconds......");
            string sec = Console.ReadLine();
            int secInt = Convert.ToInt32(sec);
            int hours = secInt / 3600;
            int minutes = (secInt % 3600) / 60;
            int seconds = secInt % 60;
            Console.WriteLine($"{hours} hrs :{minutes} min: {seconds} sec");
            Console.ReadLine();


            //character count

            Console.WriteLine("...Character count......");
            string input1 = Console.ReadLine();
            string trimmedInput = input1.Replace(" ", "");
            int length = trimmedInput.Length;
            Console.WriteLine(length);
            Console.ReadLine();
            Console.WriteLine("....................");


            ///BMI CALCULATOR

            Console.WriteLine("Enter the height");
            string height = Console.ReadLine();
            Console.WriteLine("Enter the weight");
            string weight = Console.ReadLine();
            double weightValue = double.Parse(weight);
            double heightValue = double.Parse(height);
            double bmi = weightValue / (heightValue * heightValue);
            Console.WriteLine($"bmi is  {bmi}");
            Console.ReadLine();
            Console.WriteLine("....................");


            //11 variables and constants
            Console.WriteLine("Variables and Constants...");
            const double pi = 3.14;
            Console.WriteLine("Enter the radius");
            string n5 = Console.ReadLine();
            double rad = double.Parse(n5);
            double area = pi * rad * rad;
            Console.WriteLine($"Area  of circle is {area}");
            Console.WriteLine("Enter the length");
            string len1 = Console.ReadLine();
            Console.WriteLine("Enter the breadth");
            string br1 = Console.ReadLine();
            double leng1 = Convert.ToDouble(len1);
            double bread = Convert.ToDouble(br1);
            double area1 = leng1 * bread;
            Console.WriteLine($"Area  of rectangle  is {area1}");
            Console.ReadLine();
            Console.WriteLine("....................");

            //12 using constants.......
            const double Pi = 3.14159;
            const int Days = 7;
            Console.Write("Enter the radius ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = 2 * Pi * radius;
            Console.WriteLine("circumference: " + circumference);
            Console.WriteLine("Days in week: " + Days);
            Console.ReadLine();
            Console.WriteLine("....................");


            //13 .inches 
            const double inchesToCm = 2.54;
            Console.Write("Enter the width in inches ");
            double width12 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height in inches ");
            double height12 = Convert.ToDouble(Console.ReadLine());
            double areaInInches = width12 * height12;
            double widthInCm = width12 * inchesToCm;
            double heightInCm = height12 * inchesToCm;
            double areaInCm = widthInCm * heightInCm;
            Console.WriteLine("\nArea in sq.inches: " + areaInInches);
            Console.WriteLine("Area in sq.centim: " + areaInCm);
            Console.ReadLine();
            Console.WriteLine("....................");

            //14.valid employe name
            Console.WriteLine("Enter employee name");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter employee age");
            string empAge = Console.ReadLine();
            Console.WriteLine("Enter employee  salary");
            string empsal = Console.ReadLine();
            Console.WriteLine($"emp name :{empName} age:{empAge} sal:{empsal}");

            //15.
            int number1 = 5;
            int number2 = 3;
            int sum1 = number1 + number2;
            Console.WriteLine($"the sum of {number1} and {number2} is {sum1}");

            ////16.
            int number = 10;
            string message = "Hello, World!";
            double pi1 = 3.14;
            Console.WriteLine("Integer value: " + number);
            Console.WriteLine("String value: " + message);
            Console.WriteLine("Double value: " + pi1);

            //17
            Console.Write("Enter the base: ");
            double base1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the expo: ");
            double expo = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(base1, expo);


            Console.WriteLine($"{base1} ** {expo} is: {result}");


            ;

            //18   VOTE ELGIBLITY
            Console.Write("Enter  age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Are you a citizen? (y/n): ");
            string isCitizen = Console.ReadLine().ToLower();
            if (age >= 18 && isCitizen == "y")
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            ;

            //19.

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your  income : ");
            double income = Convert.ToDouble(Console.ReadLine());
            Console.Write("Do you have any outstanding loans? (yes/no): ");
            string loan = Console.ReadLine();
            if (age >= 21 && income >= 30000 && loan.ToLower() == "no")
            {
                Console.WriteLine("You are eligible for a loan.");
            }
            else
            {
                Console.WriteLine("You are not eligible for a loan.");
            }

            //20.

            Console.WriteLine("eNTER YOUR AGE ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter work exp");
            int workExp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("do you have college degree(yes/no)");
            string hasCollegeDegree = Console.ReadLine().ToLower();
            bool isEligible = (age >= 18 && age <= 35) &&
                         (workExp >= 2) &&
                         (hasCollegeDegree == "yes" || workExp >= 5);

            if (isEligible)
            {
                Console.WriteLine("You are eligible to apply for the job.");
            }
            else
            {
                Console.WriteLine("You are not eligible to apply for the job.");
            }

            //21.
            Console.Write("Enter a character: ");
            char ch = (char)Console.Read();



            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                    ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    Console.WriteLine($"{ch} is a vowel.");
                }
                else
                {
                    Console.WriteLine($"{ch} is a consonant.");
                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an alphabet character.");
            }
            ////22 check number is positive, negative or zero
            //Console.WriteLine("Enter the number");
            //double number = Convert.ToDouble(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("The number is zero");
            //} else if (number > 0) {
            //    Console.WriteLine("The number is positive");
            //}

            ////23
            ///
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number%5 == 0 && number%11 == 0)
            //{
            //    Console.WriteLine($"The number {number} is divisible by 5 and 11");
            //}
            //else
            //{
            //    Console.WriteLine($"The number {number} is not divisible by 5 and 11");
            //}

            ////24 simple calculator
            Console.WriteLine("Enter first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose an operation +, -, *, /");
            string operation = Console.ReadLine();
            if (operation == "+")
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            }
            else if (operation == "-")
            {
                Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            }
            else if (operation == "*")
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            }
            else if (operation == "/")
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            }

            Console.ReadLine();




        }

    }
}
