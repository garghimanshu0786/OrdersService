using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UserService
{
    [ApiController]
    [Route("orders")]
    public class OrdersControlller : ControllerBase
    {
        private readonly ILogger<OrdersControlller> _logger;

        public OrdersControlller(ILogger<OrdersControlller> logger)
        {
            _logger = logger;
        }

        [Route("{id}")]
        public Order GetOrder(int id)
        {
            return OrderProvider.orders.Find(user => user.OrderId == id);
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return OrderProvider.orders;
        }
    }
}
