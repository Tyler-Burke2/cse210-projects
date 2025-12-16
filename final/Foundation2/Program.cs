using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ONLINE STORE ORDER SYSTEM ===\n");

        List<Product> inventory = new List<Product>
        {
            new Product("Laptop", "TECH-001", 999.99, 10),
            new Product("Wireless Mouse", "TECH-002", 29.99, 50),
            new Product("Keyboard", "TECH-003", 79.99, 25),
            new Product("Monitor", "TECH-004", 299.99, 15),
            new Product("USB Cable", "TECH-005", 9.99, 100)
        };

        Console.WriteLine("Available Products:");
        foreach (Product p in inventory)
        {
            Console.WriteLine($"   {p.GetName()} (ID: {p.GetId()}) - ${p.GetPrice():0.00} [Stock: {p.GetQuantity()}]");
        }
        Console.WriteLine();

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "TECH-001", 999.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "TECH-002", 29.99, 2));

        Console.WriteLine("=================================");
        Console.WriteLine("ORDER #1");
        Console.WriteLine("=================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotal():0.00}");
        Console.WriteLine("   (Includes $5.00 USA shipping)");
        Console.WriteLine();

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "TECH-004", 299.99, 1));
        order2.AddProduct(new Product("Keyboard", "TECH-003", 79.99, 1));
        order2.AddProduct(new Product("USB Cable", "TECH-005", 9.99, 3));

        Console.WriteLine("=================================");
        Console.WriteLine("ORDER #2");
        Console.WriteLine("=================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotal():0.00}");
        Console.WriteLine("   (Includes $35.00 international shipping)");
        Console.WriteLine();

        Console.WriteLine("=================================");
        Console.WriteLine("INVENTORY UPDATE SIMULATION");
        Console.WriteLine("=================================");
        
        Console.WriteLine("\nUpdating inventory after sales...\n");
        
        inventory[0].SetQuantity(inventory[0].GetQuantity() - 1); 
        inventory[1].SetQuantity(inventory[1].GetQuantity() - 2);
        inventory[3].SetQuantity(inventory[3].GetQuantity() - 1); 
        inventory[2].SetQuantity(inventory[2].GetQuantity() - 1); 
        inventory[4].SetQuantity(inventory[4].GetQuantity() - 3); 

        Console.WriteLine("Updated Inventory:");
        foreach (Product p in inventory)
        {
            Console.WriteLine($"   {p.GetName()} (ID: {p.GetId()}) - ${p.GetPrice():0.00} [Stock: {p.GetQuantity()}]");
        }

        Console.WriteLine("\nInventory successfully updated!");
    }
}