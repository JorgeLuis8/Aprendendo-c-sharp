using System;

namespace MeuApp
{

    class Program
    {

        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse", 50.00);
            var notebook = new Product(2, "Note book", 1500.00);

            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.PriceInDollar(5.00));

            Console.WriteLine(notebook.Id);
            Console.WriteLine(notebook.Name);
            Console.WriteLine(notebook.Price);
            Console.WriteLine(notebook.Desconto(10.0));

        }
    }

    struct Product
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;

        }
        public int Id;
        public string Name;
        public double Price;

        public double PriceInDollar(double dolar)
        {
            return Price * dolar;
        }
        public double Desconto(double percentual)
        {
            return Price - (Price * percentual / 100.0);
        }
    }
}
