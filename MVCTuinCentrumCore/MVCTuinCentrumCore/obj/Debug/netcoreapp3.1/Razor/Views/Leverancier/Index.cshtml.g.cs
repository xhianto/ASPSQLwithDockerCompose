#pragma checksum "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Leverancier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b146ab64670f34eac828f6c015a1cf8cc3597165"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leverancier_Index), @"mvc.1.0.view", @"/Views/Leverancier/Index.cshtml")]
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
#line 1 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\_ViewImports.cshtml"
using MVCTuinCentrumCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\_ViewImports.cshtml"
using MVCTuinCentrumCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b146ab64670f34eac828f6c015a1cf8cc3597165", @"/Views/Leverancier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ce59689843c876cad6e3210313e6aef3835d14", @"/Views/_ViewImports.cshtml")]
    public class Views_Leverancier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Leverancier>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Leverancier\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Alle Leveranciers</h1>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Nummer</th>
            <th>Naam</th>
            <th>Adres</th>
            <th>Postcode</th>
            <th>Woonplaats</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Leverancier\Index.cshtml"
         foreach (var leverancier in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Leverancier\Index.cshtml"
           Write(leverancier.LevNr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Leverancier\Index.cshtml"
           Write(leverancier.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Leverancier\Index.cshtml"
           Write(leverancier.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Leverancier\Index.cshtml"
           Write(leverancier.PostNr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Leverancier\Index.cshtml"
           Write(leverancier.Woonplaats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Leverancier\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Leverancier>> Html { get; private set; }
    }
}
#pragma warning restore 1591
