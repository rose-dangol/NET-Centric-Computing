using System;

namespace BubbleSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];
            
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort sorter = new BubbleSort();

            Console.WriteLine("\nOriginal array:");
            sorter.DisplayArray(numbers);

            sorter.Sort(numbers);

            Console.WriteLine("\nSorted array:");
            sorter.DisplayArray(numbers);
        }
    }
}
