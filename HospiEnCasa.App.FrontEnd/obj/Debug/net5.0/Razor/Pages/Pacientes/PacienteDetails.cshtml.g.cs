#pragma checksum "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea39a0dac2aca1b6456ca66761b4ac555977b54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.FrontEnd.Pages.Pacientes.Pages_Pacientes_PacienteDetails), @"mvc.1.0.razor-page", @"/Pages/Pacientes/PacienteDetails.cshtml")]
namespace HospiEnCasa.App.FrontEnd.Pages.Pacientes
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
#line 1 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea39a0dac2aca1b6456ca66761b4ac555977b54", @"/Pages/Pacientes/PacienteDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838d893bfb9edbc2070b3bf50586b3a2a49e3e05", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pacientes_PacienteDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./PacientesList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
Write(Model.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
                      Write(Model.Paciente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    Direccion: ");
#nullable restore
#line 7 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
          Write(Model.Paciente.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Ciudad: ");
#nullable restore
#line 10 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
       Write(Model.Paciente.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Telefono: ");
#nullable restore
#line 13 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
         Write(Model.Paciente.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Fecha de Nacimiento: ");
#nullable restore
#line 16 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
                    Write(Model.Paciente.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Familiar: ");
#nullable restore
#line 19 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
         Write(Model.Paciente.Familiar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Enfermera: ");
#nullable restore
#line 22 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
          Write(Model.Paciente.Enfermera);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Medico: ");
#nullable restore
#line 25 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
       Write(Model.Paciente.Medico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Historia: ");
#nullable restore
#line 28 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\PacienteDetails.cshtml"
         Write(Model.Paciente.Historia);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cea39a0dac2aca1b6456ca66761b4ac555977b546561", async() => {
                WriteLiteral("Lista de Pacientes ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.FrontEnd.Pages.PacienteDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.FrontEnd.Pages.PacienteDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.FrontEnd.Pages.PacienteDetailsModel>)PageContext?.ViewData;
        public HospiEnCasa.App.FrontEnd.Pages.PacienteDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591