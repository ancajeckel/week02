using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word to check if it's a palindrome:");
            var str = Console.ReadLine();

            var arr = str.ToCharArray();
            bool is_palindrome = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[arr.Length - i - 1])
                {
                    continue;
                }
                is_palindrome = false;
            }

            Console.WriteLine( (is_palindrome)
                ? "Word is a palindrome"
                : "Word is not a palindrome");

            Console.ReadLine();
        }
    }
}
