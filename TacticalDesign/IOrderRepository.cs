namespace IntroToDDDEmailCourse.TacticalDesign;
public interface IOrderRepository
{
    Order GetOrderById(int orderId);
    void SaveOrder(Order order);
    // Other repository methods
}