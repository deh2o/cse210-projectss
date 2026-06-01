using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer)

        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(
            new Product("Laptop", "P101", 850.00, 1));

        order1.AddProduct(
            new Product("Mouse", "P102", 25.00, 2));

        order1.AddProduct(
            new Product("Keyboard", "P103", 45.00, 1));

        // Order 2 (International Customer)

        Address address2 = new Address(
            "15 Oxford Road",
            "London",
            "England",
            "United Kingdom");

        Customer customer2 = new Customer(
            "Sarah Johnson",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(
            new Product("Tablet", "P201", 400.00, 1));

        order2.AddProduct(
            new Product("Headphones", "P202", 80.00, 2));

        order2.AddProduct(
            new Product("USB Cable", "P203", 15.00, 3));

        // Display Order 1

        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine(
            $"\nTOTAL COST: ${order1.CalculateTotalCost():F2}");

        // Display Order 2

        Console.WriteLine("\n=========================");
        Console.WriteLine("===== ORDER 2 =====");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine(
            $"\nTOTAL COST: ${order2.CalculateTotalCost():F2}");
    }
}
