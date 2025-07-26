using System;
using System.Net.Http.Headers;
using System.Text;

public class Order
{
    public List<Product> _products;
    public Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total = total + product.GetTotalCost();
        }

        // Add shipping cost
        total += _customer.IsInUSA() ? 5m : 35m;

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Product product in _products)
        {
            sb.AppendLine($"{product._name} (ID: {product._productId})");
        }
        return sb.ToString();
    }
    
     public string GetShippingLabel()
    {
        return $"{_customer._customerName}\n{_customer._address.GetFullAddress()}";
    }
    

}