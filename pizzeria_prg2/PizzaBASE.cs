using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pizzeria_prg2
{
    public class PizzaBASE : Pizza
    {
            public override string Title => "PizzaBASE";
            public override decimal Price => 0.00m;
            public override string Ingredients => "tomato, cheese";
    }
}