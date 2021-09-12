#pragma checksum "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752e28c44ea6b6a87769bb2640d857e5d022804d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Auth_Register), @"mvc.1.0.view", @"/Views/Containers/Auth/Register.cshtml")]
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
#line 1 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\_ViewImports.cshtml"
using Backend.Views.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\_ViewImports.cshtml"
using Backend.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"752e28c44ea6b6a87769bb2640d857e5d022804d", @"/Views/Containers/Auth/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4787e2bf596517cbd42acf11f503cf4b3e860901", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Auth_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-1 px-4 py-16 mx-2 space-y-8 bg-white rounded-md shadow-lg bg-opacity-90 md:mx-0 md:flex-none fade-in"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
  
    ViewData["Title"] = Routers.Register.Title;
    var username = new FormField() { Label = "Username", Field = "username", Type = "text" };
    var password = new FormField() { Label = "Password", Field = "password", Type = "password" };
    var name = new FormField() { Label = "Name", Field = "name", Type = "text" };
    var confirmPassword = new FormField() { Label = "Confirm Password", Field = "confirmPassword", Type = "password" };
    var email = new FormField() { Label = "Email", Field = "email", Type = "text" };
    var address = new FormField() { Label = "Address", Field = "address", Type = "text" };
    var phone = new FormField() { Label = "Phone", Field = "phone", Type = "text" };
    var registerBtn = new FormField() { Label = "Register" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"flex items-center justify-center flex-1 py-2 bg-gradient-to-r from-yellow-400 via-red-500 to-pink-500\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "752e28c44ea6b6a87769bb2640d857e5d022804d5523", async() => {
                WriteLiteral("\r\n        <h1 class=\"text-4xl font-semibold text-center\">Regsiter Account</h1>\r\n        ");
#nullable restore
#line 18 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
   Write(await Html.PartialAsync("~/Views/Components/Form/FormMsg.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"space-y-4\">\r\n            <div class=\"justify-between md:flex md:space-x-2\">\r\n                <div class=\"md:w-64\">\r\n                    ");
#nullable restore
#line 22 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"md:w-64\">\r\n                    ");
#nullable restore
#line 25 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"justify-between md:space-x-2 md:flex\">\r\n                <div class=\"md:w-64\">\r\n                    ");
#nullable restore
#line 30 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"md:w-64\">\r\n                    ");
#nullable restore
#line 33 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", confirmPassword));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"justify-between md:flex md:space-x-2\">\r\n                <div class=\"md:w-64\">\r\n                    ");
#nullable restore
#line 39 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"md:w-64\">\r\n                    ");
#nullable restore
#line 42 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 46 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
           Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        ");
#nullable restore
#line 50 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
   Write(await Html.PartialAsync("~/Views/Components/Form/FormBtn.cshtml", registerBtn));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "E:\server\grocery-store\tailwind-fast-kit\hello\grocery-store\Views\Containers\Auth\Register.cshtml"
AddHtmlAttributeValue("", 934, Routers.Register.Link, 934, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
