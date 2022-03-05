using SortingAlgorithms.Sorters;
using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 7, 8, 4, 2, 11, 44, 55, 66, 7, 5, 44, 3, 23 };
            int[] orderedArray = array;
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("> Array: " + string.Join(", ", array));
                Console.WriteLine("\n1 - Order with QuickSort");
                Console.Write("\n> ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        orderedArray = array;
                        orderedArray.OrderUsingQuickSort();
                        Console.WriteLine("\n>  Ordered Array: " + string.Join(", ", orderedArray));
                        Console.ReadKey();
                        break;

                    default:
                        continue;
                }
            }
        }
    }
}
