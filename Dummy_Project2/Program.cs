class Test
{
   public static void Main()
    {
        Shopkeeper_h shopkeeper = new Shopkeeper_h();

        shopkeeper.AddProduct(
            new Product_hash(101, "Laptop", 55000));

        shopkeeper.AddProduct(
            new Product_hash(102, "Mouse", 800));

        shopkeeper.AddProduct(
            new Product_hash(103, "Keyboard", 1500));

        shopkeeper.AddProduct(
            new Product_hash(104, "Monitor", 12000));

        Console.WriteLine("\nAll Products:");
        shopkeeper.ShowProducts();

        Console.WriteLine("\nSearch Product:");
        shopkeeper.SearchProduct(102);

        Console.WriteLine("\nUpdate Product:");
        shopkeeper.UpdateProduct(102, "Wireless Mouse", 1200);

        Console.WriteLine("\nDelete Product:");
        shopkeeper.DeleteProduct(103);

        Console.WriteLine("\nFinal Product List:");
        shopkeeper.ShowProducts();
    }
}



