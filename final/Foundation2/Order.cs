using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;

        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        // Shipping cost
        if (customer.LivesInUSA())
        {
            total += 5.00; // Domestic
        }
        else
        {
            total += 35.00; // International
        }

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");

        foreach (Product p in products)
        {
            sb.AppendLine(p.ToString());
        }

        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Ship To:\n{customer.GetName()}\n{customer.GetAddress().ToString()}";
    }
}
