namespace IntroToDDDEmailCourse.TacticalDesign;
public class OrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly OrderAggregateFactory _orderAggregateFactory;

    public OrderService(IOrderRepository orderRepository, 
                OrderAggregateFactory orderAggregateFactory)
    {
        _orderRepository = orderRepository;
        _orderAggregateFactory = orderAggregateFactory;
    }

    public void CreateOrder(int orderId, DateTime orderDate, 
                            Address shippingAddress,
                            List<OrderItem> orderItems)
    {
        // Factory creates a new Order aggregate
        var order = _orderAggregateFactory.CreateOrder(orderId, orderDate, shippingAddress, orderItems);

        // Save the order using the repository
        _orderRepository.SaveOrder(order);
    }
}