#pragma checksum "c:\Users\Leyu\Google Drive\netprojs\apittest\Onion\Web\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aad0bb51e275befa74851e2f4febed9e315d2ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Onion_Web_Views_Category_Index), @"mvc.1.0.view", @"/Onion/Web/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Onion/Web/Views/Category/Index.cshtml", typeof(AspNetCore.Onion_Web_Views_Category_Index))]
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
#line 1 "c:\Users\Leyu\Google Drive\netprojs\apittest\Onion\Web\Views\_ViewImports.cshtml"
using apitest1;

#line default
#line hidden
#line 2 "c:\Users\Leyu\Google Drive\netprojs\apittest\Onion\Web\Views\_ViewImports.cshtml"
using apitest1.Models;

#line default
#line hidden
#line 1 "c:\Users\Leyu\Google Drive\netprojs\apittest\Onion\Web\Views\Category\Index.cshtml"
using apitest1.Onion.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aad0bb51e275befa74851e2f4febed9e315d2ed", @"/Onion/Web/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3faab7d78d1e8d2fd924cdf1c6389f496a7cb97", @"/Onion/Web/Views/_ViewImports.cshtml")]
    public class Onion_Web_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "c:\Users\Leyu\Google Drive\netprojs\apittest\Onion\Web\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Category Services";

#line default
#line hidden
            BeginContext(121, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(126, 17, false);
#line 6 "c:\Users\Leyu\Google Drive\netprojs\apittest\Onion\Web\Views\Category\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(143, 30, true);
            WriteLiteral("</h2>\r\n\r\n<p>Category.</p>\r\n<p>");
            EndContext();
            BeginContext(174, 13, false);
#line 9 "c:\Users\Leyu\Google Drive\netprojs\apittest\Onion\Web\Views\Category\Index.cshtml"
Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(187, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(197, 18, false);
#line 10 "c:\Users\Leyu\Google Drive\netprojs\apittest\Onion\Web\Views\Category\Index.cshtml"
Write(Model.First().Name);

#line default
#line hidden
            EndContext();
            BeginContext(215, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591