#pragma checksum "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31f2d3cd31cd5be63151e3a6e6aad16cc4ed3505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lecturer_detailStudents), @"mvc.1.0.view", @"/Views/Lecturer/detailStudents.cshtml")]
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
#line 1 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31f2d3cd31cd5be63151e3a6e6aad16cc4ed3505", @"/Views/Lecturer/detailStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Lecturer_detailStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.Models.StudentCollege>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
  
    ViewData["Title"] = "detailStudents";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br>\r\n\r\n<div>\r\n\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayNameFor(model => model.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayFor(model => model.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayNameFor(model => model.Rollno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayFor(model => model.Rollno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayNameFor(model => model.Degree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayFor(model => model.Degree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayNameFor(model => model.Batch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayFor(model => model.Batch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayNameFor(model => model.Cgpa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "C:\Users\J.C.han6\Desktop\.NET Workshop\WebApp\CMS\Views\Lecturer\detailStudents.cshtml"
       Write(Html.DisplayFor(model => model.Cgpa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.Models.StudentCollege> Html { get; private set; }
    }
}
#pragma warning restore 1591
