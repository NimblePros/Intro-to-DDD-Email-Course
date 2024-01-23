namespace IntroToDDDEmailCourse.DomainEvents;

public class OrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly OrderAggregateFactory _orderAggregateFactory;

    public OrderService(IOrderRepository orderRepository, OrderAggregateFactory orderAggregateFactory)
    {
        _orderRepository = orderRepository;
        _orderAggregateFactory = orderAggregateFactory;
    }

    public void PlaceOrder(int orderId, DateTime orderDate, Address shippingAddress, List<OrderItem> orderItems)
    {
        // Use the factory to create a new Order aggregate
        var order = _orderAggregateFactory.CreateOrder(orderId, orderDate, shippingAddress, orderItems);

        // Save the order using the repository
        _orderRepository.SaveOrder(order);

        // Trigger the OrderPlacedEvent after saving the order
        var orderPlacedEvent = new OrderPlacedEvent
        {
            OrderId = order.Id,
            OrderDate = order.OrderDate,
            // Set other relevant event data
        };

        // Publish the event to be handled by interested subscribers
        EventPublisher.Publish(orderPlacedEvent);
    }
}