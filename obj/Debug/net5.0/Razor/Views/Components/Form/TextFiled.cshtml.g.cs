#pragma checksum "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Components\Form\TextFiled.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74d51be9a41a865ad04431fd45064c3ccf2d5d73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_Form_TextFiled), @"mvc.1.0.view", @"/Views/Components/Form/TextFiled.cshtml")]
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
using Backend.Views.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\_ViewImports.cshtml"
using Backend.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d51be9a41a865ad04431fd45064c3ccf2d5d73", @"/Views/Components/Form/TextFiled.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4787e2bf596517cbd42acf11f503cf4b3e860901", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_Form_TextFiled : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Components\Form\TextFiled.cshtml"
  
    var errorField = $"{Model.Field}Error";
    var value = Model.Value ?? "";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"space-y-1\">\r\n    <label class=\"font-medium\"");
            BeginWriteAttribute("htmlFor", " htmlFor=\"", 149, "\"", 171, 1);
#nullable restore
#line 9 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Components\Form\TextFiled.cshtml"
WriteAttributeValue("", 159, Model.Field, 159, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 10 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Components\Form\TextFiled.cshtml"
   Write(Model.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </label>\r\n    ");
#nullable restore
#line 12 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Components\Form\TextFiled.cshtml"
Write(Html.TextBox($"{@Model.Field}", value,null, new {
    @class = "block w-full px-2 py-1 border rounded-sm focus:outline-none",
    @type = @Model.Type,
    @id = @Model.Field
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Components\Form\TextFiled.cshtml"
     if (ViewData[@errorField] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-red-500\">");
#nullable restore
#line 19 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Components\Form\TextFiled.cshtml"
                           Write(Model.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Components\Form\TextFiled.cshtml"
                                        Write(ViewData[@errorField]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\ACER\Desktop\Grocery\grocery-store\Views\Components\Form\TextFiled.cshtml"
    }

#line default
#line hidden
#nullable disable
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
