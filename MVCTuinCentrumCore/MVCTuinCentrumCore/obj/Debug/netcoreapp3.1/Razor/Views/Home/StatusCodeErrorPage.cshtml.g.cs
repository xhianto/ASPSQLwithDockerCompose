#pragma checksum "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Home\StatusCodeErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cef847309238e1b9ee0c8669f8d6b155e657f587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StatusCodeErrorPage), @"mvc.1.0.view", @"/Views/Home/StatusCodeErrorPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cef847309238e1b9ee0c8669f8d6b155e657f587", @"/Views/Home/StatusCodeErrorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ce59689843c876cad6e3210313e6aef3835d14", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StatusCodeErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Home\StatusCodeErrorPage.cshtml"
  
    ViewData["Title"] = "StatusCodeErrorPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p class=\"lead alert alert-danger\">");
#nullable restore
#line 6 "D:\VS projects\DockerCompose\MVCTuinCentrumCore\MVCTuinCentrumCore\Views\Home\StatusCodeErrorPage.cshtml"
                              Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
