#pragma checksum "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca8291a1ddfc68070714e4124a5859e9dcedb85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Projet_AdoNet.Pages.Operations.Pages_Operations_TopDixCommerciaux), @"mvc.1.0.razor-page", @"/Pages/Operations/TopDixCommerciaux.cshtml")]
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
#line 3 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca8291a1ddfc68070714e4124a5859e9dcedb85", @"/Pages/Operations/TopDixCommerciaux.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3714ca17c57ffa4b3b747368a1e88d84a171d96c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Operations_TopDixCommerciaux : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Redirect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListeProjetParCommercial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chart.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/TopDixCommerciaux.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
  
    ViewData["Title"] = "Les top 6 des commerciaux";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
 if (HttpContext.Session.GetString("login") == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca8291a1ddfc68070714e4124a5859e9dcedb855416", async() => {
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
#line 13 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 19 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
</div>

<br />
<hr />
<br />

<div class=""row"">
    <div class=""col-sm"">
        <p>Ci-dessous la liste des Top 6 des commerciaux :</p>
        <br />
        <table class=""table table-striped table caption-top"" id=""myTable"">
            <thead>
                <tr>
                    <th scope=""col"">Ref. Comm</th>
                    <th scope=""col"">Nom</th>
                    <th scope=""col"">Prenom</th>
                    <th scope=""col"">Nombre de projet</th>
                    <th scope=""col"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 41 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                   int i = 0; int j = 0; int k = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                 foreach (var item in Model.ClientP)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 45 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                                   Write(Html.DisplayFor(Model => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th scope=\"row\">");
#nullable restore
#line 46 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                                   Write(Html.DisplayFor(Model => item.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 47 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                       Write(Html.DisplayFor(Model => item.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                       Write(Html.DisplayFor(Model => item.NombreProjet));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca8291a1ddfc68070714e4124a5859e9dcedb859476", async() => {
                WriteLiteral("Afficher les projets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 51 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                    i++;
                    if (i == 6) { break; }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""col-sm"">
        <p>Le diagramme du résultat :</p>
        <br />
        <canvas id=""myChart"" width=""200"" height=""200""></canvas>
    </div>
</div>

<table id=""nomPrenom"" style=""visibility:collapse;"">

");
#nullable restore
#line 66 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
     foreach (var item in Model.ClientP)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 69 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
           Write(Html.DisplayFor(Model => item.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 69 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
                                               Write(Html.DisplayFor(Model => item.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 71 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
        j++;
        if (j == 6) { break; }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<table id=\"nombreProjet\" style=\"visibility:collapse;\">\r\n");
#nullable restore
#line 76 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
     foreach (var item in Model.ClientP)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 79 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
           Write(Html.DisplayFor(Model => item.NombreProjet));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Operations\TopDixCommerciaux.cshtml"
        k++;
        if (k == 6) { break; }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<!--injection du script-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca8291a1ddfc68070714e4124a5859e9dcedb8514378", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!--script pour le chart-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca8291a1ddfc68070714e4124a5859e9dcedb8515453", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet_AdoNet.Pages.Operations.TopDixCommerciauxModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projet_AdoNet.Pages.Operations.TopDixCommerciauxModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Projet_AdoNet.Pages.Operations.TopDixCommerciauxModel>)PageContext?.ViewData;
        public Projet_AdoNet.Pages.Operations.TopDixCommerciauxModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
