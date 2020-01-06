using System;

namespace Fibo
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Fibofolge von 5: " );
            Fiborecursive(5);
            Console.ReadKey(true);
        }

        private static long Fiborecursive(int n)
        {
            int a = 0;
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                Console.WriteLine(n);
                return Fiborecursive(n - 1) + Fiborecursive(n - 2);
            }

        }
    }
}
