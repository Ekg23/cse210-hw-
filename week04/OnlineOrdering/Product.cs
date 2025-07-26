using System;

public class Product
{
    public string _name { get; set; }
    public string _productId { get; set; }
    public decimal _price { get; set; }
    public int _quantity { get; set; }


    public Product(string productName, string productId, decimal price, int quantity)
    {
        _name = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}