using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Test");
        Order order = new Order(customer);
        for(int i = 0; i < 3; i++)
        {
            order.AddProduct();
        }
        Console.Clear();
        order.GetPackingLabel();
        order.GetShippingLabel();
        order.GetTotalPrice();
    }
}