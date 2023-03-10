using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double[] a = { 1,1,4,10,9 };
            double cem = 0;
            double edediorta = 0;
            for (int i = 0; i <a.Length; i++)
            {
                cem = cem + a[i];
                edediorta = cem / a.Length;
            }
            Console.WriteLine("umumi cem: " + cem);
            Console.WriteLine("ededi orta: " + edediorta);
        }
    }
}
