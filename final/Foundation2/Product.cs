using System;

public class Product{

    //private attritutes
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;
    // private double _productPrice;


    public Product(string productName, string productId, double price, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public Product()
    {
    }

    public double GetProductPrice()
    {
        
        double _productPrice = _price * _quantity;
        return _productPrice;
    }

    public string GetProductLabel()
    {
        return ($"{_productId}: {_productName}");
    }










}