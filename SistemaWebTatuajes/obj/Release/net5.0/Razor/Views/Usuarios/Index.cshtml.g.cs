#pragma checksum "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f23e70092f7c32e3018d73866e1e7e0153cf283b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\_ViewImports.cshtml"
using SistemaWebTatuajes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\_ViewImports.cshtml"
using SistemaWebTatuajes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23e70092f7c32e3018d73866e1e7e0153cf283b", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b644af0f43cb5ff137fc65bbd6ae4b54e4622600", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaWebTatuajes.Models.Usuarios>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Paginador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"card shadow\">\r\n        <div class=\"card-header bg-dark text-white\">\r\n            Lista de Usuarios\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f23e70092f7c32e3018d73866e1e7e0153cf283b4896", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> Agregar nuevo usuario");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </p>
            <div class=""table-responsive"">
                <table class=""table table-bordered table-hover"">
                    <thead class=""bg-dark text-white"">
                        <tr>
                            <th>Id Usuario</th>
                            <th>USUARIO</th>
                            <th>Nombre Completo</th>
                            <th>Email</th>
                            <th>Rol</th>
                            <th>Acciones</th>
                        </tr>
                    </thead>
");
#nullable restore
#line 29 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                     if (Model.Count > 0 || Model != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 35 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.id_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 36 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.nom_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 37 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.nombre_Completo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 38 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                                     if (item.Id_Rol == 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>Administrador</td>");
#nullable restore
#line 39 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                                                                                 }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>Usuario</td>");
#nullable restore
#line 39 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1819, "\"", 1853, 3);
            WriteAttributeValue("", 1829, "editar(", 1829, 7, true);
#nullable restore
#line 41 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 1836, item.id_Usuario, 1836, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1852, ")", 1852, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></button>\r\n                                        <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1963, "\"", 1999, 3);
            WriteAttributeValue("", 1973, "eliminar(", 1973, 9, true);
#nullable restore
#line 42 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 1982, item.id_Usuario, 1982, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1998, ")", 1998, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i></button>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n");
#nullable restore
#line 47 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Usuarios\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f23e70092f7c32e3018d73866e1e7e0153cf283b12118", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>


        //FUNCION PARA EDITAR
        function editar(id) {
            window.location.href = ""/Usuarios/Edit?id_Usuario="" + id;
        }
        //FUNCION PARA ELIMINAR
        function eliminar(id) {

            alertify.confirm(""Información"", ""Esta seguró que desea eliminar el usuario seleccionado?"",
                function () {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Usuarios/Delete"",
                        data: { id_usuario: id },
                        beforeSend: function () {
                            $("".contenedor-loader"").slideToggle();
                        },
                        success: function (r) {
                            switch (r) {
                                case 1:
                                    window.location.href = ""/Usuarios/Index"";
                                    break;
                                case 2:
                                    $("".cont");
                WriteLiteral(@"enedor-loader"").slideToggle();
                                    alertify.error(""<i class='fas fa-times'></i> Error al eliminar."");
                                    break;
                            }
                        },
                        error: function () {
                            $(""#contenedor-loader"").slideToggle();
                        }
                    });
                },
                function () {
                    alertify.error('Canceló.');
                });

        }
        //FUNCION PARA EL PAGINADOR
        $("".page-link"").on(""click"", function () {
            var pagina = $(this).text();
            window.location.href = ""/Usuarios/Index?pagina="" + pagina;
        });

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaWebTatuajes.Models.Usuarios>> Html { get; private set; }
    }
}
#pragma warning restore 1591
