#pragma checksum "D:\GIT\SportsStore\SportsStore\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c6c25d4d937c5f323e1eb04852066b7c7e7f3c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "D:\GIT\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#line 2 "D:\GIT\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c6c25d4d937c5f323e1eb04852066b7c7e7f3c2", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769cd5025a6bfc1d8dfd5b28c70207f57767092e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GIT\SportsStore\SportsStore\Views\Product\List.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
            BeginContext(61, 23, true);
            WriteLiteral("    <div>\r\n        <h3>");
            EndContext();
            BeginContext(85, 6, false);
#line 6 "D:\GIT\SportsStore\SportsStore\Views\Product\List.cshtml"
       Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(91, 15, true);
            WriteLiteral("</h3>\r\n        ");
            EndContext();
            BeginContext(107, 13, false);
#line 7 "D:\GIT\SportsStore\SportsStore\Views\Product\List.cshtml"
   Write(p.Description);

#line default
#line hidden
            EndContext();
            BeginContext(120, 14, true);
            WriteLiteral("\r\n        <h4>");
            EndContext();
            BeginContext(135, 21, false);
#line 8 "D:\GIT\SportsStore\SportsStore\Views\Product\List.cshtml"
       Write(p.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(156, 19, true);
            WriteLiteral("</h4>\r\n    </div>\r\n");
            EndContext();
#line 10 "D:\GIT\SportsStore\SportsStore\Views\Product\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
