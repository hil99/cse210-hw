public class Item
{
    // Attributes
    private string name;
    private double price;

    // Constructor
    public Item(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    // Methods
    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }
}
