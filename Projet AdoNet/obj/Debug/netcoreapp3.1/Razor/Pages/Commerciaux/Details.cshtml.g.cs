#pragma checksum "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "275c416e9f46aef60b8316340436402c4c4c34aa"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"275c416e9f46aef60b8316340436402c4c4c34aa", @"/Pages/Commerciaux/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3714ca17c57ffa4b3b747368a1e88d84a171d96c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Commerciaux_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
  
    ViewData["Title"] = "Details du Commercial";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 11 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<br />\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Commercial.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
       Write(Html.DisplayFor(model => model.Commercial.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Commercial.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
       Write(Html.DisplayFor(model => model.Commercial.Prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <!--\r\n    <a asp-page=\"./Edit\" asp-route-id=\"");
#nullable restore
#line 35 "D:\Projet AdoNet\CESI-Projet-AdoNet\Projet AdoNet\Pages\Commerciaux\Details.cshtml"
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
