#pragma checksum "C:\Users\abdullah.arslan\Desktop\26.01\MVC_Area\MVC_Area\Areas\Dashboard\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5454b1484ecc09c0ee7f0bac1ebbdeb488dc41bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5454b1484ecc09c0ee7f0bac1ebbdeb488dc41bd", @"/Areas/Dashboard/Views/Product/Index.cshtml")]
    public class Areas_Dashboard_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\abdullah.arslan\Desktop\26.01\MVC_Area\MVC_Area\Areas\Dashboard\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ol class=\"breadcrumb mb-4\">\r\n    <li class=\"breadcrumb-item active\">");
#nullable restore
#line 8 "C:\Users\abdullah.arslan\Desktop\26.01\MVC_Area\MVC_Area\Areas\Dashboard\Views\Product\Index.cshtml"
                                  Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ol>\r\n\r\n<div class=\"row\">\r\n    <div class=\" d-flex justify-content-between\">\r\n        <h1>Product</h1>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 312, "\"", 319, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-success"" style=""height:fit-content;"">New Category</a>
    </div>

    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>ProductName</th>
                <th>Description</th>
                <th>UnitPrice</th>
                <th>CategoryName</th>
                <th>Edit</th>

            </tr>
        </thead>

        <tbody>
            <tr>
                <td>1</td>
                <td>MSI Laptop</td>
                <td>Çok hoj bir labdob</td>
                <td>20000</td>
                <td>Teknoloji</td>
                <td>
                    <a class=""btn btn-outline-danger btn-sm""><img src=""https://icon-library.com/images/delete-icon-png/delete-icon-png-19.jpg"" style=""width:20px; height:20px"" /></a>
                    <a class=""btn btn-outline-warning btn-sm""><img src=""https://imgs.search.brave.com/fkbXOaZaXvX5qWDVpsrcWcqImegnnQoUTQ-R35b8nwc/rs:fit:512:512:1/g:ce/aHR0cHM6Ly9pY29u/cy5pY29uYXJjaG");
            WriteLiteral("l2/ZS5jb20vaWNvbnMv/cGFwaXJ1cy10ZWFt/L3BhcGlydXMtYXBw/cy81MTIvc3lzdGVt/LXNvZnR3YXJlLXVw/ZGF0ZS1pY29uLnBu/Zw\" style=\"width:20px; height:20px\" /></a>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n</div>");
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
