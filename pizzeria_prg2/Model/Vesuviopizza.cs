using System;

namespace pizzeria_prg2
{
    public class Vesuviopizza : PizzaDecorator
    {
        public Vesuviopizza(Pizza pizza) : base(pizza)
        {
        }

        public override string Title => "Vesuviopizza";

        public override string Ingredients
        {
            get
            {
                return base.Ingredients + ", Ham";
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price + 20.75m;
            }
        }
    }
}
