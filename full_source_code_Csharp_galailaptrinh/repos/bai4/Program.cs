﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            x = 9;
            y = 4;
            Console.WriteLine("x = " +x);

            x %= y; // x = x%y;
            Console.WriteLine("x = " + x);
            Console.ReadKey();
        }
    }
}
