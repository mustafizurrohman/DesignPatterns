namespace FactoryMethod;

public abstract class DiscountService
{
    public abstract int DiscountPercentage { get; }

    public override string ToString() => GetType().Name;
}

public class CodeDiscountService : DiscountService
{
    // ReSharper disable once NotAccessedField.Local
    private readonly Guid _code;

    public CodeDiscountService(Guid code)
    {
        _code = code;
    }

    // Only for demo. In real app it must be verified
    public override int DiscountPercentage => 15;
}

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
