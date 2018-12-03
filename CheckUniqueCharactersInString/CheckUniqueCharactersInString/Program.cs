using System;

namespace CheckUniqueCharactersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            var str = Console.ReadLine();

            var list = "";
            bool has_unique = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (list.Contains(str.Substring(i,1)))
                {
                    Console.WriteLine("String has repeating characters!");
                    has_unique = false;
                    break;
                }
                list = list + str.Substring(i, 1);
            }

            if (has_unique)
            {
                Console.WriteLine("String has only unique characters");
            }

            Console.ReadLine();
        }
    }
}
