#pragma checksum "/Users/hannahgrinton/Development/CTP/Views/Home/ViewEbook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00eecabb8732cd173e3f732007bcecde38326d6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewEbook), @"mvc.1.0.view", @"/Views/Home/ViewEbook.cshtml")]
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
#line 1 "/Users/hannahgrinton/Development/CTP/Views/_ViewImports.cshtml"
using CTP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hannahgrinton/Development/CTP/Views/_ViewImports.cshtml"
using CTP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00eecabb8732cd173e3f732007bcecde38326d6b", @"/Views/Home/ViewEbook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e800b779530de59ec1cfc066895dc9f164d02e87", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewEbook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CTP.Models.Ebook>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("listing__images__img listing__images__img--front"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<a class=""main__arrow"" onclick=""history.go(-1)"" style=""cursor: pointer;""><i class=""fas fa-arrow-left"" style=""font-size: 34px; float: left;""></i></a><div class=""main__title main__title--listing"">View eBook</div>
<div class=""page-content"">
    <div class=""listing"">
        <div class=""listing__images"" style=""margin-bottom: 40px;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "00eecabb8732cd173e3f732007bcecde38326d6b3742", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 378, "~/images/covers/ebooks/", 378, 23, true);
#nullable restore
#line 7 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewEbook.cshtml"
AddHtmlAttributeValue("", 401, Model.imgFile, 401, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \n        </div>\n        <div class=\"listing__content\">\n            <div class=\"listing__content__title\">");
#nullable restore
#line 10 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewEbook.cshtml"
                                            Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <div class=\"listing__content__author\" style=\"margin-bottom: 20px;\">");
#nullable restore
#line 11 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewEbook.cshtml"
                                                                          Write(Model.author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <a class=\"listing__content__button\"");
            BeginWriteAttribute("href", " href=\"", 745, "\"", 765, 1);
#nullable restore
#line 12 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewEbook.cshtml"
WriteAttributeValue("", 752, Model.amazon, 752, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Order on Amazon</a>\n            <div class=\"listing__content__info\">\n                All contributions from Kindle orders on Amazon are donated to our Brother in Christ, Bruce Anstey.\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CTP.Models.Ebook> Html { get; private set; }
    }
}
#pragma warning restore 1591
