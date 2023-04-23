namespace AbstractFactory;

public interface IDiscountService
{
    int DiscountPercentage { get; }
    string Country { get; }
}

public class BelgiumDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
    public string Country => Constants.Belgium;
}

public class FranceDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
    public string Country => Constants.France;
}