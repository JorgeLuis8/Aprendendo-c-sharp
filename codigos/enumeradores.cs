using System;
namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var Mouse = new Product(1, "Mouse Gamer", 299.99, EProductType.Product);
            var limpeza = new Product(2, "Limpeza", 10.99, EProductType.Service);

            Console.WriteLine("Id do produto: " + Mouse.Id);
            Console.WriteLine("Nome do produto: " + Mouse.Name);
            Console.WriteLine("Preco do produto" + Mouse.Price);
            Console.WriteLine("Tipo do servico: " + Mouse.Type);
            Console.WriteLine("\n");
            Console.WriteLine("Id do produto: " + limpeza.Id);
            Console.WriteLine("Nome do produto: " + limpeza.Name);
            Console.WriteLine("Preco do produto" + limpeza.Price);
            Console.WriteLine("Tipo do servico: " + limpeza.Type);




        }

    }
    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;

        public EProductType Type;
        public double PriceInDollar(double dollar)
        {
            //Parametros em minusculo
            return Price * dollar;
        }
    }
    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}

