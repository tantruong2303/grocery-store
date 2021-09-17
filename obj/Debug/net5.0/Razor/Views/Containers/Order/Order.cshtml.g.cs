#pragma checksum "E:\server\grocery-store\Views\Containers\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b21375808581416a498e3460158f6fe05ad6d1ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Order_Order), @"mvc.1.0.view", @"/Views/Containers/Order/Order.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b21375808581416a498e3460158f6fe05ad6d1ed", @"/Views/Containers/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4787e2bf596517cbd42acf11f503cf4b3e860901", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
  
    ViewData["Title"] = Routers.Order.Title;
    List<Order> orders = (List<Order>)ViewData["orders"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"p-2 \">\r\n\r\n    ");
#nullable restore
#line 9 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
Write(await Html.PartialAsync("~/Views/Components/Form/FormMsg.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <table class=""my-2 bg-white border border-black fade-in"">
        <thead>
            <tr>
                <th class=""p-2 border border-black"">Date</th>
                <th class=""p-2 border border-black"">Status</th>
                <th class=""p-2 border border-black"">Payment Method</th>
                <th class=""p-2 border border-black"">Total</th>
                <th class=""p-2 border border-black"">Detail</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
             foreach (var order in orders)
            {
                var detailLink = $"{@Routers.OrderDetail.Link}?orderId={@order.OrderId}";
                var activeColor = order.Status == OrderStatus.ACTIVE ? "text-green-500" : "text-red-500";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"p-2 text-center border border-black max-h-16\">");
#nullable restore
#line 26 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
                                                                        Write(order.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td");
            BeginWriteAttribute("class", " class=\"", 1095, "\"", 1174, 7);
            WriteAttributeValue("", 1103, "p-2", 1103, 3, true);
            WriteAttributeValue(" ", 1106, "text-center", 1107, 12, true);
            WriteAttributeValue(" ", 1118, "lowercase", 1119, 10, true);
            WriteAttributeValue(" ", 1128, "border", 1129, 7, true);
            WriteAttributeValue(" ", 1135, "border-black", 1136, 13, true);
            WriteAttributeValue(" ", 1148, "first-letter", 1149, 13, true);
#nullable restore
#line 27 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
WriteAttributeValue(" ", 1161, activeColor, 1162, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
                                                                                                   Write(order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"p-2 text-center border border-black\">");
#nullable restore
#line 29 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
                                                               Write(order.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"p-2 text-center border border-black\">");
#nullable restore
#line 30 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
                                                               Write(order.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"p-2 text-center border border-black\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1498, "\"", 1516, 1);
#nullable restore
#line 33 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
WriteAttributeValue("", 1505, detailLink, 1505, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        class=\"inline-block p-2 font-medium text-white duration-300 bg-blue-600 rounded-sm hover:bg-blue-800\">View</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "E:\server\grocery-store\Views\Containers\Order\Order.cshtml"
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
