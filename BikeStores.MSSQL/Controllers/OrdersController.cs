using Finlex.MSSQL.Services;
using FinlexApp.DataLibrary.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace Finlex_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        public IOrderService OrderService { get; set; }
        private readonly ILogger<OrdersController> Logger;
        public OrdersController(IOrderService orderService, ILogger<OrdersController> logger)
        {
            this.OrderService = orderService;
            this.Logger = logger;
        }


        [Route("GetOrders")]
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return OrderService.GetAllOrders();
        }


        [Route("PutPostOrder")]
        [HttpPost]
        public bool PutPostOrder([FromBody] Order order)
        {
            return OrderService.PutPostOrder(order);
        }

        [Route("GetOrdersByPersonalEmail")]
        [HttpGet]
        public IEnumerable<Order> GetOrdersByPersonalEmail(string email)
        {
            return OrderService.GetOrdersByPersonalEmail(email);
        }

        [Route("GetOrderByOrderNo")]
        [HttpGet]
        public Order GetOrderByOrderNo(int orderNo)
        {
            return OrderService.GetOrderByOrderNo(orderNo);
        }

    }
}