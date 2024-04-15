using System;
namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mouse = new Product(1, "Mouse Gamer", 299.99);
            Mouse.Id = 55;
            Console.WriteLine(Mouse.Id);
            Console.WriteLine(Mouse.Name);
            Console.WriteLine(Mouse.Price);

        }

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

    public double PriceInDollar(double dollar)
    {
        //Parametros em minusculo
        return Price * dollar;
    }
}