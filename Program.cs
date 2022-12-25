using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace broject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int S;
            int R;
            bool isPrime;

            do
            {
                Console.Write("Enter start number: ");
                S = int.Parse(Console.ReadLine());

                Console.Write("Enter range number: ");
                R = int.Parse(Console.ReadLine());
            }
            while (R <= 1&&S>=2);
            Console.WriteLine("All prime numbers between "+S+ " and " + R + ": ");
            for (int p = S; p <= R; p++)
            {
                isPrime = true;
                for (int k = 2; k <= p / 2; k++)
                {
                    if (p % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(p + " ");
                }
            }
        }   
    }
}
