#pragma checksum "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53e7cbe52f8b8ff821e9604abfe6adaafc92943c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_Navbar), @"mvc.1.0.view", @"/Views/Components/Navbar.cshtml")]
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
#line 1 "E:\MinhThuan\PRN211\5\grocery-store\Views\_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MinhThuan\PRN211\5\grocery-store\Views\_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MinhThuan\PRN211\5\grocery-store\Views\_ViewImports.cshtml"
using Backend.Views.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MinhThuan\PRN211\5\grocery-store\Views\_ViewImports.cshtml"
using Backend.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e7cbe52f8b8ff821e9604abfe6adaafc92943c", @"/Views/Components/Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4787e2bf596517cbd42acf11f503cf4b3e860901", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("momo store"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-full h-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
  
    User user = (User)ViewData["user"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"fixed z-50 flex items-center justify-between w-full px-4 py-2 bg-white shadow-lg md:px-8\">\r\n    <a class=\"flex items-center justify-between space-x-2\"");
            BeginWriteAttribute("href", " href=\"", 226, "\"", 251, 1);
#nullable restore
#line 13 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
WriteAttributeValue("", 233, Routers.Home.Link, 233, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"w-16 h-16\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "53e7cbe52f8b8ff821e9604abfe6adaafc92943c5257", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <h1 class=""hidden md:block"">
            <span class=""text-4xl font-semibold text-purple-700"">Mono</span>
            <span class=""text-4xl font-semibold text-pink-600"">Grocery</span>
        </h1>
    </a>
    <button class=""space-y-2 focus:outline-none md:hidden"" id=""navbar-btn"">
        <div class=""w-12 h-2 duration-300 transform bg-blue-500 rounded-lg "" id=""navbar-btn-1"">
        </div>
        <div class=""w-12 h-2 duration-300 transform bg-blue-500 rounded-lg "" id=""navbar-btn-2"">
        </div>
    </button>
    <div id=""navbar-menu""
        class=""absolute left-0 flex flex-col w-full pb-4 space-y-2 duration-300 origin-top transform scale-y-0 bg-white border shadow-lg md:space-y-0 md:scale-y-100 md:space-x-2 md:border-none top-full md:w-auto md:flex-row md:shadow-none md:pb-0 md:static"">
");
#nullable restore
#line 30 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
         if (user == null)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"px-4 py-1 text-lg font-semibold duration-300 hover:bg-blue-500 md:hover:bg-transparent hover:text-white md:hover:text-blue-600\"");
            BeginWriteAttribute("href", "\r\n            href=\"", 1405, "\"", 1444, 1);
#nullable restore
#line 35 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
WriteAttributeValue("", 1425, Routers.Login.Link, 1425, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Login\r\n            </a>\r\n            <a class=\"px-4 py-1 text-lg font-semibold duration-300 hover:bg-blue-500 md:hover:bg-transparent hover:text-white md:hover:text-blue-600\"");
            BeginWriteAttribute("href", "\r\n            href=\"", 1638, "\"", 1680, 1);
#nullable restore
#line 39 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
WriteAttributeValue("", 1658, Routers.Register.Link, 1658, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Register\r\n            </a>\r\n");
#nullable restore
#line 42 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"px-4 py-1 text-lg font-semibold duration-300 hover:bg-blue-500 md:hover:bg-transparent hover:text-white md:hover:text-blue-600\"");
            BeginWriteAttribute("href", "\r\n            href=\"", 1913, "\"", 1951, 1);
#nullable restore
#line 46 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
WriteAttributeValue("", 1933, Routers.User.Link, 1933, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                User\r\n            </a>\r\n            <a class=\"px-4 py-1 text-lg font-semibold duration-300 hover:bg-blue-500 md:hover:bg-transparent hover:text-white md:hover:text-blue-600\"");
            BeginWriteAttribute("href", "\r\n            href=\"", 2144, "\"", 2186, 1);
#nullable restore
#line 50 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
WriteAttributeValue("", 2164, Routers.Category.Link, 2164, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Category\r\n            </a>\r\n            <a class=\"px-4 py-1 text-lg font-semibold duration-300 hover:bg-blue-500 md:hover:bg-transparent hover:text-white md:hover:text-blue-600\"");
            BeginWriteAttribute("href", "\r\n            href=\"", 2383, "\"", 2424, 1);
#nullable restore
#line 54 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
WriteAttributeValue("", 2403, Routers.Product.Link, 2403, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Product\r\n            </a> <a\r\n            class=\"px-4 py-1 text-lg font-semibold duration-300 hover:bg-blue-500 md:hover:bg-transparent hover:text-white md:hover:text-blue-600\"");
            BeginWriteAttribute("href", "\r\n            href=\"", 2620, "\"", 2659, 1);
#nullable restore
#line 58 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
WriteAttributeValue("", 2640, Routers.Order.Link, 2640, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Order\r\n            </a>\r\n            <a class=\"px-4 py-1 text-lg font-semibold duration-300 hover:bg-blue-500 md:hover:bg-transparent hover:text-white md:hover:text-blue-600\"");
            BeginWriteAttribute("href", "\r\n            href=\"", 2853, "\"", 2893, 1);
#nullable restore
#line 62 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
WriteAttributeValue("", 2873, Routers.Logout.Link, 2873, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Logout\r\n            </a>\r\n            <a class=\"px-4 py-1 text-lg font-semibold duration-300 hover:bg-blue-500 md:hover:bg-transparent hover:text-white md:hover:text-blue-600\"");
            BeginWriteAttribute("href", "\r\n            href=\"", 3088, "\"", 3126, 1);
#nullable restore
#line 66 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
WriteAttributeValue("", 3108, Routers.Cart.Link, 3108, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Shopping Cart\r\n            </a>\r\n");
#nullable restore
#line 69 "E:\MinhThuan\PRN211\5\grocery-store\Views\Components\Navbar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>");
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
