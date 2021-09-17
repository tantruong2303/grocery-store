#pragma checksum "E:\server\grocery-store\Views\Containers\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94fce4cf7ca5a8108e0065a6ae29446c9542375f"
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
#line 1 "E:\server\grocery-store\Views\_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\server\grocery-store\Views\_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\server\grocery-store\Views\_ViewImports.cshtml"
using Backend.Views.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\server\grocery-store\Views\_ViewImports.cshtml"
using Backend.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94fce4cf7ca5a8108e0065a6ae29446c9542375f", @"/Views/Containers/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4787e2bf596517cbd42acf11f503cf4b3e860901", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Backend.Models.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\server\grocery-store\Views\Containers\Home.cshtml"
  
    ViewData["Title"] = Routers.Home.Title;
    List<Product> products = (List<Product>)ViewData["products"];
    List<Product> carts = (List<Product>)ViewData["cartItems"];
    Double total = 0;

    var min = new FormField() { Label = "Min", Field = "min", Type = "number", Value = 0 };
    var max = new FormField() { Label = "Max", Field = "max", Type = "number", Value = 0 };
    var name = new FormField() { Label = "Name", Field = "name", Type = "text", Value = "" };
    var categoryId = new FormField() { Label = "CategoryId", Field = "categoryId", Type = "text", Value = "" };
    var createBtn = new FormField() { Label = "Search" };
    var createBtnCart = new FormField() { Label = "Order Now" };


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"flex flex-col justify-center flex-1 px-2 py-8 mb-48 space-y-4 md:flex-row md:space-x-4 md:space-y-0\">\r\n    <div class=\"flex-1 space-y-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94fce4cf7ca5a8108e0065a6ae29446c9542375f5101", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"space-y-4\">\r\n\r\n                <div class=\"flex space-x-4 justify-items-stretch\">\r\n                    ");
#nullable restore
#line 26 "E:\server\grocery-store\Views\Containers\Home.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", min));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 27 "E:\server\grocery-store\Views\Containers\Home.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", max));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"flex space-x-4 justify-items-stretch\">\r\n                    ");
#nullable restore
#line 30 "E:\server\grocery-store\Views\Containers\Home.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/TextFiled.cshtml", name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "E:\server\grocery-store\Views\Containers\Home.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/FormCategories.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"w-32\">\r\n                    ");
#nullable restore
#line 34 "E:\server\grocery-store\Views\Containers\Home.cshtml"
               Write(await Html.PartialAsync("~/Views/Components/Form/FormBtn.cshtml", createBtn));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        ");
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
#line 21 "E:\server\grocery-store\Views\Containers\Home.cshtml"
AddHtmlAttributeValue("", 954, Routers.Home.Link, 954, 18, false);

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
            WriteLiteral("\r\n\r\n\r\n        <h1 class=\"text-xl font-semibold \">Product List</h1>\r\n        <div class=\"grid gap-2 md:grid-cols-1 lg:grid-cols-2 xl:grid-cols-3 fade-in\">\r\n");
#nullable restore
#line 42 "E:\server\grocery-store\Views\Containers\Home.cshtml"
             foreach (var product in products)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                 if (product.Status == ProductStatus.ACTIVE && product.Category.Status == CategoryStatus.ACTIVE)
                {
                    var updateLink = $"{@Routers.UpdateProduct.Link}?productId={@product.ProductId}";
                    var activeColor = product.Status == ProductStatus.ACTIVE ? "text-green-500" : "text-red-500";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"flex items-center justify-between p-2 space-x-2 bg-white rounded-lg shadow-lg\">\r\n                        <div class=\"w-16 h-16 overflow-hidden border-2 rounded-full \">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2578, "\"", 2601, 1);
#nullable restore
#line 50 "E:\server\grocery-store\Views\Containers\Home.cshtml"
WriteAttributeValue("", 2584, product.ImageUrl, 2584, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2602, "\"", 2621, 1);
#nullable restore
#line 50 "E:\server\grocery-store\Views\Containers\Home.cshtml"
WriteAttributeValue("", 2608, product.Name, 2608, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"block object-cover w-full h-full\" />\r\n                        </div>\r\n                        <div class=\"w-1/2 text-left\">\r\n                            <p class=\"font-semibold first-letter\">");
#nullable restore
#line 53 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                                                             Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"max-lines\">");
#nullable restore
#line 54 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                                            Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"font-medium text-yellow-600\">$");
#nullable restore
#line 55 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                                                               Write(product.RetailPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3102, "\"", 3158, 3);
            WriteAttributeValue("", 3109, "/cart/add?productId=", 3109, 20, true);
