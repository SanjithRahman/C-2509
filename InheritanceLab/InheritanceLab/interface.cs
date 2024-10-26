using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public interface IPrintable
    {
        void Print();
    }
    public interface IScannable
    {
        void Scan();
    }
    public class PrinterScanner:IPrintable,IScannable
    {
        public void Print()
        {
            Console.WriteLine("Print  document...");
        }
        public void Scan()
        {
            Console.WriteLine("Scan  document...");
        }
    }

    //virtual and ovveride example......
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw a shape...");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle...");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }

    //

    public interface IMovable
    {
        void Move();
    }
    public interface IRechargeable
    {
        void Recharge();
    }
    public class Vehicle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The vehicle moves");
        }
    }
    public class ElectricCar : Vehicle, IRechargeable
    {
        public void Recharge()
        {
            Console.WriteLine("electric car recharges..");
        }
    }

    public class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee  works...");
        }

    }
    public class Manager : Employee
    {
       
        public override void Work()
        {
            Console.WriteLine("Manager manages.");
        }
    }









}
