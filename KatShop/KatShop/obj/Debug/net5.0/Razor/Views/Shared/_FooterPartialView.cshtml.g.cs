#pragma checksum "D:\ASP.Net\KatShop\KatShop\Views\Shared\_FooterPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1af27d330f36b8dc9f06a6ef09d6a0d2277113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartialView), @"mvc.1.0.view", @"/Views/Shared/_FooterPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1af27d330f36b8dc9f06a6ef09d6a0d2277113", @"/Views/Shared/_FooterPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ea83cc094ba88dda6627244ef51d9ebd5534d0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__FooterPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"	<!-- Newsletter -->

<div class=""newsletter"">
	
	<div class=""container"">
		<div class=""row"">
			<div class=""col-lg-6"">
				<div class=""newsletter_text d-flex flex-column justify-content-center align-items-lg-start align-items-md-center text-center"">
					
					<p>ĐĂNG KÝ NHẬN TIN / ƯU ĐÃI TỪ KAT</p>
				</div>
			</div>
			<div class=""col-lg-6"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1af27d330f36b8dc9f06a6ef09d6a0d22771134995", async() => {
                WriteLiteral(@"
					<div class=""newsletter_form d-flex flex-md-row flex-column flex-xs-column align-items-center justify-content-lg-end justify-content-center"">
						<input id=""newsletter_email"" type=""email"" placeholder=""Địa chỉ email của bạn"" required=""required"" data-error=""Valid email is required."">
						<button id=""newsletter_submit"" type=""submit"" class=""newsletter_submit_btn trans_300"" value=""Submit"">Gửi</button>
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
		</div>
	</div>
</div>

<footer class=""footer"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-lg-6"">
				<div class=""footer_nav_container d-flex flex-sm-row flex-column align-items-center justify-content-lg-start justify-content-center text-center"">
					<ul class=""footer_nav"">
						<li><a href=""blogs.html"">Bài viết</a></li>
						<li><a href=""about.html"">Về Kat</a></li>
						<li><a href=""contact.html"">Liên hệ</a></li>
					</ul>
				</div>
			</div>
			<div class=""col-lg-6"">
				<div class=""footer_social d-flex flex-row align-items-center justify-content-lg-end justify-content-center"">
					<ul>
						<li><a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a></li>
						<li><a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a></li>
						<li><a href=""#""><i class=""fa fa-instagram"" aria-hidden=""true""></i></a></li>
						<li><a href=""#""><i class=""fa fa-skype"" aria-hidden=""true""></i></a></li>
						<li><a href=""#""><i class=""fa fa-pint");
            WriteLiteral(@"erest"" aria-hidden=""true""></i></a></li>
					</ul>
				</div>
				
			</div>

		</div>
		<div class=""row"">
			<div class=""col-lg-6"">
				<div class=""footer_nav_container"">


					<div id=""fb-root""></div>
					<script async defer crossorigin=""anonymous"" src=""https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v17.0&appId=610644557764515&autoLogAppEvents=1"" nonce=""s2DHXfay""></script>
					<div class=""fb-page"" data-href=""https://www.facebook.com/tuidathat.vn"" data-tabs=""timeline"" data-width=""500"" data-height="""" data-small-header=""false"" data-adapt-container-width=""true"" data-hide-cover=""false"" data-show-facepile=""false""><blockquote cite=""https://www.facebook.com/tuidathat.vn"" class=""fb-xfbml-parse-ignore""><a href=""https://www.facebook.com/tuidathat.vn"">Túi da thật Kat</a></blockquote></div>

				</div>

			</div>
			<div class=""col-lg-6 t"">
				<div class=""footer_nav_container float-right mb-0"">

				&copy; 2023 - KatShop - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1af27d330f36b8dc9f06a6ef09d6a0d22771138866", async() => {
                WriteLiteral("điều khoản");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t</div>\r\n\t\t\t\t\r\n\t\t\t</div>\r\n\t\t\r\n\t\t\t\r\n\t\t</div>\r\n\t</div>\r\n</footer>\r\n");
            WriteLiteral(@"<style>
	.scroll{
    color:#fff;
    margin-top:100px;
}

#toTopBtn {
     position: fixed;
    bottom: 100px;
    right: 39px;
    z-index: 98;
    padding: 21px;
    background-color: hsla(5,76%,62%,.8);
    
}

.js .cd-top--fade-out {
    opacity: .5;
}

.js .cd-top--is-visible {
    visibility: visible;
    opacity: 1;
}

.js .cd-top {
    visibility: hidden;
    opacity: 0;
    transition: opacity .3s,visibility .3s,background-color .3s;
}

.cd-top {
    position: fixed;
    bottom: 20px;
    bottom: var(--cd-back-to-top-margin);
    right: 20px;
    right: var(--cd-back-to-top-margin);
    display: inline-block;
    height: 40px;
    height: var(--cd-back-to-top-size);
    width: 40px;
    width: var(--cd-back-to-top-size);
    box-shadow: 0 0 10px rgba(0,0,0,.05) !important;
    background: url(https://res.cloudinary.com/dxfq3iotg/image/upload/v1571057658/cd-top-arrow.svg) no-repeat center 50%;
    background-color: hsla(5,76%,62%,.8);
    background-color:");
            WriteLiteral(@" hsla(var(--cd-color-3-h),var(--cd-color-3-s),var(--cd-color-3-l),0.8);
}
</style>
<script>

$(document).ready(function() {
  $(window).scroll(function() {
    if ($(this).scrollTop() > 20) {
      $('#toTopBtn').fadeIn();
    } else {
      $('#toTopBtn').fadeOut();
    }
  });

  $('#toTopBtn').click(function() {
    $(""html, body"").animate({
      scrollTop: 0
    }, 1000);
    return false;
  });
});
</script>

<script type=""text/javascript"">
	var Tawk_API = Tawk_API || {}, Tawk_LoadStart = new Date();
	(function () {
		var s1 = document.createElement(""script""), s0 = document.getElementsByTagName(""script"")[0];
		s1.async = true;
		s1.src = 'https://embed.tawk.to/647f5d80cc26a871b020fe0c/1h28oagaa';
		s1.charset = 'UTF-8';
		s1.setAttribute('crossorigin', '*');
		s0.parentNode.insertBefore(s1, s0);
	})();
</script>");
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
