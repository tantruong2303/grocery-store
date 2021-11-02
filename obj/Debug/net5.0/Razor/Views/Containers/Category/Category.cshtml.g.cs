#pragma checksum "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20797a73a94368c792e8c41481fb2c5bdc37209b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Category_Category), @"mvc.1.0.view", @"/Views/Containers/Category/Category.cshtml")]
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
#line 1 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\_ViewImports.cshtml"
using Backend.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20797a73a94368c792e8c41481fb2c5bdc37209b", @"/Views/Containers/Category/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48f5f22d9a6e26ef591873adf0210c7162d00e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Category_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml"
  
    this.ViewData["Title"] = Routers.Category.Title;
    var categories = (List<Category>)this.ViewData["categories"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6 \">\r\n    <div class=\"flex\">\r\n        <!-- BEGIN: Side Menu -->\r\n        ");
#nullable restore
#line 9 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <!-- END: Side Menu -->
        <!-- BEGIN: Content -->
        <div class=""content"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mr-auto text-base font-medium"">
                        Category Manager
                    </h2>

                </div>
                <div class=""p-5"" id=""hoverable-table"">
                    <div class=""preview"">
                        <div class=""overflow-x-auto"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">#
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Name
                                        </th>
                  ");
            WriteLiteral(@"                      <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Description
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Stauts</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Edit</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 37 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml"
                                     for (int i = 0; i < categories.Count; i++)
                                    {
                                        var item = categories[i];
                                        var link = $"{Routers.UpdateCategory.Link}?categoryId={item.CategoryId}";


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"hover:bg-gray-200\">\r\n                                            <td class=\"border\">");
#nullable restore
#line 43 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml"
                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 44 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 45 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml"
                                                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">\r\n                                                ");
#nullable restore
#line 47 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml"
                                           Write(await Html.PartialAsync("../../Components/Table/Status.cshtml", item.Status
                                            == CategoryStatus.ACTIVE ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"border\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2909, "\"", 2921, 1);
#nullable restore
#line 51 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml"
WriteAttributeValue("", 2916, link, 2916, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mb-2 mr-1 btn btn-primary\"> <i data-feather=\"edit\"\r\n                                                    class=\"w-5 h-5\"></i> </a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\ACER\Desktop\Groce\grocery-store\Views\Containers\Category\Category.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- END: Content -->\r\n    </div>\r\n\r\n</div>");
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
