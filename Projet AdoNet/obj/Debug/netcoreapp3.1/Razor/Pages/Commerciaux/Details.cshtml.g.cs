#pragma checksum "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d240a10681929c1f13f0440b0f10343dd267cecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Projet_AdoNet.Pages.Commerciaux.Pages_Commerciaux_Details), @"mvc.1.0.razor-page", @"/Pages/Commerciaux/Details.cshtml")]
namespace Projet_AdoNet.Pages.Commerciaux
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
#line 1 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\_ViewImports.cshtml"
using Projet_AdoNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d240a10681929c1f13f0440b0f10343dd267cecd", @"/Pages/Commerciaux/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3714ca17c57ffa4b3b747368a1e88d84a171d96c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Commerciaux_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Redirect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
  
    ViewData["Title"] = "Details du Commercial";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
 if (HttpContext.Session.GetString("login") == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d240a10681929c1f13f0440b0f10343dd267cecd4197", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 19 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<br />\r\n<br />\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Commercial.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
       Write(Html.DisplayFor(model => model.Commercial.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Commercial.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
       Write(Html.DisplayFor(model => model.Commercial.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <!--\r\n    <a asp-page=\"./Edit\" asp-route-id=\"");
#nullable restore
#line 44 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
                                  Write(Model.Commercial.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Modifier</a> |\r\n    <a asp-page=\"./Index\">Revenir à la liste</a>\r\n    -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet_AdoNet.Pages.Commerciaux.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projet_AdoNet.Pages.Commerciaux.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projet_AdoNet.Pages.Commerciaux.DetailsModel>)PageContext?.ViewData;
        public Projet_AdoNet.Pages.Commerciaux.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
