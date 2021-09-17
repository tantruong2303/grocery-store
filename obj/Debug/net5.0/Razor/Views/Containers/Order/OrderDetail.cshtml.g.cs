#pragma checksum "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cab90939dc27294fb8acea0c28da21feb8e1736"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Order_OrderDetail), @"mvc.1.0.view", @"/Views/Containers/Order/OrderDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cab90939dc27294fb8acea0c28da21feb8e1736", @"/Views/Containers/Order/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4787e2bf596517cbd42acf11f503cf4b3e860901", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Order_OrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml"
  
    ViewData["Title"] = Routers.OrderDetail.Title;
    List<OrderItem> items = (List<OrderItem>)ViewData["items"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"p-2 \">\r\n\r\n    ");
#nullable restore
#line 9 "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml"
Write(await Html.PartialAsync("~/Views/Components/Form/FormMsg.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""my-2 bg-white border border-black fade-in"">
        <thead>
            <tr>
                <th class=""p-2 border border-black"">Product</th>
                <th class=""p-2 border border-black"">Quantity</th>
                <th class=""p-2 border border-black"">Price</th>
                <th class=""p-2 border border-black"">Total</th>
                <th class=""p-2 border border-black"">View Product</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml"
             foreach (var item in items)
            {
                var productLink = $"{@Routers.Product.Link}?productId={@item.ProductId}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"p-2 text-center border border-black max-h-16\">");
#nullable restore
#line 25 "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml"
                                                                        Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center border border-black\">");
#nullable restore
#line 26 "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml"
                                                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center border border-black\">");
#nullable restore
#line 27 "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml"
                                                               Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center border border-black\">");
#nullable restore
#line 28 "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml"
                                                                Write(item.Quantity*item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center border border-black\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1356, "\"", 1375, 1);
#nullable restore
#line 30 "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml"
WriteAttributeValue("", 1363, productLink, 1363, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        class=\"inline-block p-2 font-medium text-white duration-300 bg-blue-600 rounded-sm hover:bg-blue-800\">View</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "E:\server\grocery-store\Views\Containers\Order\OrderDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
