#pragma checksum "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Complementary\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d69331513216b9cd7a8cb204660a28f3913303b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Bookings_Views_Complementary_Details), @"mvc.1.0.view", @"/Areas/Bookings/Views/Complementary/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Bookings/Views/Complementary/Details.cshtml", typeof(AspNetCore.Areas_Bookings_Views_Complementary_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69331513216b9cd7a8cb204660a28f3913303b2", @"/Areas/Bookings/Views/Complementary/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1055e2e0f1cd6dcd0e6a748696a98d79d2a46129", @"/Areas/Bookings/Views/_ViewImports.cshtml")]
    public class Areas_Bookings_Views_Complementary_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelApplication.Models.Complementary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Complementary\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
            BeginContext(113, 111, true);
            WriteLiteral("<h4>Complementary Service Details</h4>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-4\"> ");
            EndContext();
            BeginContext(225, 40, false);
#line 12 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Complementary\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(265, 38, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-8\"> ");
            EndContext();
            BeginContext(304, 36, false);
#line 13 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Complementary\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(340, 38, true);
            WriteLiteral(" </dd>\r\n        <dt class=\"col-sm-4\"> ");
            EndContext();
            BeginContext(379, 41, false);
#line 14 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Complementary\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(420, 38, true);
            WriteLiteral(" </dt>\r\n        <dd class=\"col-sm-8\"> ");
            EndContext();
            BeginContext(459, 37, false);
#line 15 "C:\Users\nahid\OneDrive\Desktop\hotel\Areas\Bookings\Views\Complementary\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(496, 27, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelApplication.Models.Complementary> Html { get; private set; }
    }
}
#pragma warning restore 1591
