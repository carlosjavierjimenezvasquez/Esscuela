#pragma checksum "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce36a0559ce14b50bd71a0bd6bfe36e0f813e856"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuorse_MostrarCourses), @"mvc.1.0.view", @"/Views/Cuorse/MostrarCourses.cshtml")]
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
#line 1 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce36a0559ce14b50bd71a0bd6bfe36e0f813e856", @"/Views/Cuorse/MostrarCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5e22073f2e88759b87b4e552f4724e9adf8a32", @"/Views/_ViewImports.cshtml")]
    public class Views_Cuorse_MostrarCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Escuela.Dominio.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml"
  
    ViewData["Title"] = "MostrarCourses";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center""> enrolled courses </h1>
<br />
<table class=""table table-striped table-dark"">
    <thead>
    <th>
        CourseId
    </th>
    <th>
        Título
    </th>
    <th>
      Creditos
    </th>
   
    <th>
        ");
#nullable restore
#line 22 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml"
   Write(Html.ActionLink("Agregar", "Rcourses", new { id = 0 }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml"
               Write(item.CouserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml"
               Write(item.Credits);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 39 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml"
               Write(Html.ActionLink("Update", "Rcourses", new { id = item.CouserId, titulo = item.Title, creditos = item.Credits,  }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.CouserId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Cuorse\MostrarCourses.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Escuela.Dominio.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591