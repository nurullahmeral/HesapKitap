#pragma checksum "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57402ce0230cf4c4299bfc7c032eb7509fc3a925"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Giderlerigor), @"mvc.1.0.view", @"/Views/Home/Giderlerigor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57402ce0230cf4c4299bfc7c032eb7509fc3a925", @"/Views/Home/Giderlerigor.cshtml")]
    public class Views_Home_Giderlerigor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModels>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
  
    var gunsonux = Model.GunSonu;
    var giderlerigor = Model.GiderEkles;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57402ce0230cf4c4299bfc7c032eb7509fc3a9252999", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Gün Sonu Raporları</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"" integrity=""sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI"" crossorigin=""anonymous""></script>
    <style>
        .row{
            padding-top: 20px;
  ");
                WriteLiteral("      }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57402ce0230cf4c4299bfc7c032eb7509fc3a9255080", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <header>

    </header>
    <main>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <label for=""Vade Tarihi""><strong>Tarih </strong> </label>
                        <input type=""date"" id=""VadeTarihi"" name=""VadeTarihi"" class=""form-controlx""");
                BeginWriteAttribute("value", " value=\"", 1627, "\"", 1635, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                    Kategorilize şeyler burada yer alacak
                </div>
                <div class=""col-md-9"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                
                                <td><strong>Ürün adı</strong></td>
                                <td><strong>Kategori</strong></td>
                                <td><strong>Dönem</strong></td>
                                <td><strong>Tutar</strong></td>
                                <td style=""width: 100px;"" ><strong>Ödeme yapıldı mı?</strong></td>
                                <td><strong>Ödeme türü</strong></td>
                                <td><strong>Vade tarihi</strong></td> 
                                <td style=""width: 150px;""></td>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 53 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                             if(giderlerigor.Count>0){
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                 foreach (var gider in giderlerigor){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        \r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                       Write(gider.UrunAdı);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                       Write(gider.UrunKategorisi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 59 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                       Write(gider.AitOlduguDonem);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                       Write(gider.Tutar);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 61 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                       Write(gider.OdemeKontrol);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 62 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                       Write(gider.OdemeTuru);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 63 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                       Write(gider.VadeTarihi);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                        
                                        <td>
                                            <a href=""#"" class=""btn btn-primary btn-sm mr-2"">Düzenle</a>
                                            <a href=""#"" class=""btn btn-danger btn-sm mr-2"">Sil</a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 70 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"
                                 

                            }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"alert alert-warning\">\r\n                                    <h3>Rapor yok</h3>\r\n                                </div>\r\n");
#nullable restore
#line 76 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Giderlerigor.cshtml"


                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            \r\n\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            \r\n");
                WriteLiteral("        </div>\r\n\r\n    </main>\r\n\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591