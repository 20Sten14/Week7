﻿using System;

namespace cakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string cake = "The c4ke i3 4 lie";

            cake = cake.Replace('1', 'i');
            cake = cake.Replace('3', 's');
            cake = cake.Replace('4', 'a');

            Console.WriteLine(cake);
        }
    }
}
