#pragma checksum "D:\Work2019\LearnAsp.netCore\SportsStoreDemo\SportsStore\SportsStore\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "972321ad5ef3d14689288518ab54c6854af7ce1c"
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
#line 1 "D:\Work2019\LearnAsp.netCore\SportsStoreDemo\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#line 2 "D:\Work2019\LearnAsp.netCore\SportsStoreDemo\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"972321ad5ef3d14689288518ab54c6854af7ce1c", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0fa7836d95fec9626a7d8603b01ca917f681844", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Work2019\LearnAsp.netCore\SportsStoreDemo\SportsStore\SportsStore\Views\Product\List.cshtml"
 foreach (var p in Model.Products)
{

#line default
#line hidden
            BeginContext(71, 23, true);
            WriteLiteral("    <div>\r\n        <h3>");
            EndContext();
            BeginContext(95, 6, false);
#line 6 "D:\Work2019\LearnAsp.netCore\SportsStoreDemo\SportsStore\SportsStore\Views\Product\List.cshtml"
       Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(101, 15, true);
            WriteLiteral("</h3>\r\n        ");
            EndContext();
            BeginContext(117, 13, false);
#line 7 "D:\Work2019\LearnAsp.netCore\SportsStoreDemo\SportsStore\SportsStore\Views\Product\List.cshtml"
   Write(p.Description);

#line default
#line hidden
            EndContext();
            BeginContext(130, 14, true);
            WriteLiteral("\r\n        <h4>");
            EndContext();
            BeginContext(145, 21, false);
#line 8 "D:\Work2019\LearnAsp.netCore\SportsStoreDemo\SportsStore\SportsStore\Views\Product\List.cshtml"
       Write(p.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(166, 19, true);
            WriteLiteral("</h4>\r\n    </div>\r\n");
            EndContext();
#line 10 "D:\Work2019\LearnAsp.netCore\SportsStoreDemo\SportsStore\SportsStore\Views\Product\List.cshtml"
}

#line default
#line hidden
            BeginContext(188, 8, true);
            WriteLiteral("\r\n\r\n<div");
            EndContext();
            BeginWriteAttribute("page-model", " page-model=\"", 196, "\"", 226, 1);
#line 13 "D:\Work2019\LearnAsp.netCore\SportsStoreDemo\SportsStore\SportsStore\Views\Product\List.cshtml"
WriteAttributeValue("", 209, Model.PagingInfo, 209, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(227, 26, true);
            WriteLiteral(" page-action=\"List\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591