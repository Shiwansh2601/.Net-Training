
using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}



/* class Program
{
   public static void Main()
    {
        // Customer's shopping cart
        List<Product> cart = new List<Product>
        {
            new Product { Name = "Laptop", Price = 60000 },
            new Product { Name = "Mouse", Price = 800 },
            new Product { Name = "Keyboard", Price = 2500 },
            new Product { Name = "Headphones", Price = 4000 },
            new Product { Name = "Monitor", Price = 15000 }
        };

        // 1. PREDICATE: Check whether a product is eligible
        Predicate<Product> isExpensive =
            product => product.Price >= 5000;

        Console.WriteLine("Expensive Products:");

        List<Product> expensiveProducts =
            cart.FindAll(isExpensive);

        foreach (Product product in expensiveProducts)
        {
            Console.WriteLine(
                $"{product.Name} - ₹{product.Price}");
        }

        // 2. FUNC: Calculate discounted price
        Func<Product, decimal> calculateDiscount =
            product => product.Price * 0.10m;

        Console.WriteLine("\nDiscounted Prices:");

        foreach (Product product in cart)
        {
            decimal discount = calculateDiscount(product);
            decimal finalPrice = product.Price - discount;

            Console.WriteLine(
                $"{product.Name}: ₹{finalPrice}");
        }

        // 3. ACTION: Display order confirmation
        Action<string> sendNotification =
            message => Console.WriteLine(message);

        Console.WriteLine("\nOrder Confirmation:");

        sendNotification(
            "Your order has been placed successfully!");

        
    }
}
 */