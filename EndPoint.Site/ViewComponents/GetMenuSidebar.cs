using Microsoft.AspNetCore.Mvc;
using Phoenix_Store.Application.Services.Common.Queries.GetMenuItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.ViewComponents
{
    public class GetMenuSidebar : ViewComponent
    {
            private readonly IGetMenuItemService _getMenuItemService;
            public GetMenuSidebar(IGetMenuItemService getMenuItemService)
            {
                _getMenuItemService = getMenuItemService;
            }
            public IViewComponentResult Invoke()
            {
                var menuItem = _getMenuItemService.Execute();
                return View(viewName: "GetMenuSidebar", menuItem.Data);
            }
        }
    
}
