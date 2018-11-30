using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumberIfPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check if prime:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool is_prime = true;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0 && i != 1)
                {
                    Console.WriteLine("Number is not prime!");
                    is_prime = false;
                    break;
                }
            }

            if (number == 1)
            {
                Console.WriteLine("Number is not prime!");
            }
            else if (is_prime)
            {
                Console.WriteLine("Number is prime");
            }

            Console.ReadLine();
        }
    }
}
