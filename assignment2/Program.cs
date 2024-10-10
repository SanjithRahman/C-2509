using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.mukpliplication table

            Console.Write("enter  number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }

            //2.
            Console.Write("enter  number of rows ");
            int row1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }

            //3.sum of all even Numbers
            int evenSm = 0;
            int start = 1;
            while (start <= 100)
            {
                if ((start % 2) == 0)
                {
                    evenSm += start;
                }
                start++;
            }
            Console.WriteLine($"the Sm of even number is {evenSm}");

            //4.nested while loop.........
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                Console.WriteLine("..............");
                while (j <= 5)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                    j++;
                }
                i++;
            }
            //5.


            while (true)
            {
                Console.WriteLine("Enter a positive Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 < 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Entered  Number is {num1}");
                }
            }

            //simple caluclator

            int ch;
            do
            {
                Console.WriteLine("Calculator,Enter ");
                Console.WriteLine("1 for Addition");
                Console.WriteLine("2 for subtraction");
                Console.WriteLine("3 for multiplication");
                Console.WriteLine("4 for division");
                Console.WriteLine("5 for exit");
                Console.WriteLine("Enter you choice ");

                ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 5)
                {
                    break;
                }
                Console.WriteLine("Enter 1st num");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2 nd Num");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine($"{num1}+{num2}={num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1}-{num2}={num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1}*{num2}={num1 * num2}");
                        break;
                    case 4:
                        double div1 = (double)num1 / num2;
                        if (num2 == 0)
                        {
                            Console.WriteLine("Divison by zero");

                        }
                        else
                        {
                            Console.WriteLine($"{num1}/{num2}={div1}");

                        }
                        break;
                }




            } while (ch != 5);

            //7th question

            for (int i = 1; i <= 100; i++)
            {
                if (i > 50)
                {
                    break;
                }

                if (i % 3 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write($"{i},");

                }


            }

            c//alculates odd sum..
             //int sum1 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sum1 += i;
                }
            }
            Console.WriteLine($"sum is {sum1}");

            //factorial using while

            int fact = 1;
            Console.WriteLine("Enter the Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (i <= num1)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine($"Factorial is {fact}");


            //10 .Number pyramid

            Console.WriteLine("Enter  no:of rows");
            int r1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= r1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }


            //13.sum of digits...

            Console.WriteLine("Enter  the digit");
            int digi = Convert.ToInt32(Console.ReadLine());
            int sumDigi = 0;
            int temp = digi;
            while (digi > 0)
            {
                int rem = digi % 10;
                sumDigi += rem;
                digi = digi / 10;

            }
            Console.WriteLine($"sum of {temp} is {sumDigi}");


            //14.finding largest number..............Console.Write($"Enter 10 numbers  number : ");
            Console.WriteLine();
            int largest = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {

                int num = Convert.ToInt32(Console.ReadLine());



                if (num > largest)
                {
                    largest = num;
                }
            }
            Console.WriteLine($"The largest number entered is: {largest}");



            //15.sum of squares......
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int sumSquare = 0;
            int i = 1;
            while (i <= num1)
            {
                sumSquare += i * i;
                i++;
            }
            Console.WriteLine($"The sum of squares from 1 to {num1} is: {sumSquare}");

            //16.Countdown timer...............

            int end = 10;
            do
            {
                Console.WriteLine(end);
                end--;

            } while (end > 0);

            //18.

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + ",");
                }

            }

            //19.

            Console.WriteLine("Enter  the digit");
            int digi = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = digi;
            while (digi > 0)
            {
                int rem = digi % 10;
                rev = rev * 10 + rem;
                digi = digi / 10;

            }
            if (rev == temp)
            {
                Console.WriteLine($"{temp} is pallindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }

            //20.
            int sum = 0;
            int count = 0;
            int num;
            do
            {
                Console.Write("Enter a positive number:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    sum += num;
                    count++;
                }

            } while (num >= 0);

            double average = (double)sum / count;
            Console.WriteLine($" total sum is {sum} and Average is : {average}");


            //21 reverse a number.........

            Console.WriteLine("Enter  the digit");
            int digi = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = digi;
            while (digi > 0)
            {
                int rem = digi % 10;
                rev = rev * 10 + rem;
                digi = digi / 10;

            }
            Console.WriteLine($"The reversed number is {rev}");
            //22.

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("\n1. Reverse");
                Console.WriteLine("2. Uppercase");
                Console.WriteLine("3. Lowercase");
                Console.WriteLine("4. Length");
                Console.WriteLine("5. Exit");
                Console.Write("Choose (1-5): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        char[] arr = input.ToCharArray();
                        Array.Reverse(arr);
                        Console.WriteLine("Reversed: " + new string(arr));
                        break;
                    case 2:
                        Console.WriteLine("Upper: " + input.ToUpper());
                        break;
                    case 3:
                        Console.WriteLine("Lower: " + input.ToLower());
                        break;
                    case 4:
                        Console.WriteLine("Length: " + input.Length);
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }

            //23.from 1 to 50 but skip numbers that are divisible by 4 using
            //the continue statement.

            for (int i = 1; i <= 50; i++)
            {

                if (i % 4 == 0)
                {
                    continue;
                }
                Console.Write(i + ",");
            }


            //24.fibonnaci series
            int first = 0;
            int second = 1;
            int thrid;
            Console.Write($"{first},{second},");
            for (int i = 2; i < 10; i++)
            {


                thrid = first + second;
                Console.Write($"{thrid},");
                first = second;
                second = thrid;
            }
            //25.

            int number = 1;

            Console.WriteLine("Armstrong numbers between 1 and 500 are:");

            while (number <= 500)
            {
                int temp = number;
                int sum = 0;


                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += digit * digit * digit;
                    temp /= 10;
                }


                if (sum == number)
                {
                    Console.WriteLine(number);
                }

                number++;
            }
            //28.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();
            int vowelCount = 0;
            int consonantCount = 0;


            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelCount++;
                }

                else if (ch >= 'a' && ch <= 'z')
                {
                    consonantCount++;
                }
            }
            Console.WriteLine("Number of vowels: " + vowelCount);
            Console.WriteLine("Number of consonants: " + consonantCount);

            //29.

            int max, min;
            int number;

            Console.WriteLine("Enter 5 numbers:");


            Console.Write("Number 1: ");
            number = Convert.ToInt32(Console.ReadLine());
            max = number;
            min = number;


            for (int i = 1; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                number = Convert.ToInt32(Console.ReadLine());


                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"Maximum number: {max}");
            Console.WriteLine($"Minimum number: {min}");


            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine()); 
            int count = 0;

            
            if (number == 0)
            {
                count = 1; 
            }
            else
            {
                
                while (number != 0)
                {
                    number /= 10; 
                    count++; 
                }
            }

            Console.WriteLine("Number of digits: " + count);













            Console.ReadLine();

        }
    }
}
