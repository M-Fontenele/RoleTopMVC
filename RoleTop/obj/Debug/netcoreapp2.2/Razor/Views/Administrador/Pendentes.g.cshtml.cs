#pragma checksum "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bd83c22cf19c730cf95ffe3f3096eeb51d194e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Pendentes), @"mvc.1.0.view", @"/Views/Administrador/Pendentes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Pendentes.cshtml", typeof(AspNetCore.Views_Administrador_Pendentes))]
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
#line 1 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\_ViewImports.cshtml"
using RoleTop;

#line default
#line hidden
#line 2 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\_ViewImports.cshtml"
using RoleTop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd83c22cf19c730cf95ffe3f3096eeb51d194e5", @"/Views/Administrador/Pendentes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Pendentes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pendentes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("info-a-adm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aprovados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("info-b"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reprovados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 126, true);
            WriteLiteral("<main>\r\n\r\n    <section id=\"mini-menu\">\r\n        <div class=\"info-b-1\"><a class=\"info-b-adm\">Principal</a></div>\r\n        <div>");
            EndContext();
            BeginContext(172, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd83c22cf19c730cf95ffe3f3096eeb51d194e55356", async() => {
                BeginContext(248, 9, true);
                WriteLiteral("Pendentes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(261, 38, true);
            WriteLiteral("</div>\r\n        <div class=\"info-b-1\">");
            EndContext();
            BeginContext(299, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd83c22cf19c730cf95ffe3f3096eeb51d194e57056", async() => {
                BeginContext(371, 9, true);
                WriteLiteral("Aprovados");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(384, 38, true);
            WriteLiteral("</div>\r\n        <div class=\"info-b-1\">");
            EndContext();
            BeginContext(422, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd83c22cf19c730cf95ffe3f3096eeb51d194e58756", async() => {
                BeginContext(495, 10, true);
                WriteLiteral("Reprovados");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(509, 64, true);
            WriteLiteral("</div>\r\n    </section>\r\n\r\n    <div id=\"box-principal\">\r\n        ");
            EndContext();
            BeginContext(573, 282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd83c22cf19c730cf95ffe3f3096eeb51d194e510491", async() => {
                BeginContext(630, 162, true);
                WriteLiteral("\r\n            <div id=\"box-pendente\" class=\"box-pedidos\">\r\n                <div>\r\n                    Pendentes\r\n                    </div>\r\n                <div>");
                EndContext();
                BeginContext(793, 22, false);
#line 17 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                Write(Model.EventosPendentes);

#line default
#line hidden
                EndContext();
                BeginContext(815, 36, true);
                WriteLiteral("</div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(855, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(867, 278, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd83c22cf19c730cf95ffe3f3096eeb51d194e512670", async() => {
                BeginContext(924, 158, true);
                WriteLiteral("\r\n            <div id=\"box-aprovado\" class=\"box-pedidos\">\r\n                <div>\r\n                    Aprovados\r\n                </div>\r\n                <div>");
                EndContext();
                BeginContext(1083, 22, false);
#line 26 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                Write(Model.EventosAprovados);

#line default
#line hidden
                EndContext();
                BeginContext(1105, 36, true);
                WriteLiteral("</div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1145, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(1157, 282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bd83c22cf19c730cf95ffe3f3096eeb51d194e514849", async() => {
                BeginContext(1215, 160, true);
                WriteLiteral("\r\n            <div id=\"box-reprovado\" class=\"box-pedidos\">\r\n                <div>\r\n                    Reprovados\r\n                </div>\r\n                <div>");
                EndContext();
                BeginContext(1376, 23, false);
#line 35 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                Write(Model.EventosReprovados);

#line default
#line hidden
                EndContext();
                BeginContext(1399, 36, true);
                WriteLiteral("</div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1439, 581, true);
            WriteLiteral(@"
    </div>
    
        <table>
            <thead>
                <tr>
                    <th colspan=""7"">Pedidos</th>
                </tr>
                <tfoot>

                </tfoot>

                <tbody>
                        <tr>
                            <td>Nome</td>
                            <td>Plano</td>
                            <td>Tipo</td>
                            <td>Dia</td>
                            <td>Descrição</td>
                            <td colspan=""2"">Confirmar evento</td>
                        </tr>
");
            EndContext();
#line 58 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                             foreach (var item in Model.Agendar)
                            {
                                if(item.Status == 0){

#line default
#line hidden
            BeginContext(2172, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2251, 17, false);
#line 62 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                                   Write(item.NomeDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2268, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2316, 21, false);
#line 63 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                                   Write(item.PlanoEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2337, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2385, 17, false);
#line 64 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                                   Write(item.TipoDeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2402, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2450, 16, false);
#line 65 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                                   Write(item.DiaDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2466, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2514, 20, false);
#line 66 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                                   Write(item.DescricaoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2534, 49, true);
            WriteLiteral("</td>\r\n                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2583, "\'", 2650, 1);
#line 67 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
WriteAttributeValue("", 2590, Url.Action("Aprovar", "Administrador", new {id = @item.Id}), 2590, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2651, 95, true);
            WriteLiteral("><i class=\"fas fa-check\" id=\"aceitar\"></i></a></td>\r\n                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2746, "\'", 2836, 1);
#line 68 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
WriteAttributeValue("", 2753, Url.Action("Reprovar", "Administrador", new {id = @item.Id, pagina = "Pendentes"}), 2753, 83, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2837, 92, true);
            WriteLiteral("><i class=\"fas fa-times\" id=\"recusar\"></i></a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 70 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Pendentes.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(2995, 95, true);
            WriteLiteral("                </tbody>\r\n            </thead>\r\n        </table>\r\n    </section>\r\n    \r\n</main>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTop.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
