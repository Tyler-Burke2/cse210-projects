using System;

public class Product
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetId()
    {
        return _productID;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int newQuantity)
    {
        _quantity = newQuantity;
    }

    public double GetTotalCost(int qty)
    {
        return _pricePerUnit * qty;
    }

    public override string ToString()
    {
        return $"{_name} (ID: {_productID}) - Qty: {_quantity}";
    }
}