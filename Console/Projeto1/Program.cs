using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero:");
            string num1_texto = Console.ReadLine();
            int num1 = int.Parse(num1_texto);

            Console.Write("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.Write("O resultato do " +num1+ "+" +num2+ "é:" +soma);
            
        }
    }
}
