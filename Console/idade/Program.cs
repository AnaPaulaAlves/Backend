using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("idade");

            Console.WriteLine("Bem vindo! Em que ano você nasceu?");
            int nascimento =  int.Parse(Console.ReadLine());

            Console.WriteLine("Em que anos estamos?");
            int ano = int.Parse(Console.ReadLine());

            int resultado =  ano - nascimento;
            Console.WriteLine("Sua idade é de " + resultado + " anos");

            int semanas = (nascimento * 365) / 7;
            Console.WriteLine("E sua idade convertida em semanas da um total de: " + semanas);
        }
    }
}
    
