class Program
{
    static void Main()
    {
        Address address = new Address();
        Customer customer = new Customer();
        Order order = new Order();

        Product p = new Product();
        order.products.Add(p);

        Console.WriteLine(order.TotalCost());
    }
}
