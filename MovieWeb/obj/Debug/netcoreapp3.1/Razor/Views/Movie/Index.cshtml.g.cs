#pragma checksum "C:\Users\Keoma\source\repos\Movieweb\MovieWeb\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b3a92af66a9b1c2eb94bee289f1a89632e7f33a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\Keoma\source\repos\Movieweb\MovieWeb\Views\_ViewImports.cshtml"
using MovieWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Keoma\source\repos\Movieweb\MovieWeb\Views\_ViewImports.cshtml"
using MovieWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b3a92af66a9b1c2eb94bee289f1a89632e7f33a", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc64e988175f2517e3aa8d079c79e989ebc3798", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <th>Title</th>\r\n        </tr>\r\n");
#nullable restore
#line 7 "C:\Users\Keoma\source\repos\Movieweb\MovieWeb\Views\Movie\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 201, "\"", 233, 2);
            WriteAttributeValue("", 208, "/movie/detail?id=", 208, 17, true);
#nullable restore
#line 10 "C:\Users\Keoma\source\repos\Movieweb\MovieWeb\Views\Movie\Index.cshtml"
WriteAttributeValue("", 225, item.Id, 225, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Users\Keoma\source\repos\Movieweb\MovieWeb\Views\Movie\Index.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 12 "C:\Users\Keoma\source\repos\Movieweb\MovieWeb\Views\Movie\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
