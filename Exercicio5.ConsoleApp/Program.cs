using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_jogador1, numero_jogador2, contVitoriasJogador1 = 0, contVitoriasJogador2 = 0;

            Console.WriteLine("Nome do primeiro jogador: ");
            string jogador1 = Console.ReadLine();

            Console.WriteLine("Nome do segundo jogador: ");
            string jogador2 = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("\r\n" + i + "ª Rodada: ");

                do
                {
                    Console.Write(jogador1 + ": ");
                    numero_jogador1 = int.Parse(Console.ReadLine());
                } while (numero_jogador1 > 6);

                do
                {
                    Console.Write(jogador2 + ": ");
                    numero_jogador2 = int.Parse(Console.ReadLine());
                } while (numero_jogador2 > 6);

                if (numero_jogador1 > numero_jogador2)
                {
                    Console.WriteLine("O jogador " + jogador1 + " jogou " + numero_jogador1 + " e venceu a " + i + "ª Rodada!");
                    contVitoriasJogador1++;
                }
                else if (numero_jogador1 < numero_jogador2)
                {
                    Console.WriteLine("O jogador " + jogador2 + " jogou " + numero_jogador2 + " e venceu a " + i + "ª Rodada!");
                    contVitoriasJogador2++;
                }
                else if (numero_jogador1 == numero_jogador2)
                {
                    Console.WriteLine("\r\nHouve um empate definitivo, tentem novamente!");
                    do
                    {
                        Console.Write(jogador1 + ": ");
                        numero_jogador1 = int.Parse(Console.ReadLine());
                    } while (numero_jogador1 > 6);

                    do
                    {
                        Console.Write(jogador2 + ": ");
                        numero_jogador2 = int.Parse(Console.ReadLine());
                    } while (numero_jogador2 > 6);

                    if (numero_jogador1 > numero_jogador2)
                    {
                        Console.WriteLine("O jogador " + jogador1 + " jogou " + numero_jogador1 + " e venceu a " + i + "ª Rodada!");
                        contVitoriasJogador1++;
                    }
                    else if (numero_jogador1 < numero_jogador2)
                    {
                        Console.WriteLine("O jogador " + jogador2 + " jogou " + numero_jogador2 + " e venceu a " + i + "ª Rodada!");
                        contVitoriasJogador2++;
                    }
                }
            }

            if (contVitoriasJogador1 > contVitoriasJogador2)
            {
                Console.WriteLine("\r\nParabéns " + jogador1 + " você ganhou o jogo!");
            }
            else if (contVitoriasJogador1 < contVitoriasJogador2)
            {
                Console.WriteLine("\r\nParabéns " + jogador2 + " você ganhou o jogo!");
            }
        }
    }
}
