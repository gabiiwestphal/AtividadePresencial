using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura = 50, altura = 10;

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("A");
                    }
                    else
                    {
                        Console.Write("B");
                    }
                }
                Console.Write("\n");

            }
            Console.ReadLine();
        }
    }
}
