using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        Console.WriteLine("How many products do you want to enter?");
        int productCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < productCount; i++)
        {
            Console.WriteLine($"Product {i + 1} name:");
            string name = Console.ReadLine();

            Console.WriteLine("Product ID:");
            string id = Console.ReadLine();

            Console.WriteLine("Price:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantity in stock:");
            int qty = int.Parse(Console.ReadLine());

            products.Add(new Product(name, id, price, qty));
        }

        Console.WriteLine("Customer name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Street address:");
        string street = Console.ReadLine();

        Console.WriteLine("City:");
        string city = Console.ReadLine();

        Console.WriteLine("State:");
        string state = Console.ReadLine();

        Console.WriteLine("Country:");
        string country = Console.ReadLine();

        Address address = new Address(street, city, state, country);
        Customer customer = new Customer(customerName, address);

        Order order = new Order(customer);

        Console.WriteLine("How many different products are being ordered?");
        int orderCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < orderCount; i++)
        {
            Console.WriteLine("Enter product ID:");
            string id = Console.ReadLine();

            Product product = products.Find(p => p.GetId() == id);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                i--; 
                continue;
            }

            Console.WriteLine("Quantity to order:");
            int qty = int.Parse(Console.ReadLine());

            Product orderedProduct = new Product(product.GetName(), product.GetId(), product.GetPrice(), qty);
            order.AddProduct(orderedProduct);
        }

        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order.CalculateTotal():0.00}");

        Console.WriteLine("\nWould you like to update stock quantities? (yes/no)");
        string update = Console.ReadLine().Trim().ToLower();

        if (update == "yes")
        {
            foreach (Product p in products)
            {
                Console.WriteLine($"Current stock of {p.GetName()} (ID: {p.GetId()}): {p.GetQuantity()}");
                Console.WriteLine("Enter new stock quantity:");
                int newQty = int.Parse(Console.ReadLine());
                p.SetQuantity(newQty);
            }

            Console.WriteLine("Inventory updated successfully.");
        }
    }
}
