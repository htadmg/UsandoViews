#pragma checksum "c:\Users\agata\source\repos\UsandoViews\Views\Shared\_MensagemInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "494ed2d37c7728f326cf743b6e4ce5fcecd4a56a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UsandoViews.Models.Shared.Views_Shared__MensagemInfo), @"mvc.1.0.view", @"/Views/Shared/_MensagemInfo.cshtml")]
namespace UsandoViews.Models.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494ed2d37c7728f326cf743b6e4ce5fcecd4a56a", @"/Views/Shared/_MensagemInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9019c0e3aabe485b3093a46895f4929f63174dfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MensagemInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("   <div class=\"alert alert-success mt-3 alert-dismissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 3 "c:\Users\agata\source\repos\UsandoViews\Views\Shared\_MensagemInfo.cshtml"
       Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\"></button>\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; }
    }
}
#pragma warning restore 1591
