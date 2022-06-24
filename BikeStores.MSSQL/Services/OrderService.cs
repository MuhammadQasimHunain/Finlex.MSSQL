using FinlexApp.DataLibrary.DataModel;
using FinlexApp.DataLibrary.Repository;

namespace Finlex.MSSQL.Services
{
    public class OrderService : IOrderService
    {
        public IOrderRepository OrderRepository { get; set; }
        public OrderService(IOrderRepository orderRepository)
        {
            this.OrderRepository = orderRepository;
        }
        public List<Order> GetAllOrders()
        {
            return OrderRepository.GetAllOrders();
        }

        public Order GetOrderByOrderNo(int orderNo)
        {
            return OrderRepository.GetOrderByOrderNo(orderNo);
        }

        public List<Order> GetOrdersByPersonalEmail(string email)
        {
            return OrderRepository.GetOrdersByPersonalEmail(email);
        }

        public bool PutPostOrder(Order order)
        {
            return OrderRepository.PutPostOrder(order);
        }
    }
}
