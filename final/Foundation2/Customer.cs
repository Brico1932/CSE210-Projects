using System;
public class Customer
{
  private string _name;
  private Address _newAddress;

  public Customer(string name, Address newaddress)
  {
    _name = name;
    _newAddress = newaddress;
  }
  
  public string GetName()
  {
    return _name;
  }
  public Address GetAddress()
  {
    return _newAddress;
  }

  public bool CustomerLivesInUS()
  {
    bool livesInUS = false;
    livesInUS = _newAddress.InUS();
    return livesInUS;
  }
}


