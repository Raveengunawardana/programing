using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LAB_04_PROBLEM_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues convertValues = new ConvertValues();
            Console.WriteLine("Enter the value in kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            convertValues.kilometerToMeter(kilometers);
        }
    }
}
