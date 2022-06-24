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
        private readonly DbOrderContext DbOrderContext;

        public OrderRepository(DbOrderContext dbOrderContext)
        {
            this.DbOrderContext = dbOrderContext;
        }
        public List<Order> GetAllOrders()
        {
            return DbOrderContext.Orders.ToList();
        }

        public Order GetOrderByOrderNo(int orderNo)
        {
            return DbOrderContext.Orders.Where(d => d.OrderNo == orderNo).FirstOrDefault();
        }

        public List<Order> GetOrdersByPersonalEmail(string email)
        {
            return DbOrderContext.Orders.Where(d => d.CreatedBy.Equals(email)).ToList();
        }

        public bool PutPostOrder(Order order)
        {
            try
            {
                var result = DbOrderContext.Orders.SingleOrDefault(b => b.OrderNo == order.OrderNo);
                if (result != null)
                {
                    result.ProductName = order.ProductName;
                    result.OrderDate = order.OrderDate;
                    result.CreatedBy = order.CreatedBy;
                    result.OrderDate = order.OrderDate;
                    result.Price = order.Price;
                    result.TotalPrice = order.TotalPrice;
                    DbOrderContext.SaveChanges();
                }
                else
                {
                    DbOrderContext.Orders.Add(order);
                    DbOrderContext.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
