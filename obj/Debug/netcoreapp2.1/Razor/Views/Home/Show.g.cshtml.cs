#pragma checksum "/Users/ricardorivera/cSharp/MVC/dojosurv/Views/Home/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64280a952db51667478f77341d12c183d0942459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(AspNetCore.Views_Home_Show))]
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
#line 1 "/Users/ricardorivera/cSharp/MVC/dojosurv/Views/_ViewImports.cshtml"
using dojosurv;

#line default
#line hidden
#line 6 "/Users/ricardorivera/cSharp/MVC/dojosurv/Views/Home/Show.cshtml"
using dojosurv.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64280a952db51667478f77341d12c183d0942459", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8106007b0e6e413c9cfc7b97de935bff1bb7e14b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 139, true);
            WriteLiteral("<div class=\"container-fluid\">\n    <div class=\"container\">\n        <h1 class=\"display-4\">Your Results</h1>\n        <h3>Info Submitted:</h3>\n");
            EndContext();
            BeginContext(212, 21, true);
            WriteLiteral("            <p>Name: ");
            EndContext();
            BeginContext(234, 10, false);
#line 8 "/Users/ricardorivera/cSharp/MVC/dojosurv/Views/Home/Show.cshtml"
                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(244, 27, true);
            WriteLiteral("</p>\n            <p>Email: ");
            EndContext();
            BeginContext(272, 11, false);
#line 9 "/Users/ricardorivera/cSharp/MVC/dojosurv/Views/Home/Show.cshtml"
                 Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(283, 30, true);
            WriteLiteral("</p>\n            <p>Location: ");
            EndContext();
            BeginContext(314, 14, false);
#line 10 "/Users/ricardorivera/cSharp/MVC/dojosurv/Views/Home/Show.cshtml"
                    Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(328, 39, true);
            WriteLiteral("</p>\n            <p>Favorite Language: ");
            EndContext();
            BeginContext(368, 14, false);
#line 11 "/Users/ricardorivera/cSharp/MVC/dojosurv/Views/Home/Show.cshtml"
                             Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(382, 30, true);
            WriteLiteral("</p>\n            <p>Comments: ");
            EndContext();
            BeginContext(413, 13, false);
#line 12 "/Users/ricardorivera/cSharp/MVC/dojosurv/Views/Home/Show.cshtml"
                    Write(Model.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(426, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
            BeginContext(441, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
