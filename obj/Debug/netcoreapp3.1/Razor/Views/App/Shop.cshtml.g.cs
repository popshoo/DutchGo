#pragma checksum "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e195390c39d63cd53666d1548eee08adccf16d49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
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
#line 1 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\_ViewImports.cshtml"
using DutchGo.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\_ViewImports.cshtml"
using DutchGo.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e195390c39d63cd53666d1548eee08adccf16d49", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4b997641c6e49ed02022405f699301be35a819", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Shop</h1>\r\n<p>Count: ");
#nullable restore
#line 3 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
     Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"col-md-3\">\r\n        <div class=\"border bg-light rounded p-1\">\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e195390c39d63cd53666d1548eee08adccf16d493993", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 230, "~/img/", 230, 6, true);
#nullable restore
#line 9 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 236, p.ArtId, 236, 10, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 246, ".jpg", 246, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 9 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 275, p.Title, 275, 8, false);

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
            WriteLiteral("\r\n        <h3>");
#nullable restore
#line 10 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
       Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
                     Write(p.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n          <ul class=\"product-props\">\r\n              <li>Price: $");
#nullable restore
#line 12 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
                     Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li>Artist: ");
#nullable restore
#line 13 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
                     Write(p.Artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li>Title: ");
#nullable restore
#line 14 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
                    Write(p.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li>Descripcion: ");
#nullable restore
#line 15 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
                          Write(p.ArtDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n          </ul>\r\n        <button id=\"buyButton\" class=\"btn btn-success\">Buy</button>\r\n      </div>\r\n      </div>\r\n");
#nullable restore
#line 20 "C:\Users\PINOCHETREBOR\source\repos\DutchGo\Views\App\Shop.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
