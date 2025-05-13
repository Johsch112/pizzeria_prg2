using System.Text.Json.Serialization;

namespace pizzeria_prg2.Models
{
    public class PizzaMenuItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public List<string>? Topping { get; set; }

        public string ToppingString => Topping == null ? "" : string.Join(", ", Topping);
    }
    

}
