#pragma checksum "D:\C#\TMS_Project\TMS_Project\ConsoleApp1\WebApp\Views\Writer\AuthorsMenuPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7560d8d73af17965406b2ad1ee14431f9bb35f21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_AuthorsMenuPage), @"mvc.1.0.view", @"/Views/Writer/AuthorsMenuPage.cshtml")]
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
#line 1 "D:\C#\TMS_Project\TMS_Project\ConsoleApp1\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\TMS_Project\TMS_Project\ConsoleApp1\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C#\TMS_Project\TMS_Project\ConsoleApp1\WebApp\Views\Writer\AuthorsMenuPage.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7560d8d73af17965406b2ad1ee14431f9bb35f21", @"/Views/Writer/AuthorsMenuPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_AuthorsMenuPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WriterInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"get-all\" id=\"getall-writers\">\r\n    ");
#nullable restore
#line 7 "D:\C#\TMS_Project\TMS_Project\ConsoleApp1\WebApp\Views\Writer\AuthorsMenuPage.cshtml"
Write(Html.ActionLink("Authors", "GetAll", "Writer", new { type = "button", @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"create\" id=\"create-writer\">\r\n    ");
#nullable restore
#line 11 "D:\C#\TMS_Project\TMS_Project\ConsoleApp1\WebApp\Views\Writer\AuthorsMenuPage.cshtml"
Write(Html.ActionLink("Add author", "Create", "Writer", new { type = "button", @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WriterInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
