#pragma checksum "/Users/hannahgrinton/Development/CTP/Views/Home/ViewBooklet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad74354475197640cd26416069bea1ba27155969"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewBooklet), @"mvc.1.0.view", @"/Views/Home/ViewBooklet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad74354475197640cd26416069bea1ba27155969", @"/Views/Home/ViewBooklet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e800b779530de59ec1cfc066895dc9f164d02e87", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewBooklet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CTP.Models.Booklet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("listing__images__img listing__images__img--front"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("listing__images__img listing__images__img--back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<a class=""main__arrow"" onclick=""history.go(-1)"" style=""cursor: pointer;""><i class=""fas fa-arrow-left"" style=""font-size: 34px; float: left;""></i></a><div class=""main__title main__title--listing"">View Booklet</div>
<div class=""page-content"">
    <div class=""listing"">
        <div class=""listing__images"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ad74354475197640cd26416069bea1ba271559694111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 353, "~/images/covers/booklets/", 353, 25, true);
#nullable restore
#line 7 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewBooklet.cshtml"
AddHtmlAttributeValue("", 378, Model.frontcover, 378, 17, false);

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
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ad74354475197640cd26416069bea1ba271559695665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 477, "~/images/covers/booklets/", 477, 25, true);
#nullable restore
#line 8 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewBooklet.cshtml"
AddHtmlAttributeValue("", 502, Model.backcover, 502, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""listing__images__buttons"">
                <i class=""fas fa-caret-square-left disabled"" id=""btnLeft""></i><i class=""fas fa-caret-square-right"" id=""btnRight""></i>
            </div>     
        </div>
        <div class=""listing__content"">
            <div class=""listing__content__title"">");
#nullable restore
#line 14 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewBooklet.cshtml"
                                            Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <div class=\"listing__content__author\">");
#nullable restore
#line 15 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewBooklet.cshtml"
                                             Write(Model.author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <div class=\"listing__content__price\">$");
#nullable restore
#line 16 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewBooklet.cshtml"
                                             Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD</div>\n            <div class=\"listing__content__code\">Item Code: ");
#nullable restore
#line 17 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewBooklet.cshtml"
                                                      Write(Model.code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            \n            <a class=\"listing__content__button\"");
            BeginWriteAttribute("href", " href=\"", 1188, "\"", 1296, 2);
            WriteAttributeValue("", 1195, "mailto:christiantruthpublishing@gmail.com?cc=rjboulard@gmail.com&subject=CTP%20Order:%20", 1195, 88, true);
#nullable restore
#line 19 "/Users/hannahgrinton/Development/CTP/Views/Home/ViewBooklet.cshtml"
WriteAttributeValue("", 1283, Model.code, 1283, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">Email to Order</a>
            <div class=""listing__content__info"">
                Standard book and booklet size is 5-3/16"" wide (130mm) x 7-1/2"" high (190mm). <br>
                Study Version book size is approximately 6-5/16"" wide (150mm) x 8-1/4"" high (200mm).
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CTP.Models.Booklet> Html { get; private set; }
    }
}
#pragma warning restore 1591
