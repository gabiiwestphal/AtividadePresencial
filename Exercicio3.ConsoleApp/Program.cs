using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a hora atual: ");
            int horaAtual = int.Parse(Console.ReadLine());

            if (horaAtual >= 6 && horaAtual <= 12)
            {
                Console.WriteLine("Bom dia!!!");
            }
            else if (horaAtual >= 13 && horaAtual < 18)
            {
                Console.WriteLine("Boa tarde!!!");
            }
            else if (horaAtual >= 18 && horaAtual <= 23 && horaAtual >= 0 && horaAtual <= 5)
            {
                Console.WriteLine("Boa noite!!!");
            }
        }
    }
}
