using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
     class Bank
    {
        private static double interestRate;
        private double balance;
        static Bank()
        {
            interestRate = 2.5;
            Console.WriteLine("static consructor called");

        }
        public Bank(double initialBalance)
        {
            balance = initialBalance;
            Console.WriteLine($"Instance constructor called balance {balance}");

        }


    }

    public class Car
    {
        static int count1;
        static Car()
        {
            count1 = 0;
            Console.WriteLine(" static Instance created ");

        }
        public Car()
        {
            count1++;
            Console.WriteLine("Instance created " + count1);
            
        }

    }

    class MathOperations
    {
        static double pi;
        static MathOperations()
        {
            pi = 3.14;
            Console.WriteLine("static constructor  of  pi intialized");
        }
        public static void CalcArea(double rad)
        {
            Console.WriteLine($"Area is {pi * rad * rad}");
        }
        

     }
        
        

     

    class SystemConfig
    {
        public static string AppName;
        public static string Version;
        public string Os;
        public int Ram;
        static SystemConfig()
        {
            AppName = "Google pixel camera";
            Version = "14.0.1";



        }
        public SystemConfig(string os, int ram)
        {
            Os = os;
            Ram = ram;
            Console.WriteLine("Operating system   " + os + "   ram  " + ram);
        }
    }
    
}
