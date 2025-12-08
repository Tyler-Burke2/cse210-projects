using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr = new Address("120 Main St", "Rexburg", "Idaho", "USA");
        Customer customer = new Customer("Tyler Burke", addr);

        Order order = new Order(customer);

        order.AddProduct(new Product("USB Cable", "U102", 5.99, 3));
        order.AddProduct(new Product("Laptop Stand", "L884", 32.50, 1));

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice()}");
    }
}
