#pragma checksum "C:\Users\jromo021627\source\repos\DeepOTools\Views\Inventory\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cef39d8ab86c6f4c96a059840a0221f12d1d4b56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_List), @"mvc.1.0.view", @"/Views/Inventory/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/List.cshtml", typeof(AspNetCore.Views_Inventory_List))]
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
#line 1 "C:\Users\jromo021627\source\repos\DeepOTools\Views\_ViewImports.cshtml"
using DeepOTools;

#line default
#line hidden
#line 2 "C:\Users\jromo021627\source\repos\DeepOTools\Views\_ViewImports.cshtml"
using DeepOTools.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cef39d8ab86c6f4c96a059840a0221f12d1d4b56", @"/Views/Inventory/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58d0b3021a3ad0246022d39e21a8fa56078430a", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inventory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jromo021627\source\repos\DeepOTools\Views\Inventory\List.cshtml"
 foreach (var i in Model)
            {

#line default
#line hidden
            BeginContext(75, 47, true);
            WriteLiteral("                <div>\r\n                    <h3>");
            EndContext();
            BeginContext(123, 10, false);
#line 6 "C:\Users\jromo021627\source\repos\DeepOTools\Views\Inventory\List.cshtml"
                   Write(i.ItemName);

#line default
#line hidden
            EndContext();
            BeginContext(133, 27, true);
            WriteLiteral("</h3>\r\n                    ");
            EndContext();
            BeginContext(161, 13, false);
#line 7 "C:\Users\jromo021627\source\repos\DeepOTools\Views\Inventory\List.cshtml"
               Write(i.Description);

#line default
#line hidden
            EndContext();
            BeginContext(174, 26, true);
            WriteLiteral("\r\n                    <h4>");
            EndContext();
            BeginContext(201, 21, false);
#line 8 "C:\Users\jromo021627\source\repos\DeepOTools\Views\Inventory\List.cshtml"
                   Write(i.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(222, 31, true);
            WriteLiteral("</h4>\r\n                </div>\r\n");
            EndContext();
#line 10 "C:\Users\jromo021627\source\repos\DeepOTools\Views\Inventory\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inventory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
