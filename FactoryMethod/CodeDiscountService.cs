namespace FactoryMethod;

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
