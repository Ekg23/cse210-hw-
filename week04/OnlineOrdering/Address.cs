using System;

public class Address
{
    public string _streetAddress { get; set; }
    public string _city { get; set; }
    public string _state { get; set; }
    public string _country { get; set; }

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

     public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

        public string GetFullAddress()
        {
            return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
        }
}