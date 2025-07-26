using System.Net.Sockets;

public class Customer
{
    public string _customerName;
    public Address _address;

    public Customer(string name, Address address)
        {
            _customerName = name;
            _address = address;
        }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}