public class Customer
{
    public string name;
    public Address address;

    public bool IsUSCustomer()
    {
        return address.country == "USA";
    }
}
