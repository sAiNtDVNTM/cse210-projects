using System;
class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Address nonUsaAddress = new Address("456 Maple St", "Townsville", "NSW", "Australia");

        // Create customers
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer nonUsaCustomer = new Customer("Jane Smith", nonUsaAddress);

        // Create products
        Product product1 = new Product("Laptop", 1, 999.99, 2);
        Product product2 = new Product("Printer", 2, 199.99, 1);

        // Create orders
        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(product1);
        usaOrder.AddProduct(product2);

        Order nonUsaOrder = new Order(nonUsaCustomer);
        nonUsaOrder.AddProduct(product1);
        nonUsaOrder.AddProduct(product2);

        // Display results
        Console.WriteLine("USA Order:");
        Console.WriteLine(usaOrder.GetPackingLabel());
        Console.WriteLine(usaOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${usaOrder.CalculateTotalCost():F2}\n");

        Console.WriteLine("Non-USA Order:");
        Console.WriteLine(nonUsaOrder.GetPackingLabel());
        Console.WriteLine(nonUsaOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${nonUsaOrder.CalculateTotalCost():F2}");
    }
}
