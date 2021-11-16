using System;

namespace ForteGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            if(num != "quit")
            {
                try
                {
                    int n = int.Parse(num);
                    Console.WriteLine("It is " + (IsPrime(n) ? "a regular" : "not a") + " prime number");
                    if (IsMersenne(n)) Console.WriteLine("It is Mersenne prime number");
                    Main(args);
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                    Main(args);
                }
            }
        }
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }
        static bool IsMersenne(int n)
        {
            int i = 2;
            while (((1 << i) - 1) <= n) i++;

            if (((1 << i - 1) - 1) == n || ((1 << i - 1) + 1) == n)
                return true;
            return false;
        }
    }
}
