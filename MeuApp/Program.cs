using System;

namespace MeuApp
{

    class Program
    {

        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse", 50.00,EProducType.Product);
            var manutencao = new Product(2,"Manutenção",100.00,EProducType.Service);

            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Type);

            Console.WriteLine(manutencao.Id);
            Console.WriteLine(manutencao.Name);
            Console.WriteLine(manutencao.Price);
            Console.WriteLine(manutencao.Type);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price,EProducType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;

        }
        public int Id;
        public string Name;
        public double Price;
        public EProducType Type;    

        public double PriceInDollar(double dolar)
        {
            return Price * dolar;
        }
        public double Desconto(double percentual)
        {
            return Price - (Price * percentual / 100.0);
        }
    }

    enum EProducType{
        Product = 1,
        Service = 2,
    }
}
