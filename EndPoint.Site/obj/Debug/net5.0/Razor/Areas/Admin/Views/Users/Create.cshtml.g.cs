#pragma checksum "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Users\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31b9b099141b4097dc5113308ae3e54d99ee4acc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b9b099141b4097dc5113308ae3e54d99ee4acc", @"/Areas/Admin/Views/Users/Create.cshtml")]
    public class Areas_Admin_Views_Users_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("RoleId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Users\Create.cshtml"
  
    ViewData["Title"] = "ثبت نام کاربر جدید";
    Layout = "~/Areas/Admin/Views/Shared/_Adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""basic-elements"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <h2 class=""content-header"">فرم ثبت نام کاربر جدید</h2>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title-wrap bar-success"">
                        <h4 class=""card-title mb-0"">اطلاعات کاربر جدید را وارد نمایید</h4>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""px-3"">
                        <div class=""form"">
                            <div class=""form-body"">
                                <div class=""row"">
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput"">نام و نام خانوادگی</label>
                  ");
            WriteLiteral(@"                          <input type=""text"" class=""form-control"" id=""fullname"">
                                        </fieldset>
                                    </div>
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""helpInputTop"">پست الکترونیک</label>
                                            <small class=""text-muted""><i>info@mail.net</i></small>
                                            <input type=""text"" class=""form-control"" id=""email"">
                                        </fieldset>
                                    </div>

                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicSelect"">نقش</label>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b9b099141b4097dc5113308ae3e54d99ee4acc7240", async() => {
                WriteLiteral("\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 43 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Users\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Roles;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            <p><small class=""text-muted"">سطح دسترسی کاربر مورد نظر را تعیین کنید</small></p>

                                        </fieldset>
                                    </div>


                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""disabledInput"">رمز عبور</label>
                                            <input type=""password"" class=""form-control"" id=""Password"">
                                        </fieldset>
                                    </div>
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""disabledInput"">تکرار رمز عبور</label>
                                            <input type=""password"" class=""form-control"" id=""RePass");
            WriteLiteral(@"word"">
                                        </fieldset>
                                    </div>

                                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <br />
                                            <a onclick=""Registeruser()"" class=""btn btn-success col-md-12"">تکمیل ثبت نام </a>
                                        </fieldset>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>




");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    \r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "31b9b099141b4097dc5113308ae3e54d99ee4acc11045", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b9b099141b4097dc5113308ae3e54d99ee4acc12224", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        function Registeruser() {
            swal.fire({
                title: 'ثبت نام کاربر',
                text: ""آیا میخواهید ثبت نام کاربر را انجام دهید؟"",
                icon: 'info',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'بله ثبت نام انجام شود',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.value) {

                    var fullname = $(""#fullname"").val();
                    var email = $(""#email"").val();
                    var RoleId = $(""#RoleId"").val();
                    var Password = $(""#Password"").val();
                    var RePassword = $(""#RePassword"").val();

                    var postData = {
                        'fullname': fullname,
                        'email': email,
                        'RoleId': RoleId,
                        'Password': Password");
                WriteLiteral(@",
                        'RePassword': RePassword,
                    };

                    $.ajax({
                        contentType: 'application/x-www-form-urlencoded',
                        dataType: 'json',
                        type: ""POST"",
                        url: ""Create"",
                        data: postData,
                        success: function (data) {
                            if (data.isSuccess == true) {
                                swal.fire(
                                    'موفق!',
                                    data.message,
                                    'success'
                                ).then(function (isConfirm) {
                                    location.reload();
                                });


                            }
                            else {

                                swal.fire(
                                    'هشدار!',
                                    data.message,
      ");
                WriteLiteral(@"                              'warning'
                                ) ;

                            }
                        },
                        error: function (request, status, error) {
                            alert(request.responseText);
                        }

                    });

                }
            })
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
