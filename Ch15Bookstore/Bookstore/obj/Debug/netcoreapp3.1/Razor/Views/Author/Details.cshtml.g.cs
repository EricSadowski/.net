#pragma checksum "C:\Users\ericc\OneDrive\Documents\GitHub\.net\Ch15Bookstore\Bookstore\Views\Author\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00a7a59366d0a6ddce1d5404fa50f8b2261c3c91961db441c7ce28b14a63b609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Details), @"mvc.1.0.view", @"/Views/Author/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ericc\OneDrive\Documents\GitHub\.net\Ch15Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ericc\OneDrive\Documents\GitHub\.net\Ch15Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ericc\OneDrive\Documents\GitHub\.net\Ch15Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"00a7a59366d0a6ddce1d5404fa50f8b2261c3c91961db441c7ce28b14a63b609", @"/Views/Author/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"13fcd8607ccc26df52e2eb85be0f3b75cba22fd9ae68bb460c35a6e0cbbb08e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Author_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Author>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BookLinkPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ericc\OneDrive\Documents\GitHub\.net\Ch15Bookstore\Bookstore\Views\Author\Details.cshtml"
  
    ViewData["Title"] = " | Author";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Author</h1>\r\n\r\n<table class=\"table table-bordered table-sm\">\r\n    <thead>\r\n        <tr class=\"thead-dark\">\r\n            <th>");
#nullable restore
#line 12 "C:\Users\ericc\OneDrive\Documents\GitHub\.net\Ch15Bookstore\Bookstore\Views\Author\Details.cshtml"
           Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n");
#nullable restore
#line 18 "C:\Users\ericc\OneDrive\Documents\GitHub\.net\Ch15Bookstore\Bookstore\Views\Author\Details.cshtml"
                 foreach (var ba in Model.BookAuthors) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00a7a59366d0a6ddce1d5404fa50f8b2261c3c91961db441c7ce28b14a63b6094842", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 19 "C:\Users\ericc\OneDrive\Documents\GitHub\.net\Ch15Bookstore\Bookstore\Views\Author\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = ba.Book;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\ericc\OneDrive\Documents\GitHub\.net\Ch15Bookstore\Bookstore\Views\Author\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Author> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
