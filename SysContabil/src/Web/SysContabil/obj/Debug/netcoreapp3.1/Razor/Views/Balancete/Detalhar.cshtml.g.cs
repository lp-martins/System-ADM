#pragma checksum "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d8e9d8d23c39a7a794bfc3104f7bd2e945e6d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Balancete_Detalhar), @"mvc.1.0.view", @"/Views/Balancete/Detalhar.cshtml")]
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
#line 1 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\_ViewImports.cshtml"
using SysContabil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\_ViewImports.cshtml"
using SysContabil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5d8e9d8d23c39a7a794bfc3104f7bd2e945e6d9", @"/Views/Balancete/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9433e5a7a3137eb8e6fad2d471b593785c83e9a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Balancete_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SysContabil.Models.LancamentoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
  
    ViewData["Title"] = "Detalhar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Detalhes do Lançamento</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDoPlano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.DataDoPlano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.Debito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.Debito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.Credito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.Credito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.ReciboFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.ReciboFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 45 "C:\Users\MARTINS\Desktop\System-ADM\SysContabil\src\Web\SysContabil\Views\Balancete\Detalhar.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5d8e9d8d23c39a7a794bfc3104f7bd2e945e6d97911", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SysContabil.Models.LancamentoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591