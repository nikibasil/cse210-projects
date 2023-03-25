using System;

public class Order
{
    protected List<Product> _products = new List<Product>();
    private double _totalPrice;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void GetPackingLabel()
    {
        Console.WriteLine("*** PACKING LABEL ***");
        foreach(Product p in _products)
        {
            Console.WriteLine(p.GetProductLabel());
        }
        Console.WriteLine("***               ***");
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("*** SHIPPING LABEL ***");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().GetAddress());
        Console.WriteLine("***                ***");
    } 

    public void GetTotalPrice()
    {
        _totalPrice = 0;
        foreach (Product p in _products)
        {
            _totalPrice += p.GetProductPrice();
        }
       
        bool us = _customer.GetCountry();
        if ( us == true)
        {
            _totalPrice += 5;
        }
        else
        {
            _totalPrice += 35;
        }

        Console.WriteLine($"Total: ${_totalPrice.ToString("F2")}");
    }

    public void AddProduct()
    {
        Console.WriteLine("Enter the product info: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("ID: ");
        string id = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);
    }
}