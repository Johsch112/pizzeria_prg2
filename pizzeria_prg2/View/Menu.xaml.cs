using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using pizzeria_prg2.Models;

namespace pizzeria_prg2.View;

public partial class Menu : ContentPage
{
    public ObservableCollection<PizzaMenuItem> Items { get; set; } = new ObservableCollection<PizzaMenuItem>();

    public Menu()
    {
        InitializeComponent();
        BindingContext = this;
        LoadMenuAsync();
    }

    public async void LoadMenuAsync()
    {
        try
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://private-anon-a89a2666d6-pizzaapp.apiary-mock.com/restaurants/2/menu?category=&orderBy=");
            response.EnsureSuccessStatusCode();

            string responseData = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(responseData);

            var menuItems = JsonSerializer.Deserialize<List<PizzaMenuItem>>(responseData,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (menuItems != null)
            {
                foreach (var item in menuItems)
                    Items.Add(item);
            }
            else
            {
                Debug.WriteLine("Menu is empty.");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error loading menu: {ex.Message}");
        }
    }
}
