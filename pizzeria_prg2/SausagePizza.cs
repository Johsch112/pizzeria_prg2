using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pizzeria_prg2
{
    public class SausagePizza : PizzaDecorator
    {
        public SausagePizza(Pizza pizza) : base(pizza)
        {
        }
        public override string Ingredients
        {
            get
            {
                return base.Ingredients + ", sausage";
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price + 30.75m;
            }
        }

    }
}