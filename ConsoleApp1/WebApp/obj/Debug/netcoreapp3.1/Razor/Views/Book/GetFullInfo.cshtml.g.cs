#pragma checksum "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e6e2df84446792fb97a597fb78679e6d2d66a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetFullInfo), @"mvc.1.0.view", @"/Views/Book/GetFullInfo.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
using Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e6e2df84446792fb97a597fb78679e6d2d66a91", @"/Views/Book/GetFullInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetFullInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div>\r\n    <p>Id: ");
#nullable restore
#line 8 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
      Write(Html.DisplayFor(Model => Model.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Жанр:  ");
#nullable restore
#line 9 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
         Write(Html.DisplayFor(Model => Model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Страна:  ");
#nullable restore
#line 10 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
           Write(Html.DisplayFor(Model => Model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Авторы: \r\n");
#nullable restore
#line 12 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
             foreach (var item in Model.Writers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>item.FirstName</p>\r\n");
#nullable restore
#line 15 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n    <p>Год издания:  ");
#nullable restore
#line 17 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
                Write(Html.DisplayFor(Model => Model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e6e2df84446792fb97a597fb78679e6d2d66a916862", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 25 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
Write(Html.HiddenFor(@model => model.BookId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 28 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
   Write(Html.EditorFor(@model => @model.Genre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 34 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
   Write(Html.EditorFor(@model => @model.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 35 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
   Write(Html.ValidationMessageFor(@model => @model.Rating));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 41 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
   Write(Html.LabelFor(Model => Model.Genre, new { @class = "col-2 col-form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 42 "C:\Users\HP\Desktop\Alina\ConsoleApp1_1\ConsoleApp1\WebApp\Views\Book\GetFullInfo.cshtml"
   Write(Html.DropDownListFor(Model => Model.Genre, Model.SelectList = Model.Genre.GetSelectList()));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>

                    <div class=""form-group"">
                        <p>Удален?</p>
                        <div id=""dismissal"">

                        </div>
                    </div>

                    <input type=""submit"" class=""btn btn-success"" />


            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"
        <script>
            function onSuccess(data) {
                alert(data.newData.success);
                if (data.isDeleted == false) {
                    $(""#dismissal"").html(data.deletedTextMessage.no)
                }
                else {
                    $(""#dismissal"").html(data.deletedTextMessage.yes);
                }
            }
        </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591