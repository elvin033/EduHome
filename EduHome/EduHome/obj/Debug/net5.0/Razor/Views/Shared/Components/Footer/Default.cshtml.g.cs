#pragma checksum "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afd0edebffbd39faea7398329a1fa8703c294d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afd0edebffbd39faea7398329a1fa8703c294d1", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b2fe86bc8a0f78c001cdfcbac06fe2ca7e5a6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("eduhome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" FooterVM\r\n<footer class=\"footer-area\">\r\n\t<div class=\"main-footer\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n\t\t\t\t\t<div class=\"single-widget pr-60\">\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml"
                         foreach (FooterBio bio in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"footer-logo pb-25\">\r\n\t\t\t\t\t\t\t\t<a href=\"index.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2afd0edebffbd39faea7398329a1fa8703c294d14555", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 339, "~/img/logo/", 339, 11, true);
#nullable restore
#line 11 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 350, bio.FooterLogo, 350, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<p>");
#nullable restore
#line 13 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml"
                          Write(bio.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"footer-social\">\r\n\t\t\t\t\t\t\t<ul>\r\n");
#nullable restore
#line 17 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml"
                                 foreach (SocialMedia social in Model)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li><a");
            BeginWriteAttribute("href", " href=\"", 563, "\"", 582, 1);
#nullable restore
#line 19 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 570, social.Link, 570, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 586, "\"", 622, 3);
            WriteAttributeValue("", 594, "zmdi", 594, 4, true);
            WriteAttributeValue(" ", 598, "zmdi-", 599, 6, true);
#nullable restore
#line 19 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 604, social.MediaImage, 604, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\n");
#nullable restore
#line 20 "C:\Users\User\Desktop\kurs\ASP.NET\EduHome\EduHome\Views\Shared\Components\Footer\Default.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"							</ul>
						</div>
					</div>
				</div>
				<div class=""col-md-3 col-sm-6 col-xs-12"">
					<div class=""single-widget"">
						<h3>information</h3>
						<ul>
							<li><a href=""#"">addmission</a></li>
							<li><a href=""#"">Academic Calender</a></li>
							<li><a href=""event.html"">Event List</a></li>
							<li><a href=""#"">Hostel &amp; Dinning</a></li>
							<li><a href=""#"">TimeTable</a></li>
						</ul>
					</div>
				</div>
				<div class=""col-md-2 col-sm-6 col-xs-12"">
					<div class=""single-widget"">
						<h3>useful links</h3>
						<ul>
							<li><a href=""course.html"">our courses</a></li>
							<li><a href=""about.html"">about us</a></li>
							<li><a href=""teacher.html"">teachers &amp; faculty</a></li>
							<li><a href=""#"">teams &amp; conditions</a></li>
							<li><a href=""event.html"">our events</a></li>
						</ul>
					</div>
				</div>
				<div class=""col-md-3 col-sm-6 col-xs-12"">
					<div class=""single-widget"">
						<h3>get in touch</h3>
						<p>Your a");
            WriteLiteral(@"ddress goes here, Street<br>City, Roadno 785 New York</p>
						<p>+880  548  986  898  87<br>+880  659  785  658  98</p>
						<p>info@eduhome.com<br>www.eduhome.com</p>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""footer-bottom text-center"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-xs-12"">
					<p>Copyright ?? <a href=""#"" target=""_blank"">HasTech</a> 2017. All Right Reserved By Hastech.</p>
				</div>
			</div>
		</div>
	</div>
</footer>
");
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
