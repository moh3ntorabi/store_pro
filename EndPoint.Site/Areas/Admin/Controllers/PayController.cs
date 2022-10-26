using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Services.Finances.Queries.GetPayForAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PayController : Controller
    {
        private readonly IGetPayForAdminService _getPayForAdmin;
        public PayController(IGetPayForAdminService getPayForAdmin)
        {
            _getPayForAdmin = getPayForAdmin;
        }
        public IActionResult Index()
        {
            return View(_getPayForAdmin.Execute().Data);
        }
    }
}
