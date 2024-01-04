﻿namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of long: {0}", sizeof(long));
            Console.WriteLine("Size of double: {0}", sizeof(double));
            Console.WriteLine("Size of float: {0}", sizeof(float));
            Console.WriteLine("Size of decimal: {0}", sizeof(decimal));
            Console.WriteLine("Size of boolean: {0}", sizeof(bool));
            Console.WriteLine("Size of char: {0}", sizeof(char));
            Console.WriteLine("Size of byte: {0}", sizeof(byte));
            Console.ReadLine();
            // decimal is greatest size
        }
    }
}
