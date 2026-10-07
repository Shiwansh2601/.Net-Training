
using System;
using System.Collections.Generic;

public class ProductList
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }

    public ProductList(int id, string name, double price)
    {
        ProductId = id;
        ProductName = name;
        ProductPrice = price;
    }
}

public class Shopkeeper
{
    private  List<ProductList> products = new();

    // Add Product
    public void AddProduct(ProductList product)
    {
        products.Add(product);
    }

    // Search Product
    public void SearchProduct(int id)
    {
        ProductList? product = products.Find(p => p.ProductId == id);

        if (product == null)
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
        ProductList? product = products.Find(p => p.ProductId == id);

        if (product == null)
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
        ProductList? product = products.Find(p => p.ProductId == id);

        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        products.Remove(product);

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

        foreach (ProductList product in products)
        {
            Console.WriteLine(
                $"ID: {product.ProductId}, " +
                $"Name: {product.ProductName}, " +
                $"Price: ₹{product.ProductPrice}"
            );
        }
    }

}
