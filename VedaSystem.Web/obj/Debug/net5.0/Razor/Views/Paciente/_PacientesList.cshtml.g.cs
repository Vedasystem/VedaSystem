#pragma checksum "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8655fff517df36419a3b2e56a48e3c62001ce81a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paciente__PacientesList), @"mvc.1.0.view", @"/Views/Paciente/_PacientesList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8655fff517df36419a3b2e56a48e3c62001ce81a", @"/Views/Paciente/_PacientesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e304bc72dd3cdf895a5f0078544ed7e2bf075e58", @"/Views/_ViewImports.cshtml")]
    public class Views_Paciente__PacientesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VedaSystem.Application.ViewModels.PacienteViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <tr class=""d-style bgc-h-default-l4"">
        <td class=""td-toggle-details pos-rel"">
            <div class=""position-lc h-95 ml-1px border-l-3 brc-purple-m1"">
            </div>
        </td>
        <td class=""pl-3 pl-md-4 align-middle pos-rel"">
            <input type=""checkbox"" class=""pacientes-check"" onclick=""showHideBotaoDeletePaciente()""");
            BeginWriteAttribute("value", " value=\"", 464, "\"", 480, 1);
#nullable restore
#line 11 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml"
WriteAttributeValue("", 472, item.Id, 472, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <div class=\"d-n-collapsed position-lc h-95 ml-1px border-l-3 brc-purple-m1\">\r\n            </div>\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 16 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-grey\">\r\n            ");
#nullable restore
#line 19 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-grey\">\r\n            ");
#nullable restore
#line 22 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-600 text-grey-d1\">\r\n            ");
#nullable restore
#line 25 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Altura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-600 text-grey-d1\">\r\n");
#nullable restore
#line 28 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml"
               
                var idade = DateTime.Now.Year - item.DataNascimento.Year;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 31 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml"
       Write(idade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td class=\"align-middle\">\r\n");
            WriteLiteral(@"            <a href=""#"" id=""btn-acoes"" aria-haspopup=""true"" onclick=""abrirFecharMenuAcoes()"" >
                <i class=""fa fa-ellipsis-h ml-3""></i>
            </a>
            <ul id=""ul-acoes"" style=""display:none ;position: absolute; top: 100%; list-style: none; padding-left: 0px; z-index: 1; width: 70px"">
                <li style=""position: relative"">teste</li>
                <li style=""position: relative"">teste</li>
                <li style=""position: relative"">teste</li>
                <li style=""position: relative"">teste</li>
            </ul>
        </td>
    </tr>
");
#nullable restore
#line 56 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Paciente\_PacientesList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VedaSystem.Application.ViewModels.PacienteViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591