#pragma checksum "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d72009ee74b81036cefa180f8da982587cbdd174"
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
#line 1 "E:\server\New folder (2)\grocery-store\Views\_ViewImports.cshtml"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\server\New folder (2)\grocery-store\Views\_ViewImports.cshtml"
using Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\server\New folder (2)\grocery-store\Views\_ViewImports.cshtml"
using Backend.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72009ee74b81036cefa180f8da982587cbdd174", @"/Views/Containers/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48f5f22d9a6e26ef591873adf0210c7162d00e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("tabulator-html-filter-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
  
    this.ViewData["Title"] = Routers.Home.Title;
    var products = (List<Product>)this.ViewData["products"];


    var categories = (SelectList)this.ViewData["categories"];
    var min = (string) this.Context.Request.Query["min"];
    var max = (string) this.Context.Request.Query["max"];
    var name =(string)  this.Context.Request.Query["name"];
    var categoryId = (string)  this.Context.Request.Query["categoryId"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        <!-- BEGIN: Side Menu -->\r\n        ");
#nullable restore
#line 16 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
   Write(await Html.PartialAsync("../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <!-- END: Side Menu -->
        <!-- BEGIN: Content -->
        <div class=""content"">
            <!-- BEGIN: Top Bar -->

            <!-- END: Top Bar -->

            <div class=""grid grid-cols-12 gap-5 mt-5 pos intro-y"">
                <!-- BEGIN: Item List -->
                <div class=""col-span-12 intro-y lg:col-span-8"">
                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d72009ee74b81036cefa180f8da982587cbdd1745081", async() => {
                WriteLiteral("\r\n                        <div class=\"flex items-end space-x-2\">\r\n                            <div class=\"space-y-2\">\r\n                                <label>Name</label>\r\n                                ");
#nullable restore
#line 31 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
                           Write(await Html.PartialAsync("../Components/Form/TextField.cshtml", new {Label="Name",
                                Field="name",Type="text", Value=name}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"space-y-2\">\r\n                                <label>Min Price</label>\r\n                                ");
#nullable restore
#line 36 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
                           Write(await Html.PartialAsync("../Components/Form/TextFieldNumber.cshtml", new {Label="Min price",
                                Field="min",Step="0.01", Value=min}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"space-y-2\">\r\n                                <label>Max Price</label>\r\n                                ");
#nullable restore
#line 41 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
                           Write(await Html.PartialAsync("../Components/Form/TextFieldNumber.cshtml", new {Label="Max price",
                                Field="max",Step="0.01", Value=max}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"space-y-2\"> \r\n                                <label>Category</label>\r\n                                ");
#nullable restore
#line 46 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
                           Write(await Html.PartialAsync("../Components/Form/SelectList.cshtml", new {Label="Max price",
                                Values=categories, Value=categoryId, Field="categoryId"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""flex items-end"">
                                <button class=""mb-2 btn btn-primary""> 
                                    <i data-feather=""search"" class=""w-5 h-5""></i> 
                                </button>
                                    
                            </div>
                        </div>
                    
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"grid grid-cols-12 gap-5 pt-5 mt-5 border-t border-theme-5\">\r\n\r\n");
#nullable restore
#line 60 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
                         foreach (var item in products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <button type=""button"" class=""block col-span-4 intro-y md:col-span-2 "">
                                <div class=""relative p-3 rounded-md duration hover:bg-blue-200 box"">
                                    <div class=""relative flex-none block pos-image"">
                                        <div class=""pos-image__preview image-fit"">
                                            <img alt=""Rubick Tailwind HTML Admin Template"" src=""https://picsum.photos/300"">
                                        </div>
                                    </div>
                                    <div class=""block mt-3 font-medium text-center truncate"">");
#nullable restore
#line 69 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
                                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"block mt-3 font-medium text-center truncate\">$");
#nullable restore
#line 70 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
                                                                                         Write(item.RetailPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                            </button>\r\n");
#nullable restore
#line 73 "E:\server\New folder (2)\grocery-store\Views\Containers\Home.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                </div>
                <!-- END: Item List -->
                <!-- BEGIN: Ticket -->
                <div class=""col-span-12 lg:col-span-4"">
                    <div class=""pr-1 intro-y"">
                        <div class=""p-2 box"">
                            <div class=""justify-center pos__tabs nav nav-tabs"" role=""tablist""> <a id=""ticket-tab""
                                    data-toggle=""tab"" data-target=""#ticket"" href=""javascript:;""
                                    class=""flex-1 py-2 text-center rounded-md"" role=""tab"" aria-controls=""ticket""
                                    aria-selected=""false"">My Cart</a> </div>
                        </div>
                    </div>
                    <div class=""tab-content"">


                    </div>
                </div>
                <!-- END: Ticket -->
            </div>
            <!-- BEGIN: New Order Modal -->
            <div id=""new-order-modal"" class=""modal"" tabindex=""-1"" a");
            WriteLiteral(@"ria-hidden=""true"">
                <div class=""modal-dialog"">
                    <div class=""modal-content "">
                        <div class=""modal-header"">
                            <h2 class=""mr-auto text-base font-medium"">
                                New Order
                            </h2>
                        </div>
                        <div class=""grid grid-cols-12 gap-4 modal-body gap-y-3"">
                            <div class=""col-span-12"">
                                <label for=""pos-form-1"" class=""form-label"">Name</label>
                                <input id=""pos-form-1"" type=""text"" class=""flex-1 form-control""
                                    placeholder=""Customer name"">
                            </div>
                            <div class=""col-span-12"">
                                <label for=""pos-form-2"" class=""form-label"">Table</label>
                                <input id=""pos-form-2"" type=""text"" class=""flex-1 form-control""
           ");
            WriteLiteral(@"                         placeholder=""Customer table"">
                            </div>
                            <div class=""col-span-12"">
                                <label for=""pos-form-3"" class=""form-label"">Number of People</label>
                                <input id=""pos-form-3"" type=""text"" class=""flex-1 form-control"" placeholder=""People"">
                            </div>
                        </div>
                        <div class=""text-right modal-footer"">
                            <button type=""button"" data-dismiss=""modal""
                                class=""w-32 mr-1 btn btn-outline-secondary"">Cancel</button>
                            <button type=""button"" class=""w-32 btn btn-primary"">Create Ticket</button>
                        </div>
                    </div>
                </div>
            </div>
            <!-- END: New Order Modal -->
            <!-- BEGIN: Add Item Modal -->

            <!-- END: Add Item Modal -->
        </div>
        ");
            WriteLiteral("<!-- END: Content -->\r\n    </div>\r\n\r\n</div>");
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
