using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_01_problem_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Batch Number?");
            double no = double.Parse(Console.ReadLine());

            Console.WriteLine("Your name is " + name + " and Your batch is " + no + ".");
            Console.ReadLine();
        }
    }
}
