#pragma checksum "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92994be72d811122ada154e922cb03d85737c92f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Terapeuta__TerapeutasList), @"mvc.1.0.view", @"/Views/Terapeuta/_TerapeutasList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92994be72d811122ada154e922cb03d85737c92f", @"/Views/Terapeuta/_TerapeutasList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e304bc72dd3cdf895a5f0078544ed7e2bf075e58", @"/Views/_ViewImports.cshtml")]
    public class Views_Terapeuta__TerapeutasList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VedaSystem.Application.ViewModels.TerapeutaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <tr class=""d-style bgc-h-default-l4"">
        <td class=""td-toggle-details pos-rel"">
            <!-- this empty table cell will show the `+` sign which toggles the hidden cells in responsive (collapsed) mode -->
            <div class=""position-lc h-95 ml-1px border-l-3 brc-purple-m1"">
                <!-- this decorative highlight border will be shown only when table is collapsed (responsive) -->
            </div>
        </td>
        <td class=""pl-3 pl-md-4 align-middle pos-rel"" onclick=""showHideBotaoDeleteTerapeuta()"">
            <input class=""terapeutas-check"" type=""checkbox""");
            BeginWriteAttribute("value", "  value=\"", 711, "\"", 728, 1);
#nullable restore
#line 13 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
WriteAttributeValue("", 720, item.Id, 720, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

            <div class=""d-n-collapsed position-lc h-95 ml-1px border-l-3 brc-purple-m1"">
                <!-- this decorative highlight border will be shown only when table is in full mode (not collapsed >> .d-n-collapsed) -->
            </div>
        </td>
        <td>
            <span class=""text-105"">
                ");
#nullable restore
#line 21 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <div class=\"text-95 text-secondary-d1\">\r\n                ");
#nullable restore
#line 24 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Site));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </td>\r\n        <td class=\"text-grey\">\r\n            ");
#nullable restore
#line 28 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-grey\">\r\n            ");
#nullable restore
#line 31 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-600 text-grey-d1\">\r\n            ");
#nullable restore
#line 34 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
       Write(item.Terapias.Count().ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-grey\">\r\n            ");
#nullable restore
#line 37 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
       Write(item.Pacientes.Count().ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td class=\"align-middle\">\r\n            <span class=\"d-none d-lg-inline\">\r\n                <a data-rel=\"tooltip\" data-action=\"edit\" title=\"Edit\" href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1868, "\"", 1907, 3);
            WriteAttributeValue("", 1878, "openEditTerapeuta(\'", 1878, 19, true);
#nullable restore
#line 41 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
WriteAttributeValue("", 1897, item.Id, 1897, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1905, "\')", 1905, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"v-hover\">\r\n                    <i class=\"fa fa-edit text-blue-m1 text-120\"></i>\r\n                </a>\r\n            </span>\r\n            <span class=\"d-lg-none text-nowrap\">\r\n                <a title=\"Editar\" href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2149, "\"", 2188, 3);
            WriteAttributeValue("", 2159, "openEditTerapeuta(\'", 2159, 19, true);
#nullable restore
#line 46 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
WriteAttributeValue("", 2178, item.Id, 2178, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2186, "\')", 2186, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info shadow-sm px-4 btn-bgc-white\">\r\n                    <i class=\"fa fa-pencil-alt mx-1\"></i>\r\n                    <span class=\"ml-1 d-md-none\">Editar</span>\r\n                </a>\r\n            </span>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapeuta\_TerapeutasList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VedaSystem.Application.ViewModels.TerapeutaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
