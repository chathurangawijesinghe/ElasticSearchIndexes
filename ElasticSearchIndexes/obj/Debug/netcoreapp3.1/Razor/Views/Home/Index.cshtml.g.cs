#pragma checksum "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8710640e111cf40cf5a31de3354bc35451c78713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\_ViewImports.cshtml"
using ElasticSearchIndexes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\_ViewImports.cshtml"
using ElasticSearchIndexes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8710640e111cf40cf5a31de3354bc35451c78713", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f007e42a88bc9867e5546200288987e54cac6db", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ElasticSearchIndexes.Models.ElasticSqlDataCounts>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Elastic & SQL Index Counts</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IndexName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ViewName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IndexCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ViewCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IndexName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ViewName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IndexCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ViewCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "D:\Developments\elk\ElasticSearchIndexes\ElasticSearchIndexes\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ElasticSearchIndexes.Models.ElasticSqlDataCounts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
