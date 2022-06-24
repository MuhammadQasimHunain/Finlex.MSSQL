using FinlexApp.DataLibrary.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinlexApp.DataLibrary.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Person> GetAllPersons()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByPersonalEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Order PostOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
