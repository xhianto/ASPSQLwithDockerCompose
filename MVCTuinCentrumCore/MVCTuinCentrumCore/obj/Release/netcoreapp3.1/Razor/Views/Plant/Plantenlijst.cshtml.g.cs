#pragma checksum "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\Plantenlijst.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88f88d461d2ea37144a3a1ef2c7f9f256fb686cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plant_Plantenlijst), @"mvc.1.0.view", @"/Views/Plant/Plantenlijst.cshtml")]
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
#line 1 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\_ViewImports.cshtml"
using MVCTuinCentrumCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\_ViewImports.cshtml"
using MVCTuinCentrumCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88f88d461d2ea37144a3a1ef2c7f9f256fb686cf", @"/Views/Plant/Plantenlijst.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ce59689843c876cad6e3210313e6aef3835d14", @"/Views/_ViewImports.cshtml")]
    public class Views_Plant_Plantenlijst : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Plant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\Plantenlijst.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Naam</th>
            <th>Soort</th>
            <th>Leverancier</th>
            <th>Kleur</th>
            <th>Prijs</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\Plantenlijst.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\Plantenlijst.cshtml"
           Write(Html.DisplayFor(modelItem => item.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\Plantenlijst.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoortNrNavigation.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\Plantenlijst.cshtml"
           Write(Html.DisplayFor(modelItem => item.LevnrNavigation.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\Plantenlijst.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kleur));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\Plantenlijst.cshtml"
           Write(Html.DisplayFor(modelItem => item.VerkoopPrijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "D:\School en VDAB\VDAB\Documents\CSharp-Cursus\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\Plantenlijst.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Plant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
