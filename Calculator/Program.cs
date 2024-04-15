using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();
            Menu();
            
            
        }
        static float soma()
        {
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            return valor1 + valor2;
        }
        
        static float subtracao(){
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            return valor1 - valor2;
        }
        static float multiplicacao(){
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            return valor1 * valor2;
        }
        static float divisao(){
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            return valor1 / valor2;
        }
        static void Menu(){
            
            Console.WriteLine("Escolha a operação: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int opcao = int.Parse(Console.ReadLine());
            switch(opcao){
                case 1:
                    Console.WriteLine($"Resultado: {soma()}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {subtracao()}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {multiplicacao()}");
                    break;
                case 4:
                    Console.WriteLine($"Resultado: {divisao()}");
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Menu();
                    break;
            }
        }
    }

  

}