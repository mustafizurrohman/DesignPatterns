namespace AbstractFactory;

public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;

    private readonly int _orderCosts;

    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();
        _orderCosts = 200; 
    }

    public void PrintCosts()
    {
        // ReSharper disable once PossibleLossOfFraction
        decimal totalDiscount = _orderCosts * (_discountService.DiscountPercentage / 100);

        Console.WriteLine($"Discount Service Country: {_discountService.Country}");
        Console.WriteLine($"Shipping cost Service Country: {_shippingCostsService.Country}");
        Console.WriteLine($"Total costs = {_orderCosts - totalDiscount + _shippingCostsService.ShippingCosts}");
        Console.WriteLine();
    }
}