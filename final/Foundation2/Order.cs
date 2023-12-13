using System;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        // Add shipping cost based on customer location
        totalCost += _customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (var product in _products)
        {
            packingLabel += $"{product.GetType().Name} - {product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {_customer.GetName()}\nAddress: {_customer.GetFullAddress()}";
    }
}
