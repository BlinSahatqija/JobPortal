#pragma checksum "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be02ac87b570fb1f090482aae927b7d1a8519259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Jobs_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Jobs/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Jobs/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_Jobs_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be02ac87b570fb1f090482aae927b7d1a8519259", @"/Areas/Admin/Views/Jobs/Create.cshtml")]
    public class Areas_Admin_Views_Jobs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobPortalProject.Models.Job>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 620, true);
            WriteLiteral(@"
<h2>Create</h2>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""JobName"" class=""control-label""></label>
                <input asp-for=""JobName"" class=""form-control"" />
                <span asp-validation-for=""JobName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
                <select asp-for=""City"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("asp-items", " asp-items=\"", 741, "\"", 790, 1);
#line 21 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Create.cshtml"
WriteAttributeValue("", 753, Html.GetEnumSelectList(typeof(City)), 753, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(791, 279, true);
            WriteLiteral(@"></select>
                <span asp-validation-for=""City"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Category"" class=""control-label""></label>
                <select asp-for=""Category"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("asp-items", " asp-items=\"", 1070, "\"", 1123, 1);
#line 26 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Create.cshtml"
WriteAttributeValue("", 1082, Html.GetEnumSelectList(typeof(Category)), 1082, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1124, 1162, true);
            WriteLiteral(@"></select>
                <span asp-validation-for=""Category"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DateIn"" class=""control-label""></label>
                <input asp-for=""DateIn"" class=""form-control"" />
                <span asp-validation-for=""DateIn"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DateOut"" class=""control-label""></label>
                <input asp-for=""DateOut"" class=""form-control"" />
                <span asp-validation-for=""DateOut"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" ");
            WriteLiteral("class=\"btn btn-default\" />\n            </div>\n        </form>\n    </div>\n</div>\n\n<div>\n    <a asp-action=\"Index\">Back to List</a>\n</div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobPortalProject.Models.Job> Html { get; private set; }
    }
}
#pragma warning restore 1591
