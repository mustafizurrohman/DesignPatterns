namespace FactoryMethod;

public class CountryDiscountService : DiscountService
{    
    private readonly string _countryIdentifier;

    public CountryDiscountService(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override int DiscountPercentage
    {
        get
        {
            return _countryIdentifier switch
            {
                "BE" => 20,
                _ => 10,
            };
        }
    }

}
