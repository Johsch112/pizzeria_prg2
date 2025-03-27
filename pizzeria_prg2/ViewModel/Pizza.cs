using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pizzeria_prg2
{
    public abstract class Pizza
    {




        public string name { get; set; }
        public string dough { get; set; }
        public string sauce { get; set; }
        public List<string> toppings = new List<string>();
       
        public void MakePizza()
        {
           
        }
      

    }
}