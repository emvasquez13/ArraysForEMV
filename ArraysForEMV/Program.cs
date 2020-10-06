//Author: Elliot Vasquez
//ISM 4220 Assignment: 3B Arrays
//Comment: This C# console will demonstrate the execution of an array of 25 elements without user input.

using System;

namespace ArraysForElliotV
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            foreach (var item in array)
            //Display the 25 elements on new lines
            {
                Console.WriteLine(item);
            }
        }
    }
}