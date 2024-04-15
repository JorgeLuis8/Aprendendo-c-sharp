using System;
using System.Threading;

namespace Stopwatch {
    class Program
    {
        static void Main(string[] args)
        {  
            Console.Clear();
            Menu();

        }

        static  void Start(int time){
    
            int currentTime = 0;

            while(time != currentTime){
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                System.Threading.Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado... retornando para o menu");
            Thread.Sleep(1500);
            Menu();
        }
        static void Prestart(int time){
            Console.Clear();
            Console.WriteLine("Stopwatch iniciado...");
            Thread.Sleep(1500);
            Start(time);
        }
        static void Menu(){
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0s = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;
            if(type == 'm')
                multiplier = 60;
            
            if(time == 0)    
                System.Environment.Exit(0);
            Prestart(time * multiplier);


            
            
        }
    }
}