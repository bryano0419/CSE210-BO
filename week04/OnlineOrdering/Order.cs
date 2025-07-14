using System.Collections.Generic;

public class Order
{
    public List<Product> products;
    public Customer customer;

    public double TotalCost()
    {
        double total = 0;
        foreach (var item in products)
        {
            total += item.TotalPrice();
        }
        return total + 5;
    }
}
