using System;

namespace Exercício_Data_Nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Nascimento");

            Console.WriteLine("Escreva seu ano de nascimento");
            Console.ForegroundColor = ConsoleColor.Red;
            int dataNascimento = int.Parse(Console.ReadLine());
            
            int idadeAnos = 2021 - dataNascimento;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Sua idade é " + idadeAnos +" anos \n");

            int idadeMeses = idadeAnos * 12;

            int idadeSemanas = idadeMeses * 4;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Sua idade em semanas é " + idadeSemanas + "\n");

        }
    }
}
