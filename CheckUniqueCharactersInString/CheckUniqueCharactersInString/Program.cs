using System;

namespace CheckUniqueCharactersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            var str = Console.ReadLine();

            var arr = str.ToCharArray();
            var list = "";
            bool has_unique = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (list.Contains(arr[i]))
                {
                    Console.WriteLine("String has repeating characters!");
                    has_unique = false;
                    break;
                }
                list = list + arr[i];
            }

            if (has_unique)
            {
                Console.WriteLine("String has only unique characters");
            }

            Console.ReadLine();
        }
    }
}
