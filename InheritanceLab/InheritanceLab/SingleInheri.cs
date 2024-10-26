using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }
    }
    public class Student : Person
    {
        public string Grade {  get; set; }

        public Student(string name, int age,string grade) : base(name,age)
        {
            Grade = grade;

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}    Age {Age}  Grade{Grade}");

        }

    }

}
