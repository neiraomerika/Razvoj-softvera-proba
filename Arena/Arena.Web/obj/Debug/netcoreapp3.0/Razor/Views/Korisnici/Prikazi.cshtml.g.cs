#pragma checksum "C:\Users\NeiraOmerika\Desktop\Seminarski rad\WebApp\Arena\Arena.Web\Views\Korisnici\Prikazi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c69eb7ea601064a5692c2c0a626724327b6af6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Korisnici_Prikazi), @"mvc.1.0.view", @"/Views/Korisnici/Prikazi.cshtml")]
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
#line 1 "C:\Users\NeiraOmerika\Desktop\Seminarski rad\WebApp\Arena\Arena.Web\Views\_ViewImports.cshtml"
using Arena.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NeiraOmerika\Desktop\Seminarski rad\WebApp\Arena\Arena.Web\Views\_ViewImports.cshtml"
using Arena.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c69eb7ea601064a5692c2c0a626724327b6af6", @"/Views/Korisnici/Prikazi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baccb9daae4d8302ddbc635f39e2bfb82eb8de1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Korisnici_Prikazi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\NeiraOmerika\Desktop\Seminarski rad\WebApp\Arena\Arena.Web\Views\Korisnici\Prikazi.cshtml"
  
    ViewData["Title"] = "Prikazi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <section id=""main-content"">
        <section class=""wrapper"">
            <section class=""panel"">
                <header class=""panel-heading"">
                    <h2>Nalozi</h2>
                </header>

                <button id=""admin"" class=""btn"">Administratori</button>
                <button id=""uposlenici"" class=""btn"">Uposlenici</button>
                <button id=""klijenti"" class=""btn"">Klijenti</button>

                <br />
                <br />
");
            WriteLiteral(@"                <div id=""ajaxPoziv""><h2>Odaberite tip korisnika za pregled</h2> </div>
            </section>
        </section>
    </section>

<script>
    $(""#admin"").click(function myfunction() {
        $.get(""/AjaxKorisnici/Administratori"", function (rezultat, status) {
            $(""#ajaxPoziv"").html(rezultat);
        })

    });

    $(""#klijenti"").click(function myfunction() {
        $.get(""/AjaxKorisnici/Klijenti"", function (rezultat, status) {
            $(""#ajaxPoziv"").html(rezultat);
        })

    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
