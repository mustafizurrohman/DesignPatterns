namespace AbstractFactory;

public interface IShippingCostsService
{
    decimal ShippingCosts { get; }
    string Country { get; }
}

public class BelgiumShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 20;
    public string Country => Constants.Belgium;
}

public class FranceShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 25;
    public string Country => Constants.France;
}