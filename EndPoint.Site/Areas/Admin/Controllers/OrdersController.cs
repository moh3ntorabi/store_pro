using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Services.Orders.Queries.GetOrdersForAdmin;
using Phoenix_Store.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Operator")]
    public class OrdersController : Controller
    {
        private readonly IGetOrdersForAdminService _getOrdersForAdmin;
        public OrdersController(IGetOrdersForAdminService getOrdersForAdmin)
        {
            _getOrdersForAdmin = getOrdersForAdmin;
        }
        public IActionResult Index(OrderState orderState)
        {
            return View(_getOrdersForAdmin.Execute(orderState).Data);
        }
    }
}
