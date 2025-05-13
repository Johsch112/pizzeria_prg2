public class KebabPizza : Pizza
{
    private readonly Pizza _base;

    public KebabPizza(Pizza pizza)
    {
        _base = pizza;
    }

    public override string Title => "Kebab Pizza";
    public override decimal Price => _base.Price + 30.0m;
    public override string Ingredients => _base.Ingredients + ", kebab meat, onion, garlic sauce";
}