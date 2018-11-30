using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 11, 17, 15, 13, 9 };
            int[] arr2 = new int[7] { 9, 44, 17, 5, 11, 14, 13 };
            Console.WriteLine("Array 1: {11,17,15,13,9}");
            Console.WriteLine("Array 2: {9,44,17,5,11,14,13}");

            string list = "Common elements are=";

            for (int i = 0; i <= arr1.Length - 1; i++)
            {
                for (int j = 0; j <= arr2.Length - 1; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        list = list + Convert.ToInt32(arr1[i]) + ",";
                    }
                }
            }

            Console.WriteLine(list.Substring(0, list.Length - 1));

            Console.ReadLine();
        }
    }
}
