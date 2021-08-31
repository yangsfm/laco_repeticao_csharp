using System;

namespace Decrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("\n Digite o 1° valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("\n Digite o 2° valor: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("\n Números ímpares entre {0} e {1}: ", n1, n2);
                for (var x = n1; x >= n2; x--)
                {
                    if (x % 2 != 0)
                    {
                        Console.Write(" {0} \n", x);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
