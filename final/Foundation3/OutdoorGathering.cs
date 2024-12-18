public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, 
                             Address address, string weatherForecast) 
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\n" +
               $"Event Type: Outdoor Gathering\n" +
               $"Weather Forecast: {weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering - {Title} on {Date}";
    }
}
