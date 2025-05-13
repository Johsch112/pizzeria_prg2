using System.Collections.ObjectModel;
using System.Diagnostics;

namespace pizzeria_prg2.View;

public partial class MainPage : ContentPage
{
    public static ObservableCollection<Menu> GlobalMenuItems { get; private set; } = new();
    public MainPage()
    {
        InitializeComponent();
    }
}
