using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 11, 17, 15, 13, 9 };
            Console.WriteLine("Enter element to remove from array {11,17,15,17,9}:");

            int x = Convert.ToInt32(Console.ReadLine());

            var occurrences = FindOccurrences(numbers, x);

            int[] aux = new int[numbers.Length - occurrences];
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == x)
                {
                    continue;
                }

                aux[counter] = numbers[i];
                counter++;
            }

            WriteArray(aux);

            Console.ReadLine();
        }

        public static int FindOccurrences(int[] array, int value)
        {
            int counter = 0;
            foreach (var element in array)
            {
                if (element == value)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static void WriteArray(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + ",");
                }
            }
        }
    }
}
