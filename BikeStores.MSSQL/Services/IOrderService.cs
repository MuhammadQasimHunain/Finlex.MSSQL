using FinlexApp.DataLibrary.DataModel;

namespace Finlex.MSSQL.Services
{
    public interface IOrderService
    {
        /// <summary>
        /// Get Orders by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        List<Order> GetOrdersByPersonalEmail(string email);

        /// <summary>
        /// Add / Update Order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        bool PutPostOrder(Order order);

        /// <summary>
        /// Get All Orders
        /// </summary>
        /// <returns></returns>
        List<Order> GetAllOrders();

        /// <summary>
        /// Get Orders By Order Number
        /// </summary>
        /// <param name="orderNo"></param>
        /// <returns></returns>
        Order GetOrderByOrderNo(int orderNo);
    }
}
