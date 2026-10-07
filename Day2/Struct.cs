
using System;

struct Product
{
    public int Id;
    public double Price;
    public int Quantity;

    public void Display()
    {
        Console.WriteLine("Product ID: " + Id);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Total: " + (Price * Quantity));
    }
}

class Program
{
    static void Main()
    {
        Product p1;

        p1.Id = 101;
        p1.Price = 500;
        p1.Quantity = 3;

        p1.Display();
    }
}
