using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab01_problem_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle :");
            double r = double.Parse(Console.ReadLine());
            double area;

            area = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("Area of the circle " + area);

            Console.ReadLine();
        }
    }
}
