using System;
using System.Linq;

namespace Question3Project
{
    class Program
    {
        static void PrintNthSmallest(int[] arr)
        {
            int first, second, arr_size = arr.Length;
            if (arr_size < 2)
            {
                Console.Write(" Invalid Input ");
                return;
            }
            first = second = int.MaxValue;

            for (int i = 0; i < arr_size; i++)
            {
                if (arr[i] < first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] < second && arr[i] != first)
                    second = arr[i];
            }
            Console.Write("\n The Nth smallest element is " + first +"\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**** Random Numbers ****");

            int Min = 0;
            int Max = 500;
            Random randNum = new Random();
            int[] RandomNumbers = Enumerable
                .Repeat(0, 500)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();

            for (int i = 0; i < RandomNumbers.Count(); i++)
            {
                Console.WriteLine(RandomNumbers[i]);
            }

            PrintNthSmallest(RandomNumbers);
        }
    }
}
