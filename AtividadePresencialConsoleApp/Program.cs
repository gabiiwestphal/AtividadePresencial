using System;

namespace AtividadePresencialConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura = 50;
            int altura = 10;
            string asterisco = "";

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    asterisco = asterisco + "*";
                }
                asterisco += "\n";
            }
            Console.WriteLine(asterisco);
        }
    }
}
