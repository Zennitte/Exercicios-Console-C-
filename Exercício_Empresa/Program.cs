using System;

namespace Exercício_Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elegibilidade do Aumento \n");

            Console.WriteLine("Digite seu salário");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double salarioPercentual = 0.3;
            double salarioAumento = salario + (salarioPercentual * salario) ;

            if (salario < 500){

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Você está elegivel para um aumento, seu novo salário é " + salarioAumento);
                
            } else{
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Você não é elegivel para um aumento");
            }
        }
    }
}
