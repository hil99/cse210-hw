public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, string date, string time, 
                     Address address, string rsvpEmail) 
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\n" +
               $"Event Type: Reception\n" +
               $"RSVP Email: {rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception - {Title} on {Date}";
    }
}