#nullable restore
#line 58 "E:\server\grocery-store\Views\Containers\Home.cshtml"
WriteAttributeValue("", 3129, product.ProductId, 3129, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3147, "&quantity=1", 3147, 11, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                        class=\"inline-block px-2 py-1 text-white bg-blue-600 rounded-md\">Add to Cart</a>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 63 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                 


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div class=\"space-y-2\">\r\n        <h1 class=\"text-xl font-semibold\">My Cart</h1>\r\n        <div class=\"space-y-2 md:w-101\" id=\"mycart\">\r\n");
#nullable restore
#line 73 "E:\server\grocery-store\Views\Containers\Home.cshtml"
             if (carts == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"flex items-center justify-between p-2 space-x-2 bg-white rounded-md shadow-lg fade-in\">\r\n                    <p class=\"font-semibold\">Empty cart</p>\r\n                </div>\r\n");
#nullable restore
#line 78 "E:\server\grocery-store\Views\Containers\Home.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                 foreach (var cartItem in carts)
                {
                    total += cartItem.Quantity * cartItem.RetailPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"flex items-center justify-between p-2 space-x-2 bg-white rounded-lg shadow-lg fade-in\">\r\n                        <div class=\"w-16 h-16 overflow-hidden border-2 rounded-full \"><img");
            BeginWriteAttribute("src", " src=\"", 4186, "\"", 4210, 1);
#nullable restore
#line 85 "E:\server\grocery-store\Views\Containers\Home.cshtml"
WriteAttributeValue("", 4192, cartItem.ImageUrl, 4192, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"mi\"\r\n                        class=\"block object-cover\"></div>\r\n                        <div class=\"flex-1 space-y-1\">\r\n                            <p class=\"font-semibold first-letter\">");
#nullable restore
#line 88 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                                                             Write(cartItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"flex space-x-2\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4515, "\"", 4573, 3);
            WriteAttributeValue("", 4522, "/cart/add?productId=", 4522, 20, true);
#nullable restore
#line 90 "E:\server\grocery-store\Views\Containers\Home.cshtml"
WriteAttributeValue("", 4542, cartItem.ProductId, 4542, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4561, "&quantity=-1", 4561, 12, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                            class=\"flex items-center justify-center w-6 h-6 font-semibold bg-blue-100\">-</a>\r\n                                <p>");
#nullable restore
#line 92 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                              Write(cartItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4779, "\"", 4836, 3);
            WriteAttributeValue("", 4786, "/cart/add?productId=", 4786, 20, true);
#nullable restore
#line 93 "E:\server\grocery-store\Views\Containers\Home.cshtml"
WriteAttributeValue("", 4806, cartItem.ProductId, 4806, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4825, "&quantity=1", 4825, 11, true);
            EndWriteAttribute();
            WriteLiteral(@"
                            class=""flex items-center justify-center w-6 h-6 font-semibold bg-blue-100"">+</a>
                            </div>
                        </div>
                        <div>

                            <p class=""flex-1 font-medium text-right text-yellow-600"">$");
#nullable restore
#line 99 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                                                                                  Write(cartItem.Quantity *
                        cartItem.RetailPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 103 "E:\server\grocery-store\Views\Containers\Home.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""fixed z-50 w-full font-semibold transform -translate-x-1/2 bottom-4 md:w-101 left-1/2"">
                <div class=""px-2 py-4 mx-2 space-y-2 bg-white border rounded-lg shadow-2xl"">

                    <div class=""flex items-center justify-between"">
                        <p>Total</p>
                        <p class=""text-blue-600"">$");
#nullable restore
#line 111 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                                             Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94fce4cf7ca5a8108e0065a6ae29446c9542375f18157", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 115 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                   Write(await Html.PartialAsync("~/Views/Components/Form/FormMsg.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"space-y-2\">\r\n                            <div class=\"flex items-center space-x-2 rounded-md\">\r\n                                <label class=\"font-medium\">Payment Method: </label>\r\n                                ");
#nullable restore
#line 119 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                           Write(Html.RadioButton("paymentMethod", 1, true));

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>CREDIT CARDS </span>\r\n                                ");
#nullable restore
#line 120 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                           Write(Html.RadioButton("paymentMethod", 0));

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>CASH</span>\r\n                            </div>\r\n\r\n                            <a class=\"block w-full px-2 py-2 text-center text-white bg-blue-600 \" href=\"#mycart\">View\r\n                                My Cart</a>\r\n                            ");
#nullable restore
#line 125 "E:\server\grocery-store\Views\Containers\Home.cshtml"
                       Write(await Html.PartialAsync("~/Views/Components/Form/FormBtn.cshtml", createBtnCart));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 114 "E:\server\grocery-store\Views\Containers\Home.cshtml"
AddHtmlAttributeValue("", 5762, Routers.Order.Link, 5762, 19, false);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Backend.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
