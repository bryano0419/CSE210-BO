using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B1001", 12.99, 2));
        order1.AddProduct(new Product("Pen", "P2002", 1.50, 5));

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Chen", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N3003", 5.75, 3));
        order2.AddProduct(new Product("Backpack", "BK4004", 29.99, 1));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}

