using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartialClass;
namespace PartialClass
{
    //7th partial class 
    public partial class Person
    {
        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name} called from outer/outside  class ");
        }
    }
    //8th overdiing partial methods here 
    public partial class Employee
    {
        
       partial void CalculateSalary()
        {
            int salary = TotalDays * PerDayRate;
            Console.WriteLine($"Salary for {Name}: {salary}");
        }
    }



    }
