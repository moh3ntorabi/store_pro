#pragma checksum "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Product\AddNewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e289c4ce62c0800249174a263ec9730275a1b67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_AddNewProduct), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/AddNewProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e289c4ce62c0800249174a263ec9730275a1b67", @"/Areas/Admin/Views/Product/AddNewProduct.cshtml")]
    public class Areas_Admin_Views_Product_AddNewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Category"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Product\AddNewProduct.cshtml"
  
    ViewData["Title"] = "AddNewProduct";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayOut.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
{
<section class=""basic-elements"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <h2 class=""content-header"">?????????? ????????</h2>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title-wrap bar-success"">
                        <h4 class=""card-title mb-0"">?????????????? ?????????? ???????? ???? ???????? ????????????</h4>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""px-3"">
                        <div class=""form"">
                            <div class=""form-body"">
                                <div class=""row"">
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput"">?????? ?????????? </label>
                                   ");
            WriteLiteral(@"         <input type=""text"" class=""form-control"" id=""Name"">
                                        </fieldset>
                                    </div>
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput""> ???????? </label>
                                            <input type=""text"" class=""form-control"" id=""Brand"">
                                        </fieldset>
                                    </div>
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput""> ????????</label>
                                            <input type=""number"" class=""form-control"" id=""Price"">
                                        </fieldset>
                                    </div>");
            WriteLiteral(@"
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput""> ?????????? ????????????</label>
                                            <input type=""number"" class=""form-control"" id=""Inventory"">
                                        </fieldset>
                                    </div>
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput"">?????????? ???????? ???????? </label>
                                            <input type=""checkbox"" class=""form-control"" id=""Displayed"">
                                        </fieldset>
                                    </div>
                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <f");
            WriteLiteral(@"ieldset class=""form-group"">
                                            <label for=""basicInput"">???????????? </label>
                                            <input type=""file"" multiple class=""form-control"" accept=""image/*"" id=""Images"">
                                        </fieldset>
                                    </div>


                                    <div class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput"">???????? ???????? </label>

                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e289c4ce62c0800249174a263ec9730275a1b678782", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 69 "C:\Users\Phoenix\source\Phoenix_Store\EndPoint.Site\Areas\Admin\Views\Product\AddNewProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Categories;

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
                                        </fieldset>
                                    </div>
                                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput""> ??????????????</label>
                                            <textarea id=""Description"" class=""form-control "" rows=""5""></textarea>
                                        </fieldset>
                                    </div>

                                    <hr />
                                    <hr />


                                    <div class=""col-xl-2 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput""> ?????? ?????????? </label>
                                            <input type=""text"" class=""form-control"" id=""txtDisplay"" placeholder=""?????? ??????????"" />
    ");
            WriteLiteral(@"                                    </fieldset>
                                    </div>



                                    <div class=""col-xl-2 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <label for=""basicInput""> ?????????? ?????????? </label>
                                            <input type=""text"" class=""form-control"" id=""txtValue"" placeholder=""?????????? ??????????"" />
                                        </fieldset>
                                    </div>
                                    <div class=""col-xl-2 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <br />
                                            <a class=""btn btn-success"" id=""btnAddFeatures"">????????????</a>
                                        </fieldset>
                                    </div>



                                    <br c");
            WriteLiteral(@"lass=""clear"" />

                                    <table id=""tbl_Features"" class=""col-md-12 table table-bordered table-hover  table-condensed table-responsive"">
                                        <thead>
                                            <tr>
                                                <th>
                                                    ?????? ??????????
                                                </th>
                                                <th>
                                                    ?????????? ??????????
                                                </th>
                                                <th>

                                                </th>
                                            </tr>
                                        </thead>
                                        <tbody></tbody>
                                    </table>





                                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
 ");
            WriteLiteral(@"                                       <fieldset class=""form-group"">
                                            <br />
                                            <a id=""btnAddProduct"" class=""btn btn-success col-md-12""> ???????????? ??????????  </a>
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
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e289c4ce62c0800249174a263ec9730275a1b6714247", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e289c4ce62c0800249174a263ec9730275a1b6715426", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script>

        $(""#btnAddFeatures"").on(""click"", function () {
            var txtDisplay = $(""#txtDisplay"").val();
            var txtValue = $(""#txtValue"").val();
            if (txtDisplay == """" || txtValue == """") {
                swal.fire(
                    '??????????!',
                    ""?????? ?? ?????????? ???? ???????? ???????? ????????"",
                    'warning'
                );
            }
            else {
                debugger
                $('#tbl_Features tbody').append('<tr> <td>' + txtDisplay + '</td>  <td>' + txtValue + '</td> <td> <a class=""idFeatures btnDelete btn btn-danger""> ?????? </a> </td> </tr>');
                $(""#txtDisplay"").val('');
                $(""#txtValue"").val('');
            }
        });
        $(""#tbl_Features"").on('click', '.idFeatures', function () {
            debugger
            $(this).closest('tr').remove();
        });





        $('#btnAddProduct').on('click', function () {
            debugger
            var data = new ");
                WriteLiteral(@"FormData();
            debugger
            //???????????? ???????????? ???? ?????? ???????? ???? ??....
            data.append(""Name"", $(""#Name"").val());
            data.append(""Brand"", $(""#Brand"").val());
            data.append(""Price"", $(""#Price"").val());
            data.append(""Inventory"", $(""#Inventory"").val());
            data.append(""Displayed"", $(""#Displayed"").prop('checked'));
            data.append(""CategoryId"", $('#Category').find('option:selected').val());
            data.append(""Description"", $(""#Description"").val());
            
            //???????????? ?????? ?????? ???????????? ?????? ???????? ?????????? ?? ???????? ???????? ?????? ???? ???? ?????????? data
            var productImages = document.getElementById(""Images"");
            debugger
            if (productImages.files.length > 0) {
                for (var i = 0; i < productImages.files.length; i++) {
                    data.append('Images-' + i, productImages.files[i]);
                }
            }

            var dataFeaturesViewModel = $('#tbl_Features tr:gt(0)').map(");
                WriteLiteral(@"function () {
                return {
                    Display: $(this.cells[0]).text(),
                    Value: $(this.cells[1]).text(),
                };
            }).get();

            $.each(dataFeaturesViewModel, function (i, val) {
                data.append('[' + i + '].Display', val.Display);
                data.append('[' + i + '].Value', val.Value);

            });




            // ?????????? ?????????????? ???? ????????????
            var ajaxRequest = $.ajax({
                type: ""POST"",
                url: ""AddNewProduct"",
                contentType: false,
                processData: false,
                data: data,
                success: function (data) {

                    if (data.isSuccess == true) {

                        swal.fire(
                            '????????!',
                            data.message,
                            'success'
                        ).then(function (isConfirm) {
                            window.location.href ");
                WriteLiteral(@"= ""/Admin/Product/"";

                        });
                    }
                    else {

                        swal.fire(
                            '??????????!',
                            data.message,
                            'warning'
                        );
                    }

                },
                error: function (xhr, ajaxOptions, thrownError) {
                    alert(xhr.status);
                    alert(thrownError);
                }

            });

            ajaxRequest.done(function (xhr, textStatus) {
                // Do other operation
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
