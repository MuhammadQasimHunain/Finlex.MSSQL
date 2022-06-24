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
        Order PostOrder(Order order);

        /// <summary>
        /// Get All Persons
        /// </summary>
        /// <returns></returns>
        List<Person> GetAllPersons();
    }
}
