using System;

namespace Transito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Semaforo cor");
            string Semaforo = (Console.ReadLine());

            if(Semaforo == "green"){
                Console.WriteLine("semaforo verde anda");
            }else if(Semaforo == "wellow"){
                Console.WriteLine("Diminua a velocidade do veiculos");
            }else if(Semaforo == "red"){
                Console.WriteLine("Pare o veiculo");
            
            }    
            
            }
    }
}
     
