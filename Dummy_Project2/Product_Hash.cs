
using System;
using System.Collections.Generic;

public class Product_hash
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }

    public Product_hash(int id, string name, double price)
    {
        ProductId = id;
        ProductName = name;
        ProductPrice = price;
    }
}

public class Shopkeeper_h
{
    // HashSet to store products
    private HashSet<Product_hash> products = new();

    // Add Product
    public void AddProduct(Product_hash product)
    {
        products.Add(product);
        Console.WriteLine("Product added successfully.");
    }

    // Search Product
    public void SearchProduct(int id)
    {
        foreach (Product_hash product in products)
        {
            if (product.ProductId == id)
            {
                Console.WriteLine(
                    $"ID: {product.ProductId}, " +
                    $"Name: {product.ProductName}, " +
                    $"Price: ₹{product.ProductPrice}"
                );
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }

    // Update Product
    public void UpdateProduct(int id, string newName, double newPrice)
    {
        foreach (Product_hash product in products)
        {
            if (product.ProductId == id)
            {
                product.ProductName = newName;
                product.ProductPrice = newPrice;

                Console.WriteLine("Product updated successfully.");
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }

    // Delete Product
    public void DeleteProduct(int id)
    {
        foreach (Product_hash product in products)
        {
            if (product.ProductId == id)
            {
                products.Remove(product);

                Console.WriteLine("Product deleted successfully.");
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }

    // Show All Products
    public void ShowProducts()
    {
        foreach (Product_hash product in products)
        {
            Console.WriteLine(
                $"ID: {product.ProductId}, " +
                $"Name: {product.ProductName}, " +
                $"Price: ₹{product.ProductPrice}"
            );
        }
    }

   
}
