#pragma checksum "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35a1b74f717b476a5594d14b8acf63035e2a3e8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Delete), @"mvc.1.0.view", @"/Views/Pessoa/Delete.cshtml")]
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
#line 1 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/_ViewImports.cshtml"
using Andor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/_ViewImports.cshtml"
using Andor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35a1b74f717b476a5594d14b8acf63035e2a3e8e", @"/Views/Pessoa/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288c5a9ddb5fd1c028eeae70cc9832c77f248cf4", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Andor.Models.Pessoa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/perfil.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/ver.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnn btn-editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Excluir</h1>
<div id=""scrollbar"" class=""container-fluid pt-0 bg-light"" >
    <div class=""container"" style=""padding-bottom:150px;"">
        <div class=""row container-perfil-details p-2"">
            <div class=""perfil-menu mt-2 p-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35a1b74f717b476a5594d14b8acf63035e2a3e8e6691", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>    
            <!-- Forms -->
            <div class=""forms-details mt-2""><!-- coluna da direita -->
                <div id=""perfil"">
                    <div class=""row"">
                        <div class=""col-12"">
                             <h4 class=""text-center mt-2 py-1 text-white bg-danger rounded-3"">Tem certeza que deseja excluir o seu perfil?</h4>
                        </div>
                    </div>
                    <div");
            BeginWriteAttribute("class", " class=\"", 839, "\"", 847, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        <dl class=\"row mt-3\">\n                            <dt class=\"col-sm-3\">");
#nullable restore
#line 23 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 24 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">");
#nullable restore
#line 25 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 26 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">");
#nullable restore
#line 27 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n                            <dd class=\"col-sm-9\"><a id=\"senha\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35a1b74f717b476a5594d14b8acf63035e2a3e8e10175", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a> <span id=\"s-senha\" style=\"display:none\">");
#nullable restore
#line 28 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                                                                                                                              Write(Html.DisplayFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></dd>\n                            <dt class=\"col-sm-3\">");
#nullable restore
#line 29 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 30 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Convert.ToInt64(Model.Telefone).ToString("(00) 00000-0000"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">");
#nullable restore
#line 31 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.CRNM));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 32 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Model.CRNM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">");
#nullable restore
#line 33 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 34 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Convert.ToInt64(Model.CPF).ToString(@"000\.000\.000\-00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">Endereço</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 36 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">Número</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 38 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">");
#nullable restore
#line 39 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.CEP));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 40 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Model.CEP.ToString("#####-###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">");
#nullable restore
#line 41 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 42 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">Data de nascimento</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 44 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(String.Format("{0:dd/MM/yyyy}",Model.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">");
#nullable restore
#line 45 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayNameFor(model => model.Nacionalidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 46 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.Nacionalidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                            <dt class=\"col-sm-3\">Data de cadastro</dt>\n                            <dd class=\"col-sm-9\">");
#nullable restore
#line 48 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                            Write(String.Format("{0:dd/MM/yyyy}",Model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n                        </dl>\n                        <div class=\"d-flex justify-content-end pt-2\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35a1b74f717b476a5594d14b8acf63035e2a3e8e17438", async() => {
                WriteLiteral(" \n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35a1b74f717b476a5594d14b8acf63035e2a3e8e17726", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 52 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("            \n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35a1b74f717b476a5594d14b8acf63035e2a3e8e19438", async() => {
                    WriteLiteral("Não");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/thiago/Documents/GitHub/Projeto_Final_VF/Views/Pessoa/Delete.cshtml"
                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \n                                <input type=\"submit\" value=\"Sim\" class=\"btnn btn-excluir ml-2\" />  \n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n         </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Andor.Models.Pessoa> Html { get; private set; }
    }
}
#pragma warning restore 1591