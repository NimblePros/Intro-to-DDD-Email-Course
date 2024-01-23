namespace IntroToDDDEmailCourse.TacticalDesign;
public class OrderAggregateFactory
{
    public Order CreateOrder(int orderId, DateTime orderDate, Address shippingAddress, List<OrderItem> orderItems)
    {
        // Business rules or validation logic here
        if (orderItems == null || !orderItems.Any())
        {
            throw new ArgumentException("An order must have at least one order item.", nameof(orderItems));
        }

        // Other business rules...

        // Create the Order aggregate
        var order = new Order
        {
            Id = orderId,
            OrderDate = orderDate,
            ShippingAddress = shippingAddress,
            OrderItems = orderItems
        };

        // Other initialization logic...

        return order;
    }
}