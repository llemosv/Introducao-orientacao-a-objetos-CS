﻿using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.00, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
        }
    }
}

