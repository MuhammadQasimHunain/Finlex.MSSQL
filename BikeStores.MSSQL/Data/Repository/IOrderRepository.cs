using FinlexApp.DataLibrary.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinlexApp.DataLibrary.Repository
{
    public interface IOrderRepository
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
