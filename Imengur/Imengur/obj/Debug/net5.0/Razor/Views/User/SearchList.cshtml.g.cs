#pragma checksum "C:\Users\Berry\Desktop\prog_dotnet\Imengur\Imengur\Views\User\SearchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7e7d13b2b2b86972580847f3085c751ef7db00f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SearchList), @"mvc.1.0.view", @"/Views/User/SearchList.cshtml")]
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
#line 1 "C:\Users\Berry\Desktop\prog_dotnet\Imengur\Imengur\Views\_ViewImports.cshtml"
using Imengur;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berry\Desktop\prog_dotnet\Imengur\Imengur\Views\_ViewImports.cshtml"
using Imengur.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e7d13b2b2b86972580847f3085c751ef7db00f", @"/Views/User/SearchList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4590ca9d99d2512d4159c54691b02a6af7ba3faf", @"/Views/_ViewImports.cshtml")]
    public class Views_User_SearchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Imengur.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Uploaded images</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Image ID</th>\r\n        <th>Title</th>\r\n");
            WriteLiteral("        <th>Image</th>\r\n        <th>Description</th>\r\n    </tr>\r\n    <tbody>\r\n\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Imengur.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591