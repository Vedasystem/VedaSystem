#pragma checksum "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Usuario\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbeb12f5de1e25aa686b49e550a05d8913596268"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ConfirmEmail), @"mvc.1.0.view", @"/Views/Usuario/ConfirmEmail.cshtml")]
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
#line 1 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\_ViewImports.cshtml"
using VedaSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\_ViewImports.cshtml"
using VedaSystem.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbeb12f5de1e25aa686b49e550a05d8913596268", @"/Views/Usuario/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e304bc72dd3cdf895a5f0078544ed7e2bf075e58", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Usuario\ConfirmEmail.cshtml"
  
    ViewBag.Title = "Confirm Email";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 5 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Usuario\ConfirmEmail.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n<div>\r\n    <p>\r\n        Thank you for confirming your email. Please ");
#nullable restore
#line 8 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Usuario\ConfirmEmail.cshtml"
                                               Write(Html.ActionLink("Click here to Log in", "Index", "Login", routeValues: null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>");
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