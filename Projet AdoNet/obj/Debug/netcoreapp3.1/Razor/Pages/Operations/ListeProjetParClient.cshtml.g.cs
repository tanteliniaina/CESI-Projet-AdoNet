#pragma checksum "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e790021deaa47339577adbcb6e14febdeeb5b05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Projet_AdoNet.Pages.Operations.Pages_Operations_ListeProjetParClient), @"mvc.1.0.razor-page", @"/Pages/Operations/ListeProjetParClient.cshtml")]
namespace Projet_AdoNet.Pages.Operations
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
#line 3 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e790021deaa47339577adbcb6e14febdeeb5b05", @"/Pages/Operations/ListeProjetParClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3714ca17c57ffa4b3b747368a1e88d84a171d96c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Operations_ListeProjetParClient : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#nullable restore
#line 4 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
  
    ViewData["Title"] = "Le projet du client ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
 if (HttpContext.Session.GetString("login") == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e790021deaa47339577adbcb6e14febdeeb5b054259", async() => {
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
#line 13 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 21 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
</div>

<br />
<hr />
<br />

<h4>Ci-dessous la liste des projets relatives au client :</h4>
<br />

<table class=""table table-striped table caption-top"">
    <thead>
        <tr>
            <th scope=""col"">Ref. Projet</th>
            <th scope=""col"">Nom</th>
            <th scope=""col"">Date de Création</th>
            <th scope=""col"">Date de Finalisation</th>
            <th scope=""col"">Ville</th>
            <th scope=""col"">Statut</th>
            <th scope=""col"">Id Client</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 45 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
         foreach (var item in Model.Projet)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 48 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
                           Write(Html.DisplayFor(Model => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 49 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
               Write(Html.DisplayFor(Model => item.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
               Write(Html.DisplayFor(Model => item.DateCreation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
               Write(Html.DisplayFor(Model => item.DateFinalisation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
               Write(Html.DisplayFor(Model => item.Ville));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
               Write(Html.DisplayFor(Model => item.IdStatut));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
               Write(Html.DisplayFor(Model => item.IdClient));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\ListeProjetParClient.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet_AdoNet.Pages.Operations.ListeProjetParClientModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projet_AdoNet.Pages.Operations.ListeProjetParClientModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projet_AdoNet.Pages.Operations.ListeProjetParClientModel>)PageContext?.ViewData;
        public Projet_AdoNet.Pages.Operations.ListeProjetParClientModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
