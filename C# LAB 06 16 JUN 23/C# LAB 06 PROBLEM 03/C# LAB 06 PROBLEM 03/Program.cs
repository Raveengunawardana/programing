using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LAB_06_PROBLEM_03
{
    internal class Animal
    {
        public void Animal()
        {
            Console.WriteLine("I am an animal");
        }
    }
    class Dog : Animal
    {
        public void Dog()
        {
            Console.WriteLine("I have four legs");
        }
    }
}
