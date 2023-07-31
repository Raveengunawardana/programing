using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_02_problem_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the any number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("That number is even numbre");
            }
            else
            {
                Console.WriteLine(" That number is odd number");
            }

            Console.ReadLine();
        }
    }
}
