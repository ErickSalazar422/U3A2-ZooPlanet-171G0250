#pragma checksum "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77610c06684d682a493fbfdc4fb2ed6531dcadf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Administrador_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Administrador/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77610c06684d682a493fbfdc4fb2ed6531dcadf2", @"/Areas/Admin/Views/Administrador/Index.cshtml")]
    public class Areas_Admin_Views_Administrador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ZooPlanet.Models.ViewModels.EspeciesIndexViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml"
  
    Layout = "_Layout";
    int x = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Lista de Especies</h1>

<table>
    <colgroup>
        <col style=""width:50px"" />
        <col style=""width:40px"" />
        <col />
        <col style=""width:50%"" />
    </colgroup>
    <caption>
        <a href=""/Admin/Administrador/Agregar""><i class=""fa fa-plus""></i> Agregar Especie</a>
    </caption>
    <thead>
        <tr>
            <th>#</th>
            <th colspan=""2"">Especie</th>
            <th>Acciones</th>
        </tr>
    </thead>
");
#nullable restore
#line 28 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml"
     foreach (var item in Model.Especies)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n\r\n            <tr>\r\n\r\n                <td class=\"center\">");
#nullable restore
#line 34 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml"
                               Write(x++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"width:40px\"><img");
            BeginWriteAttribute("src", " src=\"", 820, "\"", 853, 3);
            WriteAttributeValue("", 826, "/clases/", 826, 8, true);
#nullable restore
#line 35 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 834, item.IdClase, 834, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 849, ".png", 849, 4, true);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml"
               Write(item.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td class=\"center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77610c06684d682a493fbfdc4fb2ed6531dcadf25139", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i> Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 969, "~/Admin/Administrador/Editar/", 969, 29, true);
#nullable restore
#line 38 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml"
AddHtmlAttributeValue("", 998, item.Id, 998, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77610c06684d682a493fbfdc4fb2ed6531dcadf26774", async() => {
                WriteLiteral("<i class=\"fa fa-remove\"></i> Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1076, "~/Admin/Administrador/Eliminar/", 1076, 31, true);
#nullable restore
#line 39 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml"
AddHtmlAttributeValue("", 1107, item.Id, 1107, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77610c06684d682a493fbfdc4fb2ed6531dcadf28419", async() => {
                WriteLiteral("<i class=\"fa fa-image\"></i> Imagen");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1189, "~/Admin/Administrador/Imagen/", 1189, 29, true);
#nullable restore
#line 40 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml"
AddHtmlAttributeValue("", 1218, item.Id, 1218, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n\r\n\r\n        </tbody>\r\n");
#nullable restore
#line 47 "C:\Users\Carlitos Salazar\Desktop\7 semestre\padilla\u3\u3Act2\ZooPlanet\ZooPlanet\Areas\Admin\Views\Administrador\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZooPlanet.Models.ViewModels.EspeciesIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
