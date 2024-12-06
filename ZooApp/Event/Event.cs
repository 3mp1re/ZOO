public class Event
{
    public int EventId { get; set; }
    public string EventName { get; set; }
    public DateTime EventDate { get; set; }
    public string Location { get; set; }

    public void CreateEvent() { }
    public void UpdateEvent() { }
    public void DeleteEvent() { }
    public void GetEventDetails() { }
}