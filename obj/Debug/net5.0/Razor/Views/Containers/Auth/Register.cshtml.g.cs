#pragma checksum "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f618eb64fb210004ce257b25f469b47f38378ae"
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
#line 1 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\_ViewImports.cshtml"
using Backend.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f618eb64fb210004ce257b25f469b47f38378ae", @"/Views/Containers/Auth/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48f5f22d9a6e26ef591873adf0210c7162d00e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Auth_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Rubick Tailwind HTML Admin Template"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-1/2 -mt-16 -intro-x"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ui/images/illustration.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registerForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-full px-5 py-8 mx-auto my-auto space-y-4 bg-white rounded-md shadow-md xl:ml-20 dark:bg-dark-1 xl:bg-transparent sm:px-8 xl:p-0 xl:shadow-none sm:w-3/4 lg:w-2/4 xl:w-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
  
    this.ViewData["Title"] = Routers.Register.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"flex-1 py-6 login\">\r\n    <div class=\"container sm:px-10\">\r\n        <div class=\"block grid-cols-2 gap-4 xl:grid\">\r\n            <!-- BEGIN: Login Info -->\r\n            <div class=\"flex-col hidden min-h-screen xl:flex\">\r\n                ");
#nullable restore
#line 11 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
           Write(await Html.PartialAsync("../../Components/Navbar/Logo.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"my-auto\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f618eb64fb210004ce257b25f469b47f38378ae6375", async() => {
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
                    <div class=""mt-10 text-4xl font-medium leading-tight text-white -intro-x"">
                        A few more clicks to
                        <br>
                        sign in to your account.
                    </div>
                    <div class=""mt-5 text-lg text-white -intro-x text-opacity-70 dark:text-gray-500"">Thank for your
                        visit</div>
                </div>
            </div>
            <!-- END: Login Info -->
            <!-- BEGIN: Login Form -->
            <div class=""flex h-screen py-5 xl:h-auto xl:py-0 xl:my-0"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f618eb64fb210004ce257b25f469b47f38378ae8191", async() => {
                WriteLiteral("\r\n                    <h2 class=\"text-2xl font-bold text-center intro-x xl:text-3xl xl:text-left\">\r\n                        Sign Up\r\n                    </h2>\r\n                    <div class=\"space-y-2 intro-x\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/FormMessage.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 34 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml", new {Label="Name",
                        Field="name",Type="text",Value=""}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 36 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml", new {Label="Username",
                        Field="username",Type="text",Value=""}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml",new {Label="Password",
                        Field="password",Type="password",Value=""}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 40 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml",new {Label="Confirm Password",
                        Field="confirmPassword",Type="password",Value=""}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 42 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml", new {Label="Phone",
                        Field="phone",Type="text",Value=""}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 44 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml", new {Label="Email",
                        Field="email",Type="text",Value=""}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 46 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml", new {Label="Address",
                        Field="address",Type="text",Value=""}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"flex space-x-2 \">\r\n                        ");
#nullable restore
#line 51 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/FormBtn.cshtml","Sign Up"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3187, "\"", 3213, 1);
#nullable restore
#line 52 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Containers\Auth\Register.cshtml"
WriteAttributeValue("", 3194, Routers.Login.Link, 3194, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"flex-1 px-4 py-3 align-top btn btn-outline-secondary \">Sign\r\n                            In</a>\r\n                    </div>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <!-- END: Login Form -->\r\n        </div>\r\n    </div>\r\n\r\n    <!-- BEGIN: JS Assets-->\r\n\r\n    <!-- END: JS Assets-->\r\n\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n<script src=\"/js/register.js\"></script>\r\n\r\n");
            }
            );
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
