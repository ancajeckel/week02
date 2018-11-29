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
            int[] arr = new int[5] { 11, 17, 15, 13, 9 };
            int value = 2;
            int index = 3;

            int[] newArray = new int[arr.Length + 1];

            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = value;
                    counter++;
                }
                else
                {
                    newArray[i] = arr[i - counter];
                }

            }

            WriteArray(newArray);
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
