#pragma checksum "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3ba97c2e025f6bca37ad93843f2e89cdd7fd997"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "D:\ASP.Net\KatShop\KatShop\Views\_ViewImports.cshtml"
using KatShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.Net\KatShop\KatShop\Views\_ViewImports.cshtml"
using KatShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3ba97c2e025f6bca37ad93843f2e89cdd7fd997", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ea83cc094ba88dda6627244ef51d9ebd5534d0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KatShop.ModelViews.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("contact-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded me-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("64"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("discountForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("api/discount/check"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
  
	ViewData["Title"] = "Xem giỏ hàng";
	Layout = "~/Views/Shared/_Layout.cshtml";
	var returnUrl = Context.Request.Query["ReturnUrl"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container single_product_container\">\r\n\t<div class=\"col-12\">\r\n\t\t<!-- Breadcrumbs -->\r\n\t\t<div class=\"breadcrumbs d-flex flex-row align-items-center\">\r\n\t\t\t<ul>\r\n\t\t\t\t<li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3ba97c2e025f6bca37ad93843f2e89cdd7fd9977374", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
				<li class=""active""><a href=""#""><i class=""fa fa-angle-right"" aria-hidden=""true""></i>Giỏ hàng</a></li>
			</ul>
		</div>
		<div class=""row"">
			<div class=""col-lg-12"">
				<h4 class=""text-uppercase "" style=""border-bottom: 1px solid #DDD;margin-bottom: 30px ;color: #333;"">
					<span>Giỏ hàng</span>
				</h4>
			</div>
		</div>
		<div class=""row"">
			<div class=""col-12"">
				<div class=""card"">
					<div class=""card-body"">
						<div class=""row"">
							<div class=""col-lg-8"">
								<div class=""table-responsive"">
");
#nullable restore
#line 30 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                     if (Model != null && Model.Count() > 0)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3ba97c2e025f6bca37ad93843f2e89cdd7fd9979590", async() => {
                WriteLiteral(@"
											<table class=""table table-borderless table-centered mb-0"">
												<thead class=""table-light"">
													<tr>
														<th></th>
														<th>Tên sản phẩm</th>
														<th>Giá </th>
														<th>Số lượng</th>
														<th>Tổng</th>
														<th style=""width: 50px;""></th>
													</tr>
												</thead>
												<tbody>
");
#nullable restore
#line 45 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                     if (Model != null && Model.Count() > 0)
													{
														foreach (var item in Model)
														{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e3ba97c2e025f6bca37ad93843f2e89cdd7fd99710665", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1648, "~/images/products/", 1648, 18, true);
#nullable restore
#line 50 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 1666, item.product.Thumb, 1666, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 1692, item.product.Title, 1692, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"m-0 d-inline-block align-middle font-16\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"javascript:void(0)\" class=\"text-body\">");
#nullable restore
#line 53 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                                                                                  Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 56 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                                 if (item.product.Discount != null)
																{
																	item.product.Price = item.product.Discount;
																}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 60 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                               Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<input data-mahh=\"");
#nullable restore
#line 62 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                                                 Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-dongia=\"");
#nullable restore
#line 62 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                                                                                       Write(item.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"cartItem cart-plus-minus-box form-control\"");
                BeginWriteAttribute("value", " value=\"", 2399, "\"", 2419, 1);
#nullable restore
#line 62 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2407, item.amount, 2407, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" type=\"number\" max=\"10\"");
                BeginWriteAttribute("value", " value=\"", 2451, "\"", 2471, 1);
#nullable restore
#line 62 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2459, item.amount, 2459, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Qty\" style=\"width: 90px;\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 64 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                               Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"javascript:void(0);\" class=\"removecart btn btn-danger\" data-mahh=\"");
#nullable restore
#line 67 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                                                                                                          Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"> <i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i></a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 70 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
														}
													}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
									}
									else
									{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"										<table class=""table table-borderless table-centered mb-0"">
											<thead class=""table-light"">
												<tr>
													<th></th>
													<th>Tên sản phẩm</th>

													<th>Giá </th>
													<th>Số lượng</th>
													<th>Tổng</th>
													<th style=""width: 50px;""></th>
												</tr>
											</thead>
											<tbody>
											</tbody>
										</table>
");
#nullable restore
#line 93 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div> <!-- end table-responsive-->\r\n\t\t\t\t\t\t\t\t<!-- Add note input-->\r\n\t\t\t\t\t\t\t\t<!-- action buttons-->\r\n\t\t\t\t\t\t\t\t<div class=\"row mt-5\">\r\n\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-sm-12 d-flex justify-content-center\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"text-sm-end\">\r\n");
#nullable restore
#line 102 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                             if (Model != null && Model.Count() > 0)
											{
												

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                 if (User.Identity.IsAuthenticated)
												{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 107 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
												}
												else
												{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"/dang-nhap.html?returnUrl=/checkout.html\" class=\"btn btn-secondary btn-primary-hover\">Thanh toán</a>\r\n");
#nullable restore
#line 111 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
												}

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                 
											}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"										</div>
									</div> <!-- end col -->
								</div> <!-- end row-->
							</div>
							<!-- end col -->

							<div class=""col-lg-4"">
								<div class=""border p-3 mt-4 mt-lg-0 rounded"">
									<h4 class=""header-title mb-3"">Thành tiền</h4>

									<div class=""table-responsive"">
										<table class=""table mb-0"">
											<tbody>
												<tr>
													<td>Tổng :</td>
													<td>");
#nullable restore
#line 128 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                   Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đ</td>
												</tr>
												<tr>
													<td>Mã giảm giá : </td>
													<td>- <span id=""percent"">0%</span></td>
												</tr>
												<tr>
													<td>Phí vận chuyển:</td>
													<td>0 đ</td>
												</tr>

												<tr>
													
													<th>Tổng tất cả:</th>

													<th><span id=""totalall"">");
#nullable restore
#line 143 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                                       Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</span></th>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<!-- end table-responsive -->\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n");
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<div >\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3ba97c2e025f6bca37ad93843f2e89cdd7fd99722520", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"text\" id=\"discountCode\" name=\"discountCode\" class=\"form-control form-control-light\" placeholder=\"Mã giảm giá\">\r\n\t\t\t\t\t\t\t\t\t\t<button id=\"applyButton\" class=\"newsletter_submit_btn trans_200\" type=\"submit\">Áp dụng</button>\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t</div> <!-- end col -->\r\n\r\n\t\t\t\t\t\t</div> <!-- end row -->\r\n\t\t\t\t\t</div> <!-- end card-body-->\r\n\t\t\t\t</div> <!-- end card-->\r\n\t\t\t</div> <!-- end col -->\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
	<script>
		$(function () {
			function loadHeaderCart() {
				$('#miniCart').load(""/AjaxContent/HeaderCart"");
				$('#numberCart').load(""/AjaxContent/NumberCart"");
			}
			$("".removecart"").click(function () {
				var productid = $(this).attr(""data-mahh"");
				$.ajax({
					url: ""api/cart/remove"",
					type: ""POST"",
					dataType: ""JSON"",
					data: { productID: productid },
					success: function (result) {
						if (result.success) {
							loadHeaderCart();//Reload lai gio hang
							location.reload();
						}
					},
					error: function (rs) {
						alert(""Remove Cart Error !"")
					}
				});
			});
			$("".cartItem"").click(function () {
				var productid = $(this).attr(""data-mahh"");
				var soluong = parseInt($(this).val());
				$.ajax({
					url: ""api/cart/update"",
					type: ""POST"",
					dataType: ""JSON"",
					data: {
						productID: productid,
						amount: soluong
					},
					success: function (result) {
						if (result.success) {
							loadHeaderCart();//R");
                WriteLiteral(@"eload lai gio hang
							window.location = 'cart.html';
						}
					},
					error: function (rs) {
						alert(""Cập nhật Cart Error !"")
					}
				});
			});
		});



		$(document).ready(function () {
			$('#discountForm').on('submit', function (e) {
				e.preventDefault(); // Ngăn chặn hành động mặc định của form

				var discountCode = $('#discountCode').val();

				// Gửi yêu cầu AJAX để kiểm tra mã giảm giá
				$.ajax({
					url: $(this).attr('action'), // Lấy đường dẫn từ thuộc tính action của form
					type: $(this).attr('method'), // Lấy phương thức từ thuộc tính method của form
					data: {
						discountCode: discountCode
					},
					success: function (response) {
						// Xử lý phản hồi thành công
						if (response.isValid) {
							// Mã giảm giá hợp lệ, thực hiện các hành động tiếp theo
							alert('Áp mã giảm giá thành công');
							var discountedPrice = response.discountedPrice;

							// Tính toán tổng giá trị giảm giá
							var totalDiscount = (discoun");
                WriteLiteral("tedPrice / 100) * ");
#nullable restore
#line 257 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                                                     Write(Model.Sum(x => x.TotalMoney));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\t\t\t\t\t\t\tvar totalAll = ");
#nullable restore
#line 258 "D:\ASP.Net\KatShop\KatShop\Views\ShoppingCart\Index.cshtml"
                                      Write(Model.Sum(x => x.TotalMoney));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - totalDiscount;

							// Cập nhật giá trị trong bảng
							$('#discountAmount').text(totalDiscount.toLocaleString() + ' đ');
							$('#totalall').text(totalAll.toLocaleString() + ' đ');
							$('#percent').text(discountedPrice + '%');

							// Lưu giá trị totalAll vào session
							$.ajax({
								url: '/ShoppingCart/SaveTotalAll',
								type: 'POST',
								data: { discountedPrice: discountedPrice },
								success: function (response) {
									// Xử lý phản hồi thành công (nếu cần)
									// Sau khi lưu thành công, chuyển hướng đến trang Checkout
									//window.location.href = '/ShoppingCart/Index';
								},
								error: function (xhr, status, error) {
									// Xử lý phản hồi lỗi (nếu cần)
								}
							});
						} else {
							// Mã giảm giá không hợp lệ, hiển thị thông báo lỗi
							alert('Mã giảm giá không hợp lệ hoặc hết thời gian sử dụng');
							// Hiển thị thông báo lỗi cho người dùng
						}
					},
					error: function (xhr, status, erro");
                WriteLiteral(@"r) {
						// Xử lý phản hồi lỗi
						console.log(error);
					}
				});
			});
		});







		//$(document).ready(function () {
		//	$('#discountForm').on('submit', function (e) {
		//		e.preventDefault(); // Ngăn chặn hành động mặc định của form

		//		var discountCode = $('#discountCode').val();

		//		// Gửi yêu cầu AJAX để kiểm tra mã giảm giá
		//		$.ajax({
		//			url: $(this).attr('action'), // Lấy đường dẫn từ thuộc tính action của form
		//			type: $(this).attr('method'), // Lấy phương thức từ thuộc tính method của form
		//			data: $(this).serialize(), // Gửi dữ liệu của form
		//			success: function (response) {
		//				// Xử lý phản hồi thành công
		//				if (response.isValid) {
		//					// Mã giảm giá hợp lệ, thực hiện các hành động tiếp theo
		//					console.log('Mã giảm giá hợp lệ');
		//					console.log('Giá đã giảm: ' + response.discountedPrice);
		//					// Thực hiện các hành động khác ở đây
		//				} else {
		//					// Mã giảm giá không hợp lệ, hiển thị thô");
                WriteLiteral(@"ng báo lỗi
		//					console.log('Mã giảm giá không hợp lệ');
		//					// Hiển thị thông báo lỗi cho người dùng
		//				}
		//			},
		//			error: function (xhr, status, error) {
		//				// Xử lý phản hồi lỗi
		//				console.log(error);
		//			}
		//		});
		//	});
		//});


	</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KatShop.ModelViews.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
