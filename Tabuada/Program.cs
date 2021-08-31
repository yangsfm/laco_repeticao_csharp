using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            Console.Write("\n Digite um valor para calcular a tabuada: ");
            tabuada = int.Parse(Console.ReadLine());

            for (int x = 1; x <= 10; x = x + 1)
            {
                Console.WriteLine("\n {0} * {1} = {2}", tabuada, x, (tabuada * x));
            }
            Console.ReadKey();
        }
    }
}
