#pragma checksum "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Suplementary\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c0228cc6bcad06781e1b53e7630579069e12157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Bookings_Views_Suplementary_Details), @"mvc.1.0.view", @"/Areas/Bookings/Views/Suplementary/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Bookings/Views/Suplementary/Details.cshtml", typeof(AspNetCore.Areas_Bookings_Views_Suplementary_Details))]
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
#line 1 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\_ViewImports.cshtml"
using HotelApplication;

#line default
#line hidden
#line 2 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\_ViewImports.cshtml"
using HotelApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0228cc6bcad06781e1b53e7630579069e12157", @"/Areas/Bookings/Views/Suplementary/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1055e2e0f1cd6dcd0e6a748696a98d79d2a46129", @"/Areas/Bookings/Views/_ViewImports.cshtml")]
    public class Areas_Bookings_Views_Suplementary_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelApplication.Models.Suplementary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Suplementary\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
            BeginContext(112, 110, true);
            WriteLiteral("<h4>Suplementary Service Details</h4>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\"> ");
            EndContext();
            BeginContext(223, 40, false);
#line 12 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Suplementary\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(263, 38, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-8\"> ");
            EndContext();
            BeginContext(302, 36, false);
#line 13 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Suplementary\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(338, 38, true);
            WriteLiteral(" </dd>\r\n        <dt class=\"col-sm-4\"> ");
            EndContext();
            BeginContext(377, 41, false);
#line 14 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Suplementary\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(418, 38, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-8\"> ");
            EndContext();
            BeginContext(457, 37, false);
#line 15 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Suplementary\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(494, 27, true);
            WriteLiteral(" </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelApplication.Models.Suplementary> Html { get; private set; }
    }
}
#pragma warning restore 1591