#pragma checksum "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54fa5b079816e5444cc4beb1ee6ba7b47841192e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Aprovados), @"mvc.1.0.view", @"/Views/Administrador/Aprovados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Aprovados.cshtml", typeof(AspNetCore.Views_Administrador_Aprovados))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54fa5b079816e5444cc4beb1ee6ba7b47841192e", @"/Views/Administrador/Aprovados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc0cfda6b2bb54f88e5d7a55c241985d2df4ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Aprovados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTop.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administrador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pendentes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("info-b"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aprovados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("info-a-adm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 143, true);
            WriteLiteral("<main>\r\n\r\n    <section id=\"mini-menu\">\r\n        <div class=\"info-b-1\"><a class=\"info-b-adm\">Principal</a></div>\r\n        <div class=\"info-b-1\">");
            EndContext();
            BeginContext(189, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fa5b079816e5444cc4beb1ee6ba7b47841192e5375", async() => {
                BeginContext(261, 9, true);
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
            BeginContext(274, 21, true);
            WriteLiteral("</div>\r\n        <div>");
            EndContext();
            BeginContext(295, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fa5b079816e5444cc4beb1ee6ba7b47841192e7056", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fa5b079816e5444cc4beb1ee6ba7b47841192e8756", async() => {
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            BeginContext(573, 278, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fa5b079816e5444cc4beb1ee6ba7b47841192e10491", async() => {
                BeginContext(630, 158, true);
                WriteLiteral("\r\n            <div id=\"box-pendente\" class=\"box-pedidos\">\r\n                <div>\r\n                    Pendentes\r\n                </div>\r\n                <div>");
                EndContext();
                BeginContext(789, 22, false);
#line 17 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                Write(Model.EventosPendentes);

#line default
#line hidden
                EndContext();
                BeginContext(811, 36, true);
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
            BeginContext(851, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(863, 278, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fa5b079816e5444cc4beb1ee6ba7b47841192e12666", async() => {
                BeginContext(920, 158, true);
                WriteLiteral("\r\n            <div id=\"box-aprovado\" class=\"box-pedidos\">\r\n                <div>\r\n                    Aprovados\r\n                </div>\r\n                <div>");
                EndContext();
                BeginContext(1079, 22, false);
#line 26 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                Write(Model.EventosAprovados);

#line default
#line hidden
                EndContext();
                BeginContext(1101, 36, true);
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
            BeginContext(1141, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(1153, 282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fa5b079816e5444cc4beb1ee6ba7b47841192e14845", async() => {
                BeginContext(1211, 160, true);
                WriteLiteral("\r\n            <div id=\"box-reprovado\" class=\"box-pedidos\">\r\n                <div>\r\n                    Reprovados\r\n                </div>\r\n                <div>");
                EndContext();
                BeginContext(1372, 23, false);
#line 35 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                Write(Model.EventosReprovados);

#line default
#line hidden
                EndContext();
                BeginContext(1395, 36, true);
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
            BeginContext(1435, 573, true);
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
                            <td>Confirmar evento</td>
                        </tr>
");
            EndContext();
#line 58 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                             foreach (var item in Model.Agendar)
                            {
                                if(item.Status == 1){

#line default
#line hidden
            BeginContext(2160, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2239, 17, false);
#line 62 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                                   Write(item.NomeDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2256, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2304, 21, false);
#line 63 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                                   Write(item.PlanoEvento.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2325, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2373, 17, false);
#line 64 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                                   Write(item.TipoDeEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2390, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2438, 16, false);
#line 65 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                                   Write(item.DiaDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2454, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2502, 20, false);
#line 66 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                                   Write(item.DescricaoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2522, 49, true);
            WriteLiteral("</td>\r\n                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2571, "\'", 2661, 1);
#line 67 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
WriteAttributeValue("", 2578, Url.Action("Reprovar", "Administrador", new {id = @item.Id, pagina = "Aprovados"}), 2578, 83, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2662, 92, true);
            WriteLiteral("><i class=\"fas fa-times\" id=\"recusar\"></i></a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 69 "C:\Users\47736940843\Documents\Exercicios-Sprint-3\RoleTop\Views\Administrador\Aprovados.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(2820, 95, true);
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