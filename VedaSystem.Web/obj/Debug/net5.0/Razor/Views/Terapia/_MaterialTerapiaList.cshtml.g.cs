#pragma checksum "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ecfce8550bc0ec2487c106f97034220b72ecf55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Terapia__MaterialTerapiaList), @"mvc.1.0.view", @"/Views/Terapia/_MaterialTerapiaList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ecfce8550bc0ec2487c106f97034220b72ecf55", @"/Views/Terapia/_MaterialTerapiaList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e304bc72dd3cdf895a5f0078544ed7e2bf075e58", @"/Views/_ViewImports.cshtml")]
    public class Views_Terapia__MaterialTerapiaList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VedaSystem.Application.ViewModels.MaterialTerapiaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("align-middle input-sm ml-2 mr-25 col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("id", " id=\"", 73, "\"", 87, 1);
#nullable restore
#line 3 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaList.cshtml"
WriteAttributeValue("", 78, Model.Id, 78, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"task-item d-flex align-items-center  bgc-h-green-l3 brc-secondary-l3 px-2 listMaterial\">\r\n    ");
#nullable restore
#line 4 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaList.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <label class=\"flex-grow-1 mr-3 py-3 col-sm-5\" for=\"task-item-0\">\r\n        <span class=\"align-middle\">\r\n            ");
#nullable restore
#line 7 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaList.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n    </label>\r\n    <label class=\"flex-grow-1 mr-3 py-3 col-sm-4\" for=\"task-item-0\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ecfce8550bc0ec2487c106f97034220b72ecf555206", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onkeyup", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 514, "atualizarQtdMaterialTerapia(\'", 514, 29, true);
#nullable restore
#line 11 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaList.cshtml"
AddHtmlAttributeValue("", 543, Model.Id, 543, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 552, "\')", 552, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 11 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Descricao);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 652, "_input_", 652, 7, true);
#nullable restore
#line 11 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaList.cshtml"
AddHtmlAttributeValue("", 659, Model.Id, 659, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </label>\r\n    <label class=\"flex-grow-1 mr-3 py-3 col-sm-1\" for=\"task-item-0\">\r\n        <i class=\"fa fa-trash text-danger-m1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 803, "\"", 848, 3);
            WriteAttributeValue("", 813, "removerMaterialTerapia(\'", 813, 24, true);
#nullable restore
#line 14 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaList.cshtml"
WriteAttributeValue("", 837, Model.Id, 837, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 846, "\')", 846, 2, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n    </label>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VedaSystem.Application.ViewModels.MaterialTerapiaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
