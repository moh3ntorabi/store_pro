#pragma checksum "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f11eca22623013734804ce474348652591d1ca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetMenuSidebar_GetMenuSidebar), @"mvc.1.0.view", @"/Views/Shared/Components/GetMenuSidebar/GetMenuSidebar.cshtml")]
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
#line 1 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
using Phoenix_Store.Application.Services.Common.Queries.GetMenuItem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f11eca22623013734804ce474348652591d1ca8", @"/Views/Shared/Components/GetMenuSidebar/GetMenuSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87685c89e84078b3e134b89a928accf3d0f04a39", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GetMenuSidebar_GetMenuSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MenuItemDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/product/index?CatId="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("category-level-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <ul class=\"nav-categories ul-base\">\r\n        <li>\r\n");
#nullable restore
#line 10 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\" class=\"collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#");
#nullable restore
#line 12 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
                                                                                            Write(item.CatId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\" aria-controls=\"collapseOne\"><i class=\"mdi mdi-chevron-down\"></i> ");
#nullable restore
#line 12 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
                                                                                                                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                <div");
            BeginWriteAttribute("id", " id=\"", 474, "\"", 490, 1);
#nullable restore
#line 14 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
WriteAttributeValue("", 479, item.CatId, 479, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingOne\" data-parent=\"#accordionExample\"");
            BeginWriteAttribute("style", " style=\"", 569, "\"", 577, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <ul>\r\n");
#nullable restore
#line 16 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
                         if (item.Child.Count() > 0)
                        {


                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
                             foreach (var itemChild in item.Child)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f11eca22623013734804ce474348652591d1ca87213", async() => {
#nullable restore
#line 23 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
                                                                                         Write(itemChild.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 25 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 30 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Views\Shared\Components\GetMenuSidebar\GetMenuSidebar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MenuItemDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
