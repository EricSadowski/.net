#pragma checksum "C:\Users\ceteacher\My Drive\Coursework Champlain\Fall 2021\420-N54 Azure for SQL developers\student_download\book_apps\Ch07GuitarShop\GuitarShop\Views\Cart\Add.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b9d50ad09366df9f7ba643d2daeb972fbb9e59541fd82f49d56cd41e47a861e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Add), @"mvc.1.0.view", @"/Views/Cart/Add.cshtml")]
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
#line 2 "C:\Users\ceteacher\My Drive\Coursework Champlain\Fall 2021\420-N54 Azure for SQL developers\student_download\book_apps\Ch07GuitarShop\GuitarShop\Views\_ViewImports.cshtml"
using GuitarShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b9d50ad09366df9f7ba643d2daeb972fbb9e59541fd82f49d56cd41e47a861e1", @"/Views/Cart/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ce568cec07dfc59408f7584b9731f22f4ff176155692ae942bde3f6f67edd61d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ceteacher\My Drive\Coursework Champlain\Fall 2021\420-N54 Azure for SQL developers\student_download\book_apps\Ch07GuitarShop\GuitarShop\Views\Cart\Add.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Your Cart</h1>\r\n\r\n<p>You added ");
#nullable restore
#line 7 "C:\Users\ceteacher\My Drive\Coursework Champlain\Fall 2021\420-N54 Azure for SQL developers\student_download\book_apps\Ch07GuitarShop\GuitarShop\Views\Cart\Add.cshtml"
        Write(ViewBag.ProductSlug);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to your cart.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
