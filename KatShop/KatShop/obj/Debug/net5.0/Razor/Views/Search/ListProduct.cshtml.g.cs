#pragma checksum "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc16b947dee53e6b99d3ac63d6f1f0c568093c60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_ListProduct), @"mvc.1.0.view", @"/Views/Search/ListProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc16b947dee53e6b99d3ac63d6f1f0c568093c60", @"/Views/Search/ListProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ea83cc094ba88dda6627244ef51d9ebd5534d0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Search_ListProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/styles/categories_responsive.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/styles/categories_styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
  


	ViewData["TiTle"] = "Kết quả tìm kiếm cho : " + ViewBag.keyword;
	Layout = "~/Views/Shared/_Layout.cshtml";



#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc16b947dee53e6b99d3ac63d6f1f0c568093c605254", async() => {
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc16b947dee53e6b99d3ac63d6f1f0c568093c606430", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\t<div class=\"container single_product_container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col product_section clearfix\">\r\n\r\n\t\t\t\t<!-- Breadcrumbs -->\r\n\r\n\t\t\t\t<div class=\"breadcrumbs d-flex flex-row align-items-center\">\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t<li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc16b947dee53e6b99d3ac63d6f1f0c568093c607951", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n\t\t\t\t\t\t<li class=\"active\"><a href=\"#\"><i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>");
#nullable restore
#line 25 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                                                                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
					</ul>
				</div>

				<!-- Sidebar -->

				<div class=""sidebar"">
					
					
				</div>

			<!-- Main Content -->

			<div class=""main_content"">

				<!-- Products -->

				<div class=""products_iso"">
					<div class=""row"">
						<div class=""col"">

							<!-- Product Sorting -->
							<!-- Product Grid -->

							<div class=""product-grid"">
");
#nullable restore
#line 50 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                 if (Model != null && Model.Count() > 0)
								{
									foreach (var item in Model)
									{

										string url = $"/{item.Alias}-{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<!-- Product 2 -->\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"product-item women\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"product product_filter\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product_image\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc16b947dee53e6b99d3ac63d6f1f0c568093c6010744", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1480, "~/images/products/", 1480, 18, true);
#nullable restore
#line 60 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
AddHtmlAttributeValue("", 1498, item.Thumb, 1498, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 60 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
AddHtmlAttributeValue("", 1516, item.Title, 1516, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"favorite\"></div>\r\n");
#nullable restore
#line 63 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                                 if (item.HomeFlag)
												{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product_bubble product_bubble_left product_bubble_green d-flex flex-column align-items-center\"><span>new</span></div>\r\n");
#nullable restore
#line 66 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
												}

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                                 if (item.BestSaller)
												{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product_bubble product_bubble_right product_bubble_red d-flex flex-column align-items-center\"><span>sale</span></div>\r\n");
#nullable restore
#line 70 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
												}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product_info\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<h6 class=\"product_name\"><a");
            BeginWriteAttribute("href", " href=\"", 2091, "\"", 2102, 1);
#nullable restore
#line 73 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
WriteAttributeValue("", 2098, url, 2098, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                                                                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n");
#nullable restore
#line 74 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                                     if (item.Discount != null)
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product_price\">");
#nullable restore
#line 76 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                                                              Write(item.Discount.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 76 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                                                                                                          Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></div>\r\n");
#nullable restore
#line 77 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
													}
													else
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product_price\">");
#nullable restore
#line 80 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                                                              Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</div>\r\n");
#nullable restore
#line 81 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
													}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"red_button add_to_cart_button\"><a");
            BeginWriteAttribute("href", " href=\"", 2579, "\"", 2590, 1);
#nullable restore
#line 84 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
WriteAttributeValue("", 2586, url, 2586, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem sản phẩm</a></div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 86 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
									}
								}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<h3>Không có sản phẩm cho từ khóa : ");
#nullable restore
#line 88 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
                                                                   Write(ViewBag.keyword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 89 "D:\ASP.Net\KatShop\KatShop\Views\Search\ListProduct.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"							</div>

							<!-- Product Sorting -->


							<div class=""col-12 d-flex justify-content-center mt-5"">
								<nav aria-label=""Page navigation example"">
									<ul class=""pagination"">

									

									</ul>
								</nav>
							</div>


						</div>

					</div>
				</div>
			</div>
		</div>

	</div>
</div>


<!-- Benefit -->

<div class=""benefit"">
	<div class=""container"">
		<div class=""row benefit_row"">
			<div class=""col-lg-3 benefit_col"">
				<div class=""benefit_item d-flex flex-row align-items-center"">
					<div class=""benefit_icon""><i class=""fa fa-truck"" aria-hidden=""true""></i></div>
					<div class=""benefit_content"">
						<h6>free shipping</h6>
						<p>Suffered Alteration in Some Form</p>
					</div>
				</div>
			</div>
			<div class=""col-lg-3 benefit_col"">
				<div class=""benefit_item d-flex flex-row align-items-center"">
					<div class=""benefit_icon""><i class=""fa fa-money"" aria-hidden=""true""></i></div>
					<div class=""benefit_content"">
");
            WriteLiteral(@"						<h6>cach on delivery</h6>
						<p>The Internet Tend To Repeat</p>
					</div>
				</div>
			</div>
			<div class=""col-lg-3 benefit_col"">
				<div class=""benefit_item d-flex flex-row align-items-center"">
					<div class=""benefit_icon""><i class=""fa fa-undo"" aria-hidden=""true""></i></div>
					<div class=""benefit_content"">
						<h6>45 days return</h6>
						<p>Making it Look Like Readable</p>
					</div>
				</div>
			</div>
			<div class=""col-lg-3 benefit_col"">
				<div class=""benefit_item d-flex flex-row align-items-center"">
					<div class=""benefit_icon""><i class=""fa fa-clock-o"" aria-hidden=""true""></i></div>
					<div class=""benefit_content"">
						<h6>opening all week</h6>
						<p>8AM - 09PM</p>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591