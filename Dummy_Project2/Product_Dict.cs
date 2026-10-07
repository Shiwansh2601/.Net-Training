
using System;
using System.Collections.Generic;

public class Product_dict
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }

    public Product_dict(int id, string name, double price)
    {
        ProductId = id;
        ProductName = name;
        ProductPrice = price;
    }
}

public class Shopkeeper_d
{
    // ProductId = Key, Product = Value
    private  Dictionary<int, Product_dict> products = new();

    // Add Product
    public void AddProduct(Product_dict product)
    {
        if (products.ContainsKey(product.ProductId))
        {
            Console.WriteLine("Product ID already exists.");
            return;
        }

        products.Add(product.ProductId, product);
        Console.WriteLine("Product added successfully.");
    }

    // Search Product
    public void SearchProduct(int id)
    {
        if (!products.TryGetValue(id, out Product_dict? product))
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.WriteLine(
            $"ID: {product.ProductId}, " +
            $"Name: {product.ProductName}, " +
            $"Price: ₹{product.ProductPrice}"
        );
    }

    // Update Product
    public void UpdateProduct(int id, string newName, double newPrice)
    {
        if (!products.TryGetValue(id, out Product_dict? product))
        {
            Console.WriteLine("Product not found.");
            return;
        }

        product.ProductName = newName;
        product.ProductPrice = newPrice;

        Console.WriteLine("Product updated successfully.");
    }

    // Delete Product
    public void DeleteProduct(int id)
    {
        if (!products.Remove(id))
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.WriteLine("Product deleted successfully.");
    }

    // Show All Products
    public void ShowProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        foreach (Product_dict product in products.Values)
        {
            Console.WriteLine(
                $"ID: {product.ProductId}, " +
                $"Name: {product.ProductName}, " +
                $"Price: ₹{product.ProductPrice}"
            );
        }
    }

   
}
