#pragma checksum "D:\Jyo\.netcore\EmployeeData\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fcb3aae84a2e6b704b47cfc6808ebdbcd7b288a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
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
#line 1 "D:\Jyo\.netcore\EmployeeData\Views\_ViewImports.cshtml"
using EmployeeData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Jyo\.netcore\EmployeeData\Views\_ViewImports.cshtml"
using EmployeeData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fcb3aae84a2e6b704b47cfc6808ebdbcd7b288a", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3704216ce3bd633753a8ed329d849a7f6d34730", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeData.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Jyo\.netcore\EmployeeData\Views\Employee\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
#nullable restore
#line 8 "D:\Jyo\.netcore\EmployeeData\Views\Employee\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <td>EmployeeId</td>\r\n            <td>");
#nullable restore
#line 13 "D:\Jyo\.netcore\EmployeeData\Views\Employee\Create.cshtml"
           Write(Html.TextBoxFor(m => m.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Name</td>\r\n            <td>");
#nullable restore
#line 17 "D:\Jyo\.netcore\EmployeeData\Views\Employee\Create.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Desigination</td>\r\n            <td>");
#nullable restore
#line 21 "D:\Jyo\.netcore\EmployeeData\Views\Employee\Create.cshtml"
           Write(Html.DropDownListFor(m => m.Desigination, ViewBag.Desigination as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <td>ProjectName</td>\r\n            <td>");
#nullable restore
#line 26 "D:\Jyo\.netcore\EmployeeData\Views\Employee\Create.cshtml"
           Write(Html.DropDownListFor(m => m.ProjectName, ViewBag.ProjectName as SelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>Password</td>\r\n            <td>");
#nullable restore
#line 31 "D:\Jyo\.netcore\EmployeeData\Views\Employee\Create.cshtml"
           Write(Html.Password("Pwd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <input type=\"submit\" value=\"Register\" />\r\n            </td>\r\n        </tr>\r\n        \r\n        \r\n    </table>\r\n");
#nullable restore
#line 41 "D:\Jyo\.netcore\EmployeeData\Views\Employee\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeData.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
