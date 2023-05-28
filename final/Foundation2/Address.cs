using System;
public class Address
{
    private string _streetaddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetaddress, string city, string stateOrProvice, string country)
    {
        _streetaddress = streetaddress;
        _city = city;
        _stateOrProvince = stateOrProvice;
        _country = country;
    }
    public bool InUS()
    {
        bool livesInUS = false;
        if (_country == "U.S.A.")
        {
            livesInUS = true;
        }
        return livesInUS;
    }
    public string GetAddress()
    {
        string newAddress = $"{_streetaddress}\n{_city} {_stateOrProvince}\n{_country}";

        return newAddress;
    }

}





