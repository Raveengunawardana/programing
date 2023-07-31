using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_03_problem_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("That number is even number");
            }
            else
            {
                Console.WriteLine("That number is odd number");
            }

            Console.ReadLine();
        }

    }
}
