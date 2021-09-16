#pragma checksum "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e028d12fe45cc95ee6bc942366cfd21e9f3cfbec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Product_Product), @"mvc.1.0.view", @"/Views/Containers/Product/Product.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\grocery-store\Views\_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\grocery-store\Views\_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\grocery-store\Views\_ViewImports.cshtml"
using Backend.Views.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Desktop\grocery-store\Views\_ViewImports.cshtml"
using Backend.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e028d12fe45cc95ee6bc942366cfd21e9f3cfbec", @"/Views/Containers/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4787e2bf596517cbd42acf11f503cf4b3e860901", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
  
    ViewData["Title"] = Routers.Product.Title;
    List<Product> products = (List<Product>)ViewData["products"];


    var min = new FormField() { Label = "Min", Field = "min", Type = "number", Value = 0 };
    var max = new FormField() { Label = "Max", Field = "max", Type = "number", Value = 99999 };
    var name = new FormField() { Label = "Name", Field = "name", Type = "text", Value = "" };
    var categoryId = new FormField() { Label = "CategoryId", Field = "categoryId", Type = "text", Value = "" };

    var createBtn = new FormField() { Label = "Search" };


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"p-2 \">\r\n    ");
#nullable restore
#line 16 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
Write(await Html.PartialAsync("~/Views/Components/Form/FormMsg.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e028d12fe45cc95ee6bc942366cfd21e9f3cfbec4927", async() => {
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 20 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
   Write(await Html.PartialAsync("~/Views/Components/Form/FormMsg.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"space-y-4\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
       Write(await Html.PartialAsync("~/Views/Components/Form/FormMsg.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
       Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", min));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
       Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", max));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
       Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 26 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
       Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", categoryId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        ");
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
   Write(await Html.PartialAsync("~/Views/Components/Form/FormBtn.cshtml", createBtn));

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
#line 18 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
AddHtmlAttributeValue("", 714, Routers.Home.Link, 714, 18, false);

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
            WriteLiteral("\r\n    <div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1420, "\"", 1454, 1);
#nullable restore
#line 31 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
WriteAttributeValue("", 1427, Routers.CreateProduct.Link, 1427, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
            class=""inline-block p-2 font-medium text-white duration-300 bg-blue-600 rounded-sm hover:bg-blue-800"">Create
            New Product</a>
    </div>
    <table class=""my-2 bg-white border border-black fade-in"">
        <thead>
            <tr>
                <th class=""p-2 border border-black"">ProductId</th>
                <th class=""p-2 border border-black"">Name</th>
                <th class=""p-2 border border-black"">Image</th>
                <th class=""p-2 border border-black"">Category</th>
                <th class=""p-2 border border-black"">Description</th>
                <th class=""p-2 border border-black"">Status</th>
                <th class=""p-2 border border-black"">OriginalPrice</th>
                <th class=""p-2 border border-black"">RetailPrice</th>
                <th class=""p-2 border border-black"">CreateDate</th>
                <th class=""p-2 border border-black"">Quantity</th>
                <th class=""p-2 border border-black"">Update</th>

            </tr>
");
            WriteLiteral("        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
             foreach (var product in products)
            {

                var updateLink = $"{@Routers.UpdateProduct.Link}?productId={@product.ProductId}";
                var activeColor = product.Status == ProductStatus.ACTIVE ? "text-green-500" : "text-red-500";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"p-2 text-center border border-black max-h-16\">");
#nullable restore
#line 59 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
                                                                        Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center border border-black max-h-16\">");
#nullable restore
#line 60 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
                                                                        Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center border border-black max-h-16\">\r\n                        <div class=\"h-16\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3165, "\"", 3188, 1);
#nullable restore
#line 63 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
WriteAttributeValue("", 3171, product.ImageUrl, 3171, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3189, "\"", 3208, 1);
#nullable restore
#line 63 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
WriteAttributeValue("", 3195, product.Name, 3195, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"object-cover w-full h-full\" />\r\n                        </div>\r\n                    </td>\r\n                    <td class=\"p-2 text-center border border-black\">");
#nullable restore
#line 66 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
                                                               Write(product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center lowercase border border-black first-letter \">");
#nullable restore
#line 67 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
                                                                                       Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 3547, "\"", 3627, 8);
            WriteAttributeValue("", 3555, "p-2", 3555, 3, true);
            WriteAttributeValue(" ", 3558, "text-center", 3559, 12, true);
            WriteAttributeValue(" ", 3570, "lowercase", 3571, 10, true);
            WriteAttributeValue(" ", 3580, "border", 3581, 7, true);
            WriteAttributeValue(" ", 3587, "border-black", 3588, 13, true);
            WriteAttributeValue(" ", 3600, "first-letter", 3601, 13, true);
#nullable restore
#line 68 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
WriteAttributeValue(" ", 3613, activeColor, 3614, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3626, "", 3627, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
                                                                                                    Write(product.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"p-2 text-center lowercase border border-black first-letter \">");
#nullable restore
#line 70 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
                                                                                       Write(product.OriginalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center lowercase border border-black first-letter \">");
#nullable restore
#line 71 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
                                                                                       Write(product.RetailPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center lowercase border border-black first-letter \">");
#nullable restore
#line 72 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
                                                                                       Write(product.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center lowercase border border-black first-letter \">");
#nullable restore
#line 73 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
                                                                                       Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center border border-black\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4243, "\"", 4261, 1);
#nullable restore
#line 75 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"
WriteAttributeValue("", 4250, updateLink, 4250, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        class=\"inline-block p-2 font-medium text-white duration-300 bg-blue-600 rounded-sm hover:bg-blue-800\">Update</a>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Lenovo\Desktop\grocery-store\Views\Containers\Product\Product.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
