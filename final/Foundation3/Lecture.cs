public class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string title, string description, string date, string time, 
                   Address address, string speakerName, int capacity) 
        : base(title, description, date, time, address)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\n" +
               $"Event Type: Lecture\n" +
               $"Speaker: {speakerName}\n" +
               $"Capacity: {capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture - {Title} on {Date}";
    }
}
