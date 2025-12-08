public class Product
{
    private string name;
    private string productID;
    private double pricePerUnit;
    private int quantity;

    public Product(string name, string productID, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.productID = productID;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return pricePerUnit * quantity;
    }

    public override string ToString()
    {
        return $"{name} (ID: {productID}) - Qty: {quantity}";
    }
}
