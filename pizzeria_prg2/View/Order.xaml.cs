using System.Collections.ObjectModel;
using System.Diagnostics;


namespace pizzeria_prg2.View;

public partial class Order : ContentPage
{
    bool cartListCheck = false;
    int PizzaCount = 0;
    public ObservableCollection<Pizza> CartList { get; set; }
    public Order()
    {
        InitializeComponent();
        CartList = new ObservableCollection<Pizza>(); // First, initialize the list
        BindingContext = this;
    }
    private void OrderMargherita(object sender, EventArgs e)
    {
        Debug.WriteLine("Your pizza is being made as we speak");

        Pizza newPizza = new KebabPizza(new PizzaBASE());

        // Check if the pizza is already in the cart (based on name or ID)
        var existingPizza = CartList.FirstOrDefault(p => p.Title == newPizza.Title);

        if (existingPizza == null)
        {
            CartList.Add(newPizza);
        }
        else
        {
            existingPizza.Quantity++;

        }

        Debug.WriteLine("Current cart: " + string.Join(", ", CartList.Select(p => p.Title)));
    }

    private void RemoveMargherita(object sender, EventArgs e)
    {
        // Find the pizza in the cart (e.g., Margherita)
        var existingPizza = CartList.FirstOrDefault(p => p.Title == "Margherita");    // Decrease quantity
            existingPizza.Quantity--;

        // If the quantity reaches 0, remove it from the cart
        if (existingPizza.Quantity == 0)
        {
            CartList.Remove(existingPizza);
        }

        Debug.WriteLine("Current cart: " + string.Join(", ", CartList.Select(p => p.Title)));
    }

}
