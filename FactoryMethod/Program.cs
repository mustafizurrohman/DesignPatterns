using FactoryMethod;

Console.Title = "Factory Method";

var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BE")
};


foreach(var factory in factories)
{
    var discountService = factory.CreateDiscountService();

    Console.WriteLine($"{discountService} - {discountService.DiscountPercentage} %");
}

Console.ReadKey();