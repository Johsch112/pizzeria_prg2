using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pizzeria_prg2
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza _decoratedPizza;

        public PizzaDecorator(Pizza pizza)
        {
            _decoratedPizza = pizza;
        }

        public override string Title => _decoratedPizza.Title;
        public override decimal Price => _decoratedPizza.Price;
        public override string Ingredients => _decoratedPizza.Ingredients;
    }

}