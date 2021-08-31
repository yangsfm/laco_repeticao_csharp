using System;

namespace Crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            for (p = 11; p <= 250; p++)
            {
                if (p % 2 != 0)
                {
                    p++;
                }
                Console.Write("\n Pares: {0}", p);
            }
            Console.ReadKey();
        }
    }
}
