using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classificador de Categoria \n");
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Escreva sua idade");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            int idadeNadador = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (idadeNadador >= 5 && idadeNadador <= 7){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sua categoria é infantil A");
            } if (idadeNadador >= 8 && idadeNadador <= 10){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sua categoria é infantil B");
            } if (idadeNadador >= 11 && idadeNadador <= 13 ){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sua categoria é juvenil A");
            } if (idadeNadador >= 14 && idadeNadador <= 17){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sua categoria é juvenil B");
            } if (idadeNadador >= 18){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sua categoria é senior");
            }
        }
    }
}
