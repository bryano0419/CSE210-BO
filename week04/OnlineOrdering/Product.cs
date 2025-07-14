public class Product
{
    public string name;
    public string productId;
    public double price;
    public int quantity;

    public double TotalPrice()
    {
        return price * quantity;
    }
}
