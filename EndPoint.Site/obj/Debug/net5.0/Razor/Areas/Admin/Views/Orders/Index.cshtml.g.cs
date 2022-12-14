#pragma checksum "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2ebafdc1e8f4b113feda964c7a151faafb4a35c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
using Phoenix_Store.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
using Phoenix_Store.Application.Services.Orders.Queries.GetOrdersForAdmin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2ebafdc1e8f4b113feda964c7a151faafb4a35c", @"/Areas/Admin/Views/Orders/Index.cshtml")]
    public class Areas_Admin_Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrdersDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayOut.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Zero configuration table -->
        <section id=""configuration"">

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <div class=""card-title-wrap bar-success"">
                                <h4 class=""card-title"">????????  ??????????????</h4>
                            </div>
                        </div>
                        <div class=""card-body collapse show"">
                            <div class=""card-block card-dashboard"">
                                <p class=""card-text"">???????? ??????????????  ?????????????? ???????? ??????????</p>

                                <form method=""get"" class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                    <fieldset class=""form-group"">
                                        <input type=""text"" class=""form-control"" name=""serchkey"">
               ");
            WriteLiteral(@"                         <button class=""btn btn-success"">??????????</button>
                                    </fieldset>
                                </form>

                                <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                                    <div class=""col-sm-12"">
                                        <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                            <thead>
                                                <tr role=""row"">
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""??????: activate to sort column descending"" style=""width: 222px;"">?????????? ??????????</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" ");
            WriteLiteral(@"aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""??????: activate to sort column descending"" style=""width: 222px;"">?????????? ?????? ??????????</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""??????: activate to sort column descending"" style=""width: 222px;"">?????????? ????????????</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""??????: activate to sort column descending"" style=""width: 222px;"">?????????? ??????????</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""??????: activate to sort column descending"" style=""width: 222px;""></th>


                                                </tr>
        ");
            WriteLiteral("                                    </thead>\r\n                                            <tbody>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr role=\"row\" class=\"odd\">\r\n                                                        <td class=\"sorting_1\">");
#nullable restore
#line 52 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
                                                                         Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 53 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
                                                       Write(item.InsertTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 54 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
                                                       Write(item.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n");
#nullable restore
#line 56 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
                                                              
                                                                string state = EnumHelpers<Phoenix_Store.Domain.Entities.Orders.OrderState>.GetDisplayValue(item.OrderState);
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <text>");
#nullable restore
#line 59 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
                                                         Write(state);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </text>
                                                    </td>
                                                    <td>
                                                        <a class=""btn btn-info""> ?????????? ?????? ?????????? ??????????</a>
                                                        <a class=""btn btn-danger"">???????????? ???????????? </a>

                                                    </td>
                                                </tr>
");
#nullable restore
#line 67 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Orders\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div><div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""DataTables_Table_0_info"" role=""status"" aria-live=""polite"">?????????? 1 ???? 10 ???? 57 ??????????</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""DataTables_Table_0_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""DataTables_Table_0_previous""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">????????</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button pag");
            WriteLiteral(@"e-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""DataTables_Table_0_next""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">????????</a></li></ul></div></div></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </section>
    </div>
</div>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrdersDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
