#pragma checksum "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe70419c07d1c5ac7035db90b36e1e89767ef1de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Jobs_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Jobs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Jobs/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Jobs_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe70419c07d1c5ac7035db90b36e1e89767ef1de", @"/Areas/Admin/Views/Jobs/Details.cshtml")]
    public class Areas_Admin_Views_Jobs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobPortalProject.Models.Job>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 92, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(215, 43, false);
#line 14 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobName));

#line default
#line hidden
            EndContext();
            BeginContext(258, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(299, 39, false);
#line 17 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobName));

#line default
#line hidden
            EndContext();
            BeginContext(338, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(379, 40, false);
#line 20 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(419, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(460, 36, false);
#line 23 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(496, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(537, 44, false);
#line 26 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(581, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(622, 40, false);
#line 29 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(662, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(703, 47, false);
#line 32 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(750, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(791, 43, false);
#line 35 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(834, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(875, 42, false);
#line 38 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateIn));

#line default
#line hidden
            EndContext();
            BeginContext(917, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(958, 38, false);
#line 41 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateIn));

#line default
#line hidden
            EndContext();
            BeginContext(996, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1037, 43, false);
#line 44 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOut));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1121, 39, false);
#line 47 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOut));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 62, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1222, "\"", 1246, 1);
#line 52 "C:\Users\User\Desktop\SEMESTRI 5\Hyje ne Web Programim\Projekti\JobPortal\JobPortalProject\Areas\Admin\Views\Jobs\Details.cshtml"
WriteAttributeValue("", 1237, Model.Id, 1237, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1247, 62, true);
            WriteLiteral(">Edit</a> |\n    <a asp-action=\"Index\">Back to List</a>\n</div>\n");
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
