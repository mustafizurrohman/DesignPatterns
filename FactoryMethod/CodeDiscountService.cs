namespace FactoryMethod;

public class CodeDiscountService : DiscountService
{
    private readonly Guid _code;

    public CodeDiscountService(Guid code)
    {
        _code = code;
    }

    // Only for demo. In real app it must be verified
    public override int DiscountPercentage => 15;
}
