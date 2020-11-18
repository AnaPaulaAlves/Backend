using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
     
     {
         Console.Write("Você gostaria de receber bom dia?");
         string resposta = Console.ReadLine();

            while(resposta == "sim"){ // true quando a condição for verdade
            Console.WriteLine("Bom dia");

            Console.WriteLine("Você ainda deseja receber um bom dia?");
            resposta = Console.ReadLine();

            Console.WriteLine("fim");

            }
        }
    }
}
