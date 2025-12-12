using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            // In the order we stored Product with quantity being the ordered quantity
            total += p.GetPrice() * p.GetQuantity();
        }

        // Shipping cost
        if (_customer != null && _customer.LivesInUSA())
        {
            total += 5.00;
        }
        else
        {
            total += 35.00;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (Product p in _products)
        {
            sb.AppendLine($"{p.GetName()} (ID: {p.GetId()}) - Qty: {p.GetQuantity()}");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        if (_customer == null) return "No customer.";
        return $"Ship To:\n{_customer.GetName()}\n{_customer.GetAddress().ToString()}";
    }
}