using System.ComponentModel;

public abstract class Pizza : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public abstract string Title { get; }
    public abstract decimal Price { get; }
    public abstract string Ingredients { get; }

    private int quantity;
    public virtual int Quantity
    {
        get => quantity;
        set
        {
            if (quantity != value)
            {
                quantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Quantity)));
            }
        }
    }
}
