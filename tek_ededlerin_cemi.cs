using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 4, 4, 5, 6, 7, 8, 9, 10 };
            int cem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    cem += a[i];

                    Console.Write("+" + a[i]);
                }
            }
            Console.WriteLine("=" + cem);
        }
    }
}
