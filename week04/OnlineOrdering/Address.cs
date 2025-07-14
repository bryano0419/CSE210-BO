public class Address
{
    public string street;
    public string city;
    public string state;
    public string country;

    public bool IsInUSA()
    {
        return country == "USA";
    }
}
