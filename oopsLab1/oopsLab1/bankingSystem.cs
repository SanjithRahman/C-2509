using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    public class Account

    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        private double balance { get; set; }

        public Account(string accNum,string na,double bal)
        {
            AccountNumber = accNum;
            Name = na;
           balance=bal;

               
        }
        public double Balance
        {
            get { return balance; }
            set { 
                if(value < 0)
                {
                    Console.WriteLine("Balance cannot be less than zero");
                    balance = 0;

                }
                else
                {
                    balance = value;

                }
                
                 
            }


        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine($"{AccountNumber} deposited {amount}.New Balance {balance}");

        }
        public void Withdraw(double amount)
        {

            if(amount > balance)
            {
                Console.WriteLine($"Not enough balance");

            }
            else
            {
                balance = balance - amount;
                Console.WriteLine($"{AccountNumber} withdraw {amount}.New balance is {balance}");

            }
        }





    }
}
