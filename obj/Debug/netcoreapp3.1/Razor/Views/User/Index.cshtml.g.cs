#pragma checksum "C:\Users\felip\Documents\git\Projeto-cti\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e6255becc5af33539015ffb763cafaca981f11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\felip\Documents\git\Projeto-cti\Views\_ViewImports.cshtml"
using Projeto_cti;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felip\Documents\git\Projeto-cti\Views\_ViewImports.cshtml"
using Projeto_cti.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e6255becc5af33539015ffb763cafaca981f11", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"558e789309b424544315a43ae1039bee120fa5fc", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <h4 class=""card-title"">Informações do perfil</h4>
                                </div>
                                <div class=""card-body"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e6255becc5af33539015ffb763cafaca981f113672", async() => {
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-md-9 pl-1"">
                                                <div class=""form-group"">
                                                    <label>Endereço de Email</label>
                                                    <input type=""email"" class=""form-control"" placeholder=""Email"" value=""franciscojo.gmailcom"">
                                                </div>
                                            </div>
                                            <div class=""col-md-3 px-1"">
                                                <div class=""form-group"">
                                                    <label>Usuário</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Username"" value=""francisquinho123"">
                                                </div>
                                            </div>
     ");
                WriteLiteral(@"                                   </div>
                                        <div class=""row"">
                                            <div class=""col-md-6 pr-1"">
                                                <div class=""form-group"">
                                                    <label>Primeiro Nome</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Company"" value=""Jose"">
                                                </div>
                                            </div>
                                            <div class=""col-md-6 pl-1"">
                                                <div class=""form-group"">
                                                    <label>Último Nome</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Last Name"" value=""Francisco"">
                                                </div>
                                     ");
                WriteLiteral(@"       </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""form-group"">
                                                    <label>Endereço</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Home Address"" value=""Av. Consolta, 203"">
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-4 pr-1"">
                                                <div class=""form-group"">
                                                    <label>Cidade</label>
                                                    <input type=""text"" class=""form-control"" placeh");
                WriteLiteral(@"older=""City"" value=""Consolta"">
                                                </div>
                                            </div>
                                            <div class=""col-md-4 px-1"">
                                                <div class=""form-group"">
                                                    <label>País</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Country"" value=""Brasil"">
                                                </div>
                                            </div>
                                            <div class=""col-md-4 pl-1"">
                                                <div class=""form-group"">
                                                    <label>CEP</label>
                                                    <input type=""number"" class=""form-control"" placeholder=""ZIP Code"" value=""98910000"">
                                                </div>
              ");
                WriteLiteral("                              </div>\r\n                                        </div>\r\n                                        <div class=\"clearfix\"></div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>");
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
