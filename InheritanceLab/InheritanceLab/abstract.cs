using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    abstract class Vehicle2
    {
        public abstract void Drive();

    }

    class Car : Vehicle2
    {
        public override void Drive()
        {
            Console.WriteLine("Driving car");
        }
    }

    class Bike : Vehicle2
    {
        public override void Drive()
        {
            Console.WriteLine("Riding bike");
        }
    }

    sealed class SealedClass
    {
        public void SealedMethod()
        {
            Console.WriteLine("The sealed method is invoked");
        }
    }
    //// attempting to inherit from a sealed class
    //class Trees : SealedClass
    //{
    //    public void TreesMethod()
    //    {
    //        Console.WriteLine("The Trees Method has been invoked");
    //    }
    //}

    public class Person2
    {
        
        public string Name;
        public int Age;

        
        public Person2(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Person Created: Name = {Name}, Age = {Age}");
        }
    }

    
    class Employeee : Person2
    {
        
        public string Department;

       
        public Employeee(string name, int age, string department) : base(name, age)
        {
            Department = department;
            Console.WriteLine($"Employee Created: Name = {Name}, Age = {Age}, Department = {Department}");
        }
    }



}
