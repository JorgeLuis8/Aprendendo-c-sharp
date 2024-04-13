using System;
using System.Runtime.InteropServices;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {

            MeuMetodo();
            Console.WriteLine(Fat(5));
            Console.WriteLine(Nome("Jorginho", "Luis"));
            Console.WriteLine(soma(2, 3));
        }
        static void MeuMetodo()
        {
            Console.WriteLine("Meu metodo");
            //output: Meu metodo
        }
        static int Fat(int n)
        {
            var fat = 1;
            if (n > 1)
            {
                fat = n * Fat(n - 1);
            }
            return fat;
            //output: 120
        }
        static string Nome(string nome, string sobrenome)
        {
            int idade = 20;
            return nome + " " + sobrenome + " tem " + idade.ToString() + " anos";
            //output: Jorginho Silva
        }
        static int soma(int a, int b)
        {
            return a + b;
            //output: 5
        }
    }
}

