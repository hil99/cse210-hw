public abstract class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\n" +
               $"Description: {description}\n" +
               $"Date: {date}\n" +
               $"Time: {time}\n" +
               $"Address: {address.GetFullAddress()}";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();

    // Getters for derived classes to access private members if needed
    protected string Title => title;
    protected string Description => description;
    protected string Date => date;
    protected string Time => time;
    protected Address EventAddress => address;
}