using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pizzeria_prg2
{

    public class MargheritaPizza : Pizza
    {
        public override string Title => "Margherita";
        public override decimal Price => 60m;
        public override string Ingredients => "Cheese, tomato sauce";
    }

}
