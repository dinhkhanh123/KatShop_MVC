#pragma checksum "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ba3c8d9b32f8fad588bd5b2e87ac95ebcc54c5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Post_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Post/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ba3c8d9b32f8fad588bd5b2e87ac95ebcc54c5b", @"/Areas/Admin/Views/Post/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8923a1a54a6ec7cd3340369bdd765fe69effd31e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Post_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KatShop.Models.Post>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
	<!-- Start Content-->
	<div class=""container-fluid"">
		<!-- start page title -->
		<div class=""row"">
			<div class=""col-12"">
				<div class=""page-title-box"">
					<div class=""page-title-right"">
						<ol class=""breadcrumb m-0"">
							<li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ba3c8d9b32f8fad588bd5b2e87ac95ebcc54c5b5040", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n\t\t\t\t\t\t\t<li class=\"breadcrumb-item active\">");
#nullable restore
#line 19 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                                                          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t</ol>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<h2 class=\"page-title\">");
#nullable restore
#line 22 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<!-- end page title -->\r\n\t\t<hr />\r\n\r\n\t\t<div class=\"table-responsive \">\r\n\t\t\t<table class=\"table mb-0 \">\r\n\t\t\t\t<tbody>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td> <strong>ID </strong> :</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 34 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.PostId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Tên bài đăng </strong> :</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 38 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Thumb </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 42 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.Thumb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Mô tả ngắn </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 46 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\t\t\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Người đăng </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 50 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Ngày đăng  </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 54 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Tags </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 58 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Alias </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 62 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>MetaDecs </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 66 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.MetaDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>MetaKey </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 70 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.MetaKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Tags </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 74 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>View </strong> : </td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 78 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                       Write(Model.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Trạng thái </strong> : </td>\r\n\t\t\t\t\t\t<td>\r\n");
#nullable restore
#line 83 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                             if (Model.Published)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"form-check form-check-inline\">\r\n\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" class=\"form-check-input\" id=\"customCheck5\" checked disabled>\r\n\t\t\t\t\t\t\t\t\t<label class=\"form-check-label\" for=\"customCheck5\"></label>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 89 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"form-check form-check-inline\">\r\n\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" class=\"form-check-input\" id=\"customCheck6\" disabled>\r\n\t\t\t\t\t\t\t\t\t<label class=\"form-check-label\" for=\"customCheck6\"></label>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 96 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Tin Hot </strong> : </td>\r\n\t\t\t\t\t\t<td>\r\n");
#nullable restore
#line 102 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                             if (Model.IsHot)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"form-check form-check-inline\">\r\n\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" class=\"form-check-input\" id=\"customCheck5\" checked disabled>\r\n\t\t\t\t\t\t\t\t\t<label class=\"form-check-label\" for=\"customCheck5\"></label>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 108 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"form-check form-check-inline\">\r\n\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" class=\"form-check-input\" id=\"customCheck6\" disabled>\r\n\t\t\t\t\t\t\t\t\t<label class=\"form-check-label\" for=\"customCheck6\"></label>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 115 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</td>\r\n\r\n\t\t\t\t\t</tr>\r\n\r\n\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td><strong>Tin mới </strong> : </td>\r\n\t\t\t\t\t\t<td>\r\n");
#nullable restore
#line 123 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                             if (Model.IsNewfeed)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"form-check form-check-inline\">\r\n\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" class=\"form-check-input\" id=\"customCheck5\" checked disabled>\r\n\t\t\t\t\t\t\t\t\t<label class=\"form-check-label\" for=\"customCheck5\"></label>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 129 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"form-check form-check-inline\">\r\n\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" class=\"form-check-input\" id=\"customCheck6\" disabled>\r\n\t\t\t\t\t\t\t\t\t<label class=\"form-check-label\" for=\"customCheck6\"></label>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 136 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t</tbody>\r\n\t\t\t</table>\r\n\r\n\t\t\t\r\n\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n<div class=\"content bg-white\">\r\n\t<div class=\"table-responsive \">\r\n\t\t<table class=\"table mb-0 \">\r\n\t\t\t<tbody>\r\n\t<tr>\r\n\t\t<td><strong>Nội dung</strong> : </td>\r\n\t\t<td>");
#nullable restore
#line 153 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
       Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t</tr>\r\n\t</tbody>\r\n\t</table>\r\n\t\t<hr />\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ba3c8d9b32f8fad588bd5b2e87ac95ebcc54c5b15666", async() => {
                WriteLiteral("Chỉnh sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "D:\ASP.Net\KatShop\KatShop\Areas\Admin\Views\Post\Details.cshtml"
                                                       WriteLiteral(Model.PostId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ba3c8d9b32f8fad588bd5b2e87ac95ebcc54c5b17915", async() => {
                WriteLiteral("Quay lại");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KatShop.Models.Post> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
