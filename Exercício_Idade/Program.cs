using System;

namespace Exercício_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Idade \n");

            Console.WriteLine("Escreva sua idade");
            Console.ForegroundColor = ConsoleColor.Green;
            int idadeAnos = int.Parse(Console.ReadLine());

            int idadeMeses = idadeAnos * 12;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sua idade em meses é " + idadeMeses + "\n");

            int idadeDias = idadeMeses * 30;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sua idade em dias é " + idadeDias + "\n");

            int idadeHoras = idadeDias *24;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sua idade em horas é " + idadeHoras + "\n");

            int idadeMinutos = idadeHoras * 60;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Sua idade em minutos é " + idadeMinutos);
        }
    }
}
