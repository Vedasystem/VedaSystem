#pragma checksum "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ab1f302f3bf49dbcff3fbee1d96873863ca0f45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Terapia__MaterialTerapiaEditList), @"mvc.1.0.view", @"/Views/Terapia/_MaterialTerapiaEditList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab1f302f3bf49dbcff3fbee1d96873863ca0f45", @"/Views/Terapia/_MaterialTerapiaEditList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e304bc72dd3cdf895a5f0078544ed7e2bf075e58", @"/Views/_ViewImports.cshtml")]
    public class Views_Terapia__MaterialTerapiaEditList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VedaSystem.Application.ViewModels.MaterialTerapiaViewModel>>
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 125, "\"", 138, 1);
#nullable restore
#line 6 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
WriteAttributeValue("", 130, item.Id, 130, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"task-item d-flex align-items-center  bgc-h-green-l3 brc-secondary-l3 px-2 listMaterial\">\r\n        ");
#nullable restore
#line 7 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
   Write(Html.HiddenFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <label class=\"flex-grow-1 mr-3 py-3 col-sm-5\" for=\"task-item-0\">\r\n            <span class=\"align-middle\">\r\n                ");
#nullable restore
#line 10 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n        </label>\r\n        <label class=\"flex-grow-1 mr-3 py-3 col-sm-4\" for=\"task-item-0\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ab1f302f3bf49dbcff3fbee1d96873863ca0f455565", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
              WriteLiteral(item.Quantidade);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "text", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
AddHtmlAttributeValue("", 625, item.Quantidade, 625, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onkeyup", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 652, "atualizarQtdMaterialTerapia(\'", 652, 29, true);
#nullable restore
#line 14 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
AddHtmlAttributeValue("", 681, item.Id, 681, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 689, "\')", 689, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 14 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Quantidade);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 789, "_input_", 789, 7, true);
#nullable restore
#line 14 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
AddHtmlAttributeValue("", 796, item.Id, 796, 8, false);

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
            WriteLiteral("\r\n        </label>\r\n        <label class=\"flex-grow-1 mr-3 py-3 col-sm-1\" for=\"task-item-0\">\r\n            <i class=\"fa fa-trash text-danger-m1\"");
            BeginWriteAttribute("onclick", " onclick=\"", 951, "\"", 995, 3);
            WriteAttributeValue("", 961, "removerMaterialTerapia(\'", 961, 24, true);
#nullable restore
#line 17 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
WriteAttributeValue("", 985, item.Id, 985, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 993, "\')", 993, 2, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n        </label>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\prodi\Documents\Projetos\VedaSystemProject\VedaSystem.Web\Views\Terapia\_MaterialTerapiaEditList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VedaSystem.Application.ViewModels.MaterialTerapiaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
