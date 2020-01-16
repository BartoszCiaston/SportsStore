#pragma checksum "D:\GIT\SportsStore\SportsStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c21c113b3390fe5547266b84758506f3a7ae49a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 3 "D:\GIT\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c21c113b3390fe5547266b84758506f3a7ae49a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f2639e733a5a5462dc6a72158fc99ad108abc7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 298, true);
            WriteLiteral(@"
<h2>Twój koszyk</h2>
<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th>Ilość</th>
            <th>Produkt</th>
            <th class=""text-right"">Cena</th>
            <th class=""text-right"">Wartość</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 14 "D:\GIT\SportsStore\SportsStore\Views\Cart\Index.cshtml"
         foreach(var line in Model.Cart.Lines)
        {

#line default
#line hidden
            BeginContext(384, 50, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">");
            EndContext();
            BeginContext(435, 13, false);
#line 17 "D:\GIT\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                               Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(448, 41, true);
            WriteLiteral("</td>\r\n            <td class=\"text-left\">");
            EndContext();
            BeginContext(490, 17, false);
#line 18 "D:\GIT\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                             Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(507, 42, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(550, 32, false);
#line 19 "D:\GIT\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                              Write(line.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(582, 42, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(626, 50, false);
#line 20 "D:\GIT\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                               Write((line.Quantity * line.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(677, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 22 "D:\GIT\SportsStore\SportsStore\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(710, 136, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Razem:</td>\r\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(847, 44, false);
#line 27 "D:\GIT\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                              Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(891, 105, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 996, "\"", 1019, 1);
#line 33 "D:\GIT\SportsStore\SportsStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1003, Model.ReturnUrl, 1003, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1020, 29, true);
            WriteLiteral(">Kontynuuj zakupy</a>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
