using System;
public class Order
{
    private Customer _newcustomer;
    private List<Product> _productsInOrder;

    public Order(Customer newCustomer, List<Product> productsInOrder)
    {
        _newcustomer = newCustomer;
        _productsInOrder = productsInOrder;
    }

    public double CalculateCost()
    {
        double cost = 0;
        foreach (Product product in _productsInOrder)
        {
            cost = cost + product.CalculatePrice();
        }
        if (_newcustomer.CustomerLivesInUS()== true)
        {
            cost = cost + 5;
        }
        else
        {
            cost = cost + 35;
        }
        return cost;
    }

    public void DisplayPackingLabel(Order order)
    {
        Console.WriteLine("The package contains the following items");
        foreach (Product product in _productsInOrder)
        {
            Console.WriteLine($"ID: {product.GetID()} Name: {product.GetName()} Quantity: {product.GetQuantity()}");
        }
    } 
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Ship to :");
        Console.WriteLine($"{_newcustomer.GetName()}");
        Address forshipping =_newcustomer.GetAddress();
        string newAddress = forshipping.GetAddress();
        Console.WriteLine($"{newAddress}");
    } 

}


