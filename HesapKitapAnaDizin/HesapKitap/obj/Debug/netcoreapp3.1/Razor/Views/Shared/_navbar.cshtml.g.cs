#pragma checksum "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f39f536e6c1dabf90eac1cc392c90c385ef660c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f39f536e6c1dabf90eac1cc392c90c385ef660c2", @"/Views/Shared/_navbar.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""navbar bg-danger navbar-dark navbar-expand-sm"">
    <div class=""container"">
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a href=""/home/gunsonu"" class=""nav-link"">Gün Sonu</a>
            </li>
            <li class=""nav-item"">
                <a href=""/home/giderekle"" class=""nav-link"">Giderler</a>
            </li>
            <li class=""nav-item"">
                <a href=""/home/transferekle"" class=""nav-link"">Transferler</a>
            </li>
            <li class=""nav-item"">
                <a href=""/home/nakitakisi"" class=""nav-link"">Nakit Akışı</a>
            </li>
            <!-- Example single danger button -->
            <div class=""btn-group"">
                <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    Raporlar
                </button>
                <div class=""dropdown-menu"">
                    <a class=""dropdown-item"" hre");
            WriteLiteral("f=\"/home/gunsonurapor\">Gün Sonları</a>\r\n                    <a class=\"dropdown-item\" href=\"/home/transferlerigor\">Transferler</a>\r\n                    <a class=\"dropdown-item\" href=\"/home/giderlerigor\">Giderler</a>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n           \r\n            <li class=\"nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1651, "\"", 1658, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">Ayarlar</a>\r\n            </li>\r\n                <button type=\"button\" class=\"btn btn-primary\">\r\n                 Bildirimler <span class=\"badge badge-light\">4</span>\r\n                </button>\r\n\r\n\r\n        </ul>\r\n        <form");
            BeginWriteAttribute("action", " action=\"", 1903, "\"", 1912, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <select class=""form-control"" style=""width: min-content;"" id=""OdemeTuru"" name=""OdemeTuru"">
                <option selected>Seçiniz...</option>
                <option value=""asubesi"">A Şubesi</option>
                <option value=""bsubesi"">B Şubesi</option>
                <option value=""csubesi"">C Şubesi</option>
                <option value=""dsubesi"">D Şubesi</option>
           
            
            </select>

        </form>
        
        
");
            WriteLiteral("    </div>\r\n    <script>\r\n\r\n    </script>\r\n\r\n</div>");
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
