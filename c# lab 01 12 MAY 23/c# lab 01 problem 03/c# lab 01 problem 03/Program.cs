using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_01_problem_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double sum;

            sum = num1 * num2;

            Console.WriteLine("summation is " + sum);
        }
    }
}
