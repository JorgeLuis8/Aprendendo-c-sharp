using System;

namespace MeuApp
{

    class Program
    {

        static void Main(string[] args)
        {
            var limpeza = new Product(1,"Limpeza de pc",132.99,EProductType.Service);
            var mouse = new Product(2,"Mouse",50.00,EProductType.Product);

            Console.WriteLine(limpeza.Name);
            Console.WriteLine(limpeza.Price);
            Console.WriteLine(limpeza.Id);
            Console.WriteLine(limpeza.Type);
            Console.WriteLine(limpeza.PriceInDollar(5.00));
        }
    }
    struct Product{
        public Product(int id, string name,double price, EProductType type){
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDollar(double dollar){
            return Price * dollar;
        }
    }
    enum EProductType{
        Product = 1,
        Service = 2,
    
    }
}
