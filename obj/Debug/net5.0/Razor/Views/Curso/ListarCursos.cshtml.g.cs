#pragma checksum "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74f83d3c8ffae247a41f9d0bbb546bbf974e4bc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_ListarCursos), @"mvc.1.0.view", @"/Views/Curso/ListarCursos.cshtml")]
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
#line 1 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\_ViewImports.cshtml"
using Repaso_Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\_ViewImports.cshtml"
using Repaso_Net.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f83d3c8ffae247a41f9d0bbb546bbf974e4bc7", @"/Views/Curso/ListarCursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c06c87aa3bb18e68240d1fbd216f2a3b977d89d", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_ListarCursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Curso>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Curso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegistrarCurso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarCurso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EliminarCurso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
     
    Layout = "_Layout";
    ViewData["Title"] = "LISTA DE CURSOS";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container mt-5\">\r\n\r\n <h1 class=\"text-center\">");
#nullable restore
#line 11 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
                    Write(ViewData["Tittle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n <div class=\"mt-3\">\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f83d3c8ffae247a41f9d0bbb546bbf974e4bc76209", async() => {
                WriteLiteral("Nueva Curso");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

 </div>

  <br>

<table class=""table table-striped table-hover"">  

  <thead class=""table-dark"">
    <tr>  
        <th> Codigo </th> 
        <th> Nombre </th>
        <th> Fecha de Inicio </th>
        <th> Fecha de fin </th>
        <th> Horario </th>
        <th> Cupo </th>
        <th>Profesor</th>
        <th>Precio</th>
        <th>Imagenes</th>
        <th> Editar </th>
        <th> Eliminar </th>
          
    </tr>  

    </thead>
  
  <tbody>

");
#nullable restore
#line 43 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
 foreach (var item in Model) {  

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>  \r\n          \r\n         <td> ");
#nullable restore
#line 46 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
         Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>  \r\n         <td> ");
#nullable restore
#line 47 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
         Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n         <td> ");
#nullable restore
#line 48 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
         Write(Html.DisplayFor(modelItem => item.fechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n         <td> ");
#nullable restore
#line 49 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
         Write(Html.DisplayFor(modelItem => item.fechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n         <td> ");
#nullable restore
#line 50 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
         Write(Html.DisplayFor(modelItem => item.horario));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n         <td> ");
#nullable restore
#line 51 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
         Write(Html.DisplayFor(modelItem => item.cupo));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n         <td> ");
#nullable restore
#line 52 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
         Write(Html.DisplayFor(modelItem => item.usuario.nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n         <td> ");
#nullable restore
#line 53 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
         Write(Html.DisplayFor(modelItem => item.precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n         <td> <img");
            BeginWriteAttribute("src", " src=\"", 1404, "\"", 1448, 2);
            WriteAttributeValue("", 1410, "data:image/png;base64,", 1410, 22, true);
#nullable restore
#line 54 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
WriteAttributeValue("", 1432, item.fileBase64, 1432, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> </td>\r\n         <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f83d3c8ffae247a41f9d0bbb546bbf974e4bc711530", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
                                                                                        WriteLiteral(item.Id);

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
            WriteLiteral(" </td>   \r\n         <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74f83d3c8ffae247a41f9d0bbb546bbf974e4bc714082", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
                                                                                            WriteLiteral(item.Id);

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
            WriteLiteral("</td> \r\n         \r\n    </tr>  \r\n");
#nullable restore
#line 59 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\ListarCursos.cshtml"
}  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n </tbody>\r\n  \r\n</table> \r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Curso>> Html { get; private set; }
    }
}
#pragma warning restore 1591
