using AbstractFactory;

Console.Title = "Abstract Factory";

var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
var belgiumShoppingCart = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
belgiumShoppingCart.PrintCosts();

var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var franceShoppingCart = new ShoppingCart(franceShoppingCartPurchaseFactory);
franceShoppingCart.PrintCosts(); 

Console.ReadKey();