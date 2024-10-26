using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    public  class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal eats");
        }
    }
    public class Dog:Animal
    {
       
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }

    }
    
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Puppy weeps");
        }
    }


}
