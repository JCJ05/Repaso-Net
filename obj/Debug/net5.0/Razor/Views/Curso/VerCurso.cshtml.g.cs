<<<<<<< HEAD
#pragma checksum "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac107079b0a685c95555f6c5f230c7cea51418dc"
=======
#pragma checksum "D:\Documentos\USMP\Semestre virtual 2022 - I\Ingeniería de Software II\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a7fb2749219e5e9bc4015e91db96aff4e081fea"
>>>>>>> 6d890bfd37eedff05791b51202931e8a57a23934
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_VerCurso), @"mvc.1.0.view", @"/Views/Curso/VerCurso.cshtml")]
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac107079b0a685c95555f6c5f230c7cea51418dc", @"/Views/Curso/VerCurso.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a7fb2749219e5e9bc4015e91db96aff4e081fea", @"/Views/Curso/VerCurso.cshtml")]
>>>>>>> 6d890bfd37eedff05791b51202931e8a57a23934
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c06c87aa3bb18e68240d1fbd216f2a3b977d89d", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_VerCurso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Repaso_Net.Models.Curso>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n        <br>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <img class=\"rounded\"");
            BeginWriteAttribute("src", "\r\n                    src=\"", 174, "\"", 240, 2);
            WriteAttributeValue("", 201, "data:image/png;base64,", 201, 22, true);
#nullable restore
#line 9 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
WriteAttributeValue("", 223, Model.fileBase64, 223, 17, false);
=======
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Documentos\USMP\Semestre virtual 2022 - I\Ingeniería de Software II\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
     
    Layout = "_Layout";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n   \r\n       <div style=\"display: flex; justify-content: space-between;\">\r\n           \r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 253, "\"", 298, 2);
            WriteAttributeValue("", 259, "data:image/png;base64,", 259, 22, true);
#nullable restore
#line 15 "D:\Documentos\USMP\Semestre virtual 2022 - I\Ingeniería de Software II\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
WriteAttributeValue("", 281, Model.fileBase64, 281, 17, false);
>>>>>>> 6d890bfd37eedff05791b51202931e8a57a23934

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                    width=\"500\" />\r\n            </div>\r\n\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-6\">\r\n                        <h4>Curso</h4>\r\n                        <p>");
#nullable restore
<<<<<<< HEAD
#line 17 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                      Write(Model.nombre);
=======
#line 21 "D:\Documentos\USMP\Semestre virtual 2022 - I\Ingeniería de Software II\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                                  Write(Model.nombre);
>>>>>>> 6d890bfd37eedff05791b51202931e8a57a23934

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <h4>Docente</h4>\r\n                        <p>Ing. ");
#nullable restore
<<<<<<< HEAD
#line 21 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                           Write(Model.usuario.nombres);
=======
#line 22 "D:\Documentos\USMP\Semestre virtual 2022 - I\Ingeniería de Software II\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                                                               Write(Model.fechaInicio.ToString("dd/MM/yyyy"));
>>>>>>> 6d890bfd37eedff05791b51202931e8a57a23934

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
<<<<<<< HEAD
#line 21 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                                                  Write(Model.usuario.apellidos);
=======
#line 23 "D:\Documentos\USMP\Semestre virtual 2022 - I\Ingeniería de Software II\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                                                            Write(Model.fechaFin.ToString("dd/MM/yyyy"));
>>>>>>> 6d890bfd37eedff05791b51202931e8a57a23934

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-12\">\r\n                            <h4>Descripción</h4>\r\n                            <p>");
#nullable restore
<<<<<<< HEAD
#line 26 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                          Write(Model.informacion);
=======
#line 24 "D:\Documentos\USMP\Semestre virtual 2022 - I\Ingeniería de Software II\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                                                            Write(Model.precio);
>>>>>>> 6d890bfd37eedff05791b51202931e8a57a23934

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div><br>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-6\">\r\n                        <h4>Fecha de Inicio</h4>\r\n                        <p>");
#nullable restore
<<<<<<< HEAD
#line 33 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                      Write(Model.fechaInicio.ToString("dd/MM/yyyy"));
=======
#line 25 "D:\Documentos\USMP\Semestre virtual 2022 - I\Ingeniería de Software II\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                                                        Write(Model.cupo);
>>>>>>> 6d890bfd37eedff05791b51202931e8a57a23934

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <h4>Fecha de Fin</h4>\r\n                        <p>");
#nullable restore
#line 37 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                      Write(Model.fechaFin.ToString("dd/MM/yyyy"));
=======
            WriteLiteral(" cupos disponibles</p>\r\n                <p class=\"card-text\"><strong>Descripción:</strong> ");
#nullable restore
#line 26 "D:\Documentos\USMP\Semestre virtual 2022 - I\Ingeniería de Software II\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                                                              Write(Model.informacion);
>>>>>>> 6d890bfd37eedff05791b51202931e8a57a23934

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-6\">\r\n                        <h4>Horario</h4>\r\n                        <p>");
#nullable restore
#line 43 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                      Write(Model.horario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <h4>Cupos:</h4>\r\n                        <p>");
#nullable restore
#line 45 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                      Write(Model.cupo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" participantes</p>\r\n                        <h4>Precio</h4>\r\n                        <p>S/. ");
#nullable restore
#line 47 "C:\Users\Julio\OneDrive - Universidad de San Martin de Porres\Documentos\ASUP\Repaso-Net\Views\Curso\VerCurso.cshtml"
                          Write(Model.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    \r\n                </div>\r\n                <a href=\"#\" class=\"btn btn-primary\">Inscribirse</a>\r\n            </div>\r\n        </div>\r\n\r\n    \r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Repaso_Net.Models.Curso> Html { get; private set; }
    }
}
#pragma warning restore 1591
