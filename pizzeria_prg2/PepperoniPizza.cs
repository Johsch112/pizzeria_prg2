using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pizzeria_prg2
{
    public class PepperoniPizza : PizzaDecorator
    {
            public PepperoniPizza(Pizza pizza) : base(pizza)
            {
            }

        public override string Title => "Pepperoni pizza";

        public override string Ingredients
            {
                get
                {
                    return base.Ingredients + ", Pepperonis, ham";
                }
            }

            public override decimal Price
            {
                get
                {
                    return base.Price + 70m;
                }
            }


        }


    }
