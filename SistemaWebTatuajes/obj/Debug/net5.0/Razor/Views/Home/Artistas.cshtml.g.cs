#pragma checksum "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Home\Artistas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cb381243af13c8bc90e6e214ef818495840ad8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Artistas), @"mvc.1.0.view", @"/Views/Home/Artistas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb381243af13c8bc90e6e214ef818495840ad8b", @"/Views/Home/Artistas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b644af0f43cb5ff137fc65bbd6ae4b54e4622600", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Artistas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaWebTatuajes.Models.Artistas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-lg-12 col-md-12 col-sm-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%; height:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Home\Artistas.cshtml"
  
    ViewData["Title"] = "Artistas";
    Layout = "~/Views/Shared/HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mb-4\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Home\Artistas.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-12 col-sm-12 mb-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3cb381243af13c8bc90e6e214ef818495840ad8b5222", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 336, "~/Artistas/", 336, 11, true);
#nullable restore
#line 13 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Home\Artistas.cshtml"
AddHtmlAttributeValue("", 347, item.foto, 347, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-9 col-md-12 col-sm-12 mb-4\">\r\n                <div class=\"form-group\">\r\n                    <h5>");
#nullable restore
#line 18 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Home\Artistas.cshtml"
                   Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <p class=\"text-justify\">");
#nullable restore
#line 21 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Home\Artistas.cshtml"
                                       Write(item.bibligrafia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Home\Artistas.cshtml"
               Write(Html.ActionLink("Ver tatuajes elaborados", "Tatuajes", new { cedula = item.Id_Artista }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\Bauglir\Desktop\TESIS Andrey\PAGINA WEB\Sin BD\Andrey\SistemaWebTatuajes\SistemaWebTatuajes\Views\Home\Artistas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"container text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3cb381243af13c8bc90e6e214ef818495840ad8b8607", async() => {
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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        //FUNCION PARA EL PAGINADOR\r\n        $(\".page-link\").on(\"click\", function () {\r\n            var pagina = $(this).text();\r\n            window.location.href = \"/Home/Artistas?pagina=\" + pagina;\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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