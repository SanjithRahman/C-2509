using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    public class BankDetails
    {
        public class Account
        {
            public string AccountNumber { get; set; }
            public double Balance { get; set; }

            public Account(string accNo, double bal)
            {
                AccountNumber = accNo;
                Balance = bal;

            }
        }
        public class Customer
        {
            public string Name { get; set; }
            public List<Account> Accounts { get; set; }

            public Customer(string name)
            {
                Name = name;
                Accounts = new List<Account>();
            }

        }
        public List<Customer> customers = new List<Customer>();
        public void AddCustomer(string name)
        {
            Customer customer = new Customer(name);
            customers.Add(customer);
        }
        public void AddAccount(string na, string AccNo, double bal)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Name == na)
                {
                    Account acc = new Account(AccNo, bal);
                    customer.Accounts.Add(acc);

                }

            }
        }
        public void DisplayDetails()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(" ");
                foreach (Account acc in customer.Accounts)
                {
                    Console.WriteLine($"AccNo {acc.AccountNumber} bal:     {acc.Balance}");
                }
            }
        }




    }
}
