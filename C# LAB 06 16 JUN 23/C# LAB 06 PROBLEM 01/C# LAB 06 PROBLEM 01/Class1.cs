using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LAB_06_PROBLEM_01
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter the size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());

            ArrayOperations.CreateArray(size);
        }
    }
}
