﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LAB__04_PROBLEM_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues converter = new ConvertValues();

            Console.Write("Enter the value in kilometers (km): ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            converter.KilometerToMeter(kilometers);

            Console.ReadLine();
        }
    }
}
