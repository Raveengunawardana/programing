﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LAB_04_PROBLEM_1
{
    internal class ConvertValues
    {
        public void kilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000;
            Console.WriteLine("{0} kilometers is equal to {1} meters.", kilometers, meters);
            Console.ReadKey();
        }
    }
}
