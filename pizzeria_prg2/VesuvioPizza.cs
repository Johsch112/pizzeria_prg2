using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pizzeria_prg2
{
    public class VesuvioPizza : PizzaDecorator
    {
        public VesuvioPizza(Pizza pizza) : base(pizza)
        {
        }

        public override string Title => "Vesuvio pizza";

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