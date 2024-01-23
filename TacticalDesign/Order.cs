namespace IntroToDDDEmailCourse.TacticalDesign;
public class Order : EntityBase
{
    public DateTime OrderDate { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    // Address as a Value Object
    public Address BillingAddress { get; set; } 
    // Address as a Value Object
    public Address ShippingAddress { get; set; } 
    // Other order-related properties and methods
}

public class OrderItem : EntityBase
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    // Other order item-related properties
}