namespace IntroToDDDEmailCourse.DomainEvents;

public class OrderPlacedEvent
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    // Other relevant event data
}