#pragma checksum "C:\Users\Samet\source\repos\proje\proje\Views\Message\MessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46376ae43fd2ead1285db4e1fbbba38827d3f4bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageDetails), @"mvc.1.0.view", @"/Views/Message/MessageDetails.cshtml")]
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
#line 1 "C:\Users\Samet\source\repos\proje\proje\Views\_ViewImports.cshtml"
using proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samet\source\repos\proje\proje\Views\_ViewImports.cshtml"
using proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46376ae43fd2ead1285db4e1fbbba38827d3f4bc", @"/Views/Message/MessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"640a6e2d03eacd97925ac595baf0eba43414fd86", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_MessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Samet\source\repos\proje\proje\Views\Message\MessageDetails.cshtml"
  
    ViewData["Title"] = "MessageDetails";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MessageDetails</h1>\r\n\r\n    ");
#nullable restore
#line 10 "C:\Users\Samet\source\repos\proje\proje\Views\Message\MessageDetails.cshtml"
Write(Html.Label("mesaj ıd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\Samet\source\repos\proje\proje\Views\Message\MessageDetails.cshtml"
Write(Html.TextBoxFor(x=>x.MessageID, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 13 "C:\Users\Samet\source\repos\proje\proje\Views\Message\MessageDetails.cshtml"
Write(Html.Label("mesaj başlığı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\Samet\source\repos\proje\proje\Views\Message\MessageDetails.cshtml"
Write(Html.TextBoxFor(x=>x.Subject, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 16 "C:\Users\Samet\source\repos\proje\proje\Views\Message\MessageDetails.cshtml"
Write(Html.Label("mesaj içeriği"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\Samet\source\repos\proje\proje\Views\Message\MessageDetails.cshtml"
Write(Html.TextAreaFor(x=>x.MessageDetails,10,3, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    \r\n\r\n    <button class=\"btn btn-primary\">mesajlara dön</button>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
