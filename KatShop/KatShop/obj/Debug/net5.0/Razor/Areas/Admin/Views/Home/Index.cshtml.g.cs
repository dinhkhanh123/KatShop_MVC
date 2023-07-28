#pragma checksum "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "866c27e2148fc6392cb6ff4afe081d85643a9cf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\_ViewImports.cshtml"
using KatShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\_ViewImports.cshtml"
using KatShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"866c27e2148fc6392cb6ff4afe081d85643a9cf8", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8923a1a54a6ec7cd3340369bdd765fe69effd31e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Trang chủ Admin";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Start Content-->
<div class=""container-fluid"">

    <!-- start page title -->
    <div class=""row"">
        <div class=""col-12"">
            <div class=""page-title-box"">
                <div class=""page-title-right"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866c27e2148fc6392cb6ff4afe081d85643a9cf84130", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control form-control-light"" id=""dash-daterange"">
                            <span class=""input-group-text bg-primary border-primary text-white"">
                                <i class=""mdi mdi-calendar-range font-13""></i>
                            </span>
                        </div>
               
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <h4 class=""page-title"">Dashboard</h4>
            </div>
        </div>
    </div>
    <!-- end page title -->

    <div class=""row"">
        <div class=""col-xl-5 col-lg-6"">

            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""card widget-flat"">
                        <div class=""card-body"">
                            <div class=""float-end"">
                                <i class=""mdi mdi-account-multiple widget-icon""></i>
                            </div>
                            <h5 class=""text-muted fw-normal mt-0"" title=""Number of Customers"">Khánh hàng</h5>
                            <h3 class=""mt-3 mb-3"">");
#nullable restore
#line 43 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Home\Index.cshtml"
                                             Write(ViewBag.TotalCustomers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p class=\"mb-0 text-muted\">\r\n");
            WriteLiteral(@"                            </p>
                        </div> <!-- end card-body-->
                    </div> <!-- end card-->
                </div> <!-- end col-->

                <div class=""col-lg-6"">
                    <div class=""card widget-flat"">
                        <div class=""card-body"">
                            <div class=""float-end"">
                                <i class=""mdi mdi-cart-plus widget-icon""></i>
                            </div>
                            <h5 class=""text-muted fw-normal mt-0"" title=""Number of Orders"">Orders</h5>
                            <h3 class=""mt-3 mb-3"">");
#nullable restore
#line 59 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Home\Index.cshtml"
                                             Write(ViewBag.TotalOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p class=\"mb-0 text-muted\">\r\n");
            WriteLiteral(@"                            </p>
                        </div> <!-- end card-body-->
                    </div> <!-- end card-->
                </div> <!-- end col-->
            </div> <!-- end row -->

            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""card widget-flat"">
                        <div class=""card-body"">
                            <div class=""float-end"">
                                <i class=""mdi mdi-currency-usd widget-icon""></i>
                            </div>
                            <h5 class=""text-muted fw-normal mt-0"" title=""Average Revenue"">Revenue</h5>
                            <h3 class=""mt-3 mb-3"">");
#nullable restore
#line 77 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Home\Index.cshtml"
                                             Write(ViewBag.TotalRevenue.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p class=\"mb-0 text-muted\">\r\n");
            WriteLiteral(@"                            </p>
                        </div> <!-- end card-body-->
                    </div> <!-- end card-->
                </div> <!-- end col-->

                <div class=""col-lg-6"">
                    <div class=""card widget-flat"">
                        <div class=""card-body"">
                            <div class=""float-end"">
                                <i class=""mdi mdi-pulse widget-icon""></i>
                            </div>
                            <h5 class=""text-muted fw-normal mt-0"" title=""Growth"">Bài đăng</h5>
                            <h3 class=""mt-3 mb-3"">");
#nullable restore
#line 93 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Home\Index.cshtml"
                                             Write(ViewBag.TotalPost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p class=\"mb-0 text-muted\">\r\n");
            WriteLiteral(@"                            </p>
                        </div> <!-- end card-body-->
                    </div> <!-- end card-->
                </div> <!-- end col-->
            </div> <!-- end row -->

        </div> <!-- end col -->

        <div class=""col-xl-7 col-lg-6"">
            <div class=""card card-h-100"">
                <div class=""card-body"">
                    <div class=""dropdown float-end"">
                        <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                            <i class=""mdi mdi-dots-vertical""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-end"">
                            <!-- item-->
                            <a href=""javascript:void(0);"" class=""dropdown-item"">Sales Report</a>
                            <!-- item-->
                            <a href=""javascript:void(0);"" class=""dropdown-item"">Export Report</a>
                  ");
            WriteLiteral(@"          <!-- item-->
                            <a href=""javascript:void(0);"" class=""dropdown-item"">Profit</a>
                            <!-- item-->
                            <a href=""javascript:void(0);"" class=""dropdown-item"">Action</a>
                        </div>
                    </div>
                    <h4 class=""header-title mb-3"">Projections Vs Actuals</h4>

                    <div dir=""ltr"">
                        <div id=""high-performing-product"" class=""apex-charts"" data-colors=""#727cf5,#e3eaef""></div>
                    </div>

                </div> <!-- end card-body-->
            </div> <!-- end card-->

        </div> <!-- end col -->
    </div>
    <!-- end row -->
");
            WriteLiteral("    <!-- end row -->\r\n\r\n</div>\r\n<!-- container -->\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
