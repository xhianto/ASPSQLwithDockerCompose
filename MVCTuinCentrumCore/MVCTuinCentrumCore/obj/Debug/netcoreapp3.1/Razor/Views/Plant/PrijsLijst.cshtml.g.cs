#pragma checksum "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8272d6ac72c122a3ff49a7ecb0a3cfac4f3d2550"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plant_PrijsLijst), @"mvc.1.0.view", @"/Views/Plant/PrijsLijst.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8272d6ac72c122a3ff49a7ecb0a3cfac4f3d2550", @"/Views/Plant/PrijsLijst.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ce59689843c876cad6e3210313e6aef3835d14", @"/Views/_ViewImports.cshtml")]
    public class Views_Plant_PrijsLijst : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Plant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
  
    ViewData["Title"] = "PrijsLijst";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>PrijsLijst</h2>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 10 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
           Write(Html.DisplayNameFor(m => m.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 11 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
           Write(Html.DisplayNameFor(m => m.VerkoopPrijs));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (BTW ");
#nullable restore
#line 11 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
                                                          Write(ViewBag.Btw);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 15 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
         foreach (var item in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 19 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
               Write(Html.DisplayFor(modelItem => item.Naam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 22 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
                     if (ViewBag.Btw == "inclusief")
                    {
                        decimal prijs = item.VerkoopPrijs * 1.21m;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
                                                             Write(string.Format("{0:C}", prijs));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
                                                                                                
                    }
                    else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
                    Write(Html.DisplayFor(modelItem => item.VerkoopPrijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Plant\PrijsLijst.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Plant>> Html { get; private set; }
    }
}
#pragma warning restore 1591