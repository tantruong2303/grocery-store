#pragma checksum "E:\MinhThuan\PRN211\1\grocery-store\Views\Containers\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1177aa8f9bfb502afe6b9eb5085893ff9c63b11d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Home), @"mvc.1.0.view", @"/Views/Containers/Home.cshtml")]
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
#line 1 "E:\MinhThuan\PRN211\1\grocery-store\Views\_ViewImports.cshtml"
using backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MinhThuan\PRN211\1\grocery-store\Views\_ViewImports.cshtml"
using backend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1177aa8f9bfb502afe6b9eb5085893ff9c63b11d", @"/Views/Containers/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c284b32202a794bdcfa4a79fcb7649eb36b840fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\MinhThuan\PRN211\1\grocery-store\Views\Containers\Home.cshtml"
  
    User user = (User)ViewData["user"];



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 10 "E:\MinhThuan\PRN211\1\grocery-store\Views\Containers\Home.cshtml"
     if (user != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Name: ");
#nullable restore
#line 12 "E:\MinhThuan\PRN211\1\grocery-store\Views\Containers\Home.cshtml"
             Write(user.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 13 "E:\MinhThuan\PRN211\1\grocery-store\Views\Containers\Home.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 14 "E:\MinhThuan\PRN211\1\grocery-store\Views\Containers\Home.cshtml"
Write(user);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
