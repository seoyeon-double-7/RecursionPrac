﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            Console.WriteLine(fibo.Get(1));
            Console.WriteLine(fibo.Get(2));
            Console.WriteLine(fibo.Get(3));
            Console.WriteLine(fibo.Get(4));
            Console.WriteLine(fibo.Get(5));

        }
    }
}
