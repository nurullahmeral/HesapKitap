#pragma checksum "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7277c2113528f07e7ab300d1f713c3a0ab7f6a1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Transferekle), @"mvc.1.0.view", @"/Views/Home/Transferekle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7277c2113528f07e7ab300d1f713c3a0ab7f6a1b", @"/Views/Home/Transferekle.cshtml")]
    public class Views_Home_Transferekle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModels>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7277c2113528f07e7ab300d1f713c3a0ab7f6a1b2756", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"" integrity=""sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI"" crossorigin=""anonymous""></script>
    <style>
        .row{
            padding-top: 20px;
            ");
                WriteLiteral("\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7277c2113528f07e7ab300d1f713c3a0ab7f6a1b4843", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 20 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3"">
                 <div class=""list-group"">
                    <form action=""/home/transferkalemiekle"" method=""POST"">
                        <div class=""form-group"">
                            <label");
                BeginWriteAttribute("for", " for=\"", 1468, "\"", 1474, 0);
                EndWriteAttribute();
                WriteLiteral(@"><Strong>Transfer Kalemi Ekle</Strong></label>
                            <input type=""text"" id=""Adı"" name=""Adı"">
                            <button type=""submit"" class=""btn btn-primary btn-sm"">Kaydet</button>
                        </div>
                    
                    </form> 

                </div>
            </div>
            <div class=""col-md-6"">
                <form method=""POST"">
                    <div class=""form-group"">
                        <label for=""Tarih""><strong>Tarih</strong> </label>
                        <input type=""date"" id=""TransferTarihi"" name=""TransferTarihi"" class=""form-control"">
                    </div>
                    <div class=""form-group"" style=""display: inline;"">
                        <label for=""inputGroupSelect01""><strong>Nereden?</strong></label>
                        <select class=""form-control"" id=""TransferNereden"" name=""TransferNereden"">
                            <option selected>Seçiniz...</option>
                    ");
                WriteLiteral("        \r\n");
#nullable restore
#line 47 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                             if(Model.TransferKalemis.Count>0){
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                                 foreach (var transferKalemi in Model.TransferKalemis){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <option");
                BeginWriteAttribute("value", " value=\"", 2706, "\"", 2732, 1);
#nullable restore
#line 49 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
WriteAttributeValue("", 2714, transferKalemi.Id, 2714, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 49 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                                                                  Write(transferKalemi.Adı);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 50 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                                    

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                                 
                            }else{

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            
                        </select>
                    </div>
                     <div class=""form-group"" style=""display: inline;"">
                        <label for=""inputGroupSelect01""><strong>Nereye?</strong></label>
                        <select class=""form-control"" id=""TransferNereye"" name=""TransferNereye"">
                            <option selected>Seçiniz...</option>
                            
");
#nullable restore
#line 64 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                             if(Model.TransferKalemis.Count>0){
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                                 foreach (var transferKalemi in Model.TransferKalemis){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <option");
                BeginWriteAttribute("value", " value=\"", 3553, "\"", 3579, 1);
#nullable restore
#line 66 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
WriteAttributeValue("", 3561, transferKalemi.Id, 3561, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                                                                  Write(transferKalemi.Adı);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 67 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                                    

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\w10\Desktop\HesapKitapAnaDizin\HesapKitap\Views\Home\Transferekle.cshtml"
                                 
                            }else{

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            
                        </select>
                    </div>
                    
                    <div class=""form-group"">
                        <label for=""Tutar""><strong>Tutar</strong></label>
                        <input type=""number"" id=""TransferTutari"" name=""TransferTutari"" class=""form-control"">
                    </div>
                    <div class=""form-group"">
                        <label for=""Aciklama""><strong>Açıklama</strong></label>
                        <input type=""text"" id=""TransferAciklama"" name=""TransferAciklama"" class=""form-control"">
                    </div>
                   
                    
                    <button type=""submit""  class=""btn btn-primary"">Kaydet</button>

                   
                </form>
            </div>
            <div class=""col-md-3""></div>

        </div>
         

    </div>
    
");
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
            WriteLiteral("\r\n</html>\r\n");
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