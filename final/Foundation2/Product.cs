using System;
public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;
    public Product(string name, int ID,int price, int quantity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetID()
    {
        return _productID;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double CalculatePrice()
    {
        double price = _price * _quantity;
        return price;
    }
}