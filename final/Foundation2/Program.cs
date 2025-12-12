using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Customer name:");
        string name = Console.ReadLine();

        Console.WriteLine("Street address:");
        string street = Console.ReadLine();

        Console.WriteLine("City:");
        string city = Console.ReadLine();

        Console.WriteLine("State/Province:");
        string state = Console.ReadLine();

        Console.WriteLine("Country:");
        string country = Console.ReadLine();

        Address address = new Address(street, city, state, country);
        Customer customer = new Customer(name, address);

        Order order = new Order(customer);

        Console.WriteLine("How many products do you want to add?");
        int amount = int.Parse(Console.ReadLine());

        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine($"Product {i + 1} name:");
            string productName = Console.ReadLine();

            Console.WriteLine("Product ID:");
            string id = Console.ReadLine();

            Console.WriteLine("Price per unit:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantity:");
            int quantity = int.Parse(Console.ReadLine());

            order.AddProduct(new Product(productName, id, price, quantity));
        }

        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice()}");
    }
}
