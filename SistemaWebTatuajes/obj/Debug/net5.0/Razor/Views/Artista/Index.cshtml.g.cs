#pragma checksum "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18814b918838fe1bb01cb555d7aa65acfd66d9ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artista_Index), @"mvc.1.0.view", @"/Views/Artista/Index.cshtml")]
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
#line 1 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\_ViewImports.cshtml"
using SistemaWebTatuajes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\_ViewImports.cshtml"
using SistemaWebTatuajes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18814b918838fe1bb01cb555d7aa65acfd66d9ec", @"/Views/Artista/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b644af0f43cb5ff137fc65bbd6ae4b54e4622600", @"/Views/_ViewImports.cshtml")]
    public class Views_Artista_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaWebTatuajes.Models.Artistas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-artistas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Paginador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"card shadow\">\r\n        <div class=\"card-header bg-dark text-white\">\r\n            Lista de Artistas\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18814b918838fe1bb01cb555d7aa65acfd66d9ec5296", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> Agregar nuevo artista");
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
                            <th>Cédula</th>
                            <th>Nombre</th>
                            <th>Apellidos</th>
                            <th>Bibliografía</th>
                            <th>Foto</th>
                            <th>Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 30 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("foto", " foto=\"", 1122, "\"", 1139, 1);
#nullable restore
#line 32 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
WriteAttributeValue("", 1129, item.foto, 1129, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id_Artista));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.bibligrafia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "18814b918838fe1bb01cb555d7aa65acfd66d9ec9293", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1541, "~/Artistas/", 1541, 11, true);
#nullable restore
#line 37 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
AddHtmlAttributeValue("", 1552, item.foto, 1552, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1699, "\"", 1733, 3);
            WriteAttributeValue("", 1709, "editar(", 1709, 7, true);
#nullable restore
#line 39 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
WriteAttributeValue("", 1716, item.Id_Artista, 1716, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1732, ")", 1732, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></button>\r\n                                    <button class=\"btn btn-danger\"><i class=\"fas fa-trash\"></i></button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Rleit\OneDrive\Documents\Git\Andrey\tatuajeweb\SistemaWebTatuajes\Views\Artista\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "18814b918838fe1bb01cb555d7aa65acfd66d9ec12090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        //FUNCION PARA OBTENER LA CEDULA Y FOTO
        $(document).on(""click"", '.btn-danger', function (e) {
            e.preventDefault();

            var cedula = $(this).parents(""tr"").find(""td"")[0].innerHTML.trim();
            const element = document.activeElement.parentElement.parentElement;
            const foto = $(element).attr(""foto"").trim();

            eliminar(cedula, foto);
        });
        //FUNCION ELIMINAR
        function eliminar(cedula, foto) {
            alertify.confirm(""Información"", ""Esta seguró que desea eliminar el artista seleccionado?"",
                function () {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Artista/Delete"",
                        data: { cedula: cedula, foto: foto },
                        beforeSend: function () {
                            $("".contenedor-loader"").slideToggle();
                        },
                        success: function (r) {
       ");
                WriteLiteral(@"                     switch (r) {
                                case 1:
                                    window.location.href = ""/Artista/Index"";
                                    break;
                                case 2:
                                    $("".contenedor-loader"").slideToggle();
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
        //FUNCION PARA EDITAR
        function editar(cedula) {
            window.location.href = ""/Artista/Edit?cedula="" + cedula;
        }
        //FUNCION PARA EL PAGINADOR
        $("".page-lin");
                WriteLiteral("k\").on(\"click\", function () {\r\n            var pagina = $(this).text();\r\n            window.location.href = \"/Artista/Index?pagina=\" + pagina;\r\n        });\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaWebTatuajes.Models.Artistas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
