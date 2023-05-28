using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Eggs", 1234, 3, 2);
        Product product2 = new Product("Milk", 5678, 2, 1);
        Product product3 = new Product("Bread", 9112, 4, 3);
        Product product4 = new Product("Chocolate", 3345, 1, 5);
        Product product5 = new Product("Light bulb", 6778, 7, 2);
        Product product6 = new Product("Knife", 9912, 10, 3);

        List<Product> order1List = new List<Product>(){product1, product2, product3};
        List<Product> order2List = new List<Product>(){product4, product5, product6};

        Address address1 = new Address("123 Sesame Street", "New York", "New York", "U.S.A.");
        Address address2 = new Address("789 Hot Dog Lane", "Toronto", "Ontario", "Canada");

        Customer customer1 =new Customer("Ricky Baker", address1);
        Customer customer2 =new Customer("Mary Weasley", address2);

        Order order1 = new Order(customer1, order1List);
        Order order2 = new Order(customer2, order2List);

        double Cost1 = order1.CalculateCost();
        Console.WriteLine($"Total cost of order: ${Cost1}");
        Console.WriteLine();
        order1.DisplayPackingLabel(order1);
        Console.WriteLine();
        order1.DisplayShippingLabel();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        double Cost2 = order2.CalculateCost();
        Console.WriteLine($"Total cost of order: ${Cost2}");
        Console.WriteLine();
        order2.DisplayPackingLabel(order2);
        Console.WriteLine();
        order2.DisplayShippingLabel();
    }
}