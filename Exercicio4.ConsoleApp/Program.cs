using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[5];
            int media;
            int  soma = 0, contPositivos = 0, contNegativos = 0;

            Console.WriteLine(" insira 5 valores: ");

            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numero[i] = num;
                soma += numero[i];
                if (numero[i] > 0)
                {
                    contPositivos++;
                }
                else
                {
                    contNegativos++;
                }
            }
            media = soma / 5;
            Console.WriteLine($"A Média Aritmética: {media}\nA Quantidade de valores positivos é: {contPositivos}\nA Quantidade de valores negativos é: {contNegativos}");
            Console.ReadLine();
        }
    }
}
