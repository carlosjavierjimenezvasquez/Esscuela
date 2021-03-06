#pragma checksum "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc17fd8c0711cd8d2ef3ee4932b1e41c5ce73a37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_MostrarStudents), @"mvc.1.0.view", @"/Views/Students/MostrarStudents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc17fd8c0711cd8d2ef3ee4932b1e41c5ce73a37", @"/Views/Students/MostrarStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5e22073f2e88759b87b4e552f4724e9adf8a32", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_MostrarStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Escuela.Dominio.Students>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
  
    ViewData["Title"] = "MostrarStudents";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1 class=""text-center""> enrolled students </h1>
<br />
<table class=""table table-striped table-dark"">
    <thead>
    <th>
        StudentId
    </th>
    <th>
        LastName
    </th>
    <th>
        FirstMiName
    </th>
    <th>
        DateEnrollments
    </th>
    <th>
        ");
#nullable restore
#line 25 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
   Write(Html.ActionLink("Agregar", "Registrar", new { id = 0 }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
               Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
               Write(item.FirstMiName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
               Write(item.EnrollmentsDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                \r\n                    \r\n                \r\n\r\n                <td>\r\n                   \r\n                    ");
#nullable restore
#line 44 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
               Write(Html.ActionLink("Update", "Registrar", new { id = item.StudentId,apellido = item.LastName,nombre = item.FirstMiName,fecha = item.EnrollmentsDate }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 45 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.StudentId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\carlj\Documents\GitHub\Esscuela\Escuela\Escuela\Views\Students\MostrarStudents.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Escuela.Dominio.Students>> Html { get; private set; }
    }
}
#pragma warning restore 1591
