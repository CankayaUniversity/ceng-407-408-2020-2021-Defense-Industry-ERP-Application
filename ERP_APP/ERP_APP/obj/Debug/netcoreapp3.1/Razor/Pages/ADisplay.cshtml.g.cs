#pragma checksum "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e747eb2b80e5f7b2919e44e0ddbaf02f8a566f0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ERP_APP.Pages.Pages_ADisplay), @"mvc.1.0.razor-page", @"/Pages/ADisplay.cshtml")]
namespace ERP_APP.Pages
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
#line 1 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\_ViewImports.cshtml"
using ERP_APP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e747eb2b80e5f7b2919e44e0ddbaf02f8a566f0f", @"/Pages/ADisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2cf96785da3d5c324994398138bfd2db269517", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ADisplay : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "ACreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ADetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
  
    ViewData["Title"] = "ADisplay";
    Layout = "~/Pages/Shared/_LayoutWelcome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
 if (@Model.UserRole == "Admin" || @Model.UserRole == "Muhasebe")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n");
#nullable restore
#line 12 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
     if (@Model.UserRole == "Admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e747eb2b80e5f7b2919e44e0ddbaf02f8a566f0f5606", async() => {
                WriteLiteral("\r\n\r\n            <span class=\"text\">Yeni Yıl Ekle</span>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h3 class=""m-0 font-weight-bold text-primary"">Muhasebe </h3>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>

                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>
                                        <h9> Dönem </h9>
                                    </th>
                                    <th>
                                        <h9> Maaş </h9>
                                    </th>
                                    <th>
                                        <h9> Sigorta Gideri </h9>
                                    </th>
                                    <th>
                                        <h9> ");
            WriteLiteral(@"Diğer Giderler </h9>
                                    </th>
                                    <th>
                                        <h9> Vergi </h9>
                                    </th>
                                    
                                    <th>
                                        <h9> Toplam Fatura(Gelir) </h9>
                                    </th>

                                    <th>

                                        <h9> Açıklama </h9>
                                    </th>
                                    <th>
                                        <h9> Toplam Gider </h9>
                                    </th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 64 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                 foreach (var item in Model.TblAccounting)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 69 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.aylar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 72 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 76 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.sigortalar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 79 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.digergider));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 83 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.vergidurumu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 88 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.gelir));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 92 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        <div>\r\n                                            ");
#nullable restore
#line 97 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                       Write(Model.toplam);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                      \r\n\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e747eb2b80e5f7b2919e44e0ddbaf02f8a566f0f12730", async() => {
                WriteLiteral("\r\n\r\n                                            <span class=\"text\">Düzenle</span>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                                                WriteLiteral(item.AccId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e747eb2b80e5f7b2919e44e0ddbaf02f8a566f0f15228", async() => {
                WriteLiteral("\r\n\r\n                                            <span class=\"text\">Detaylar</span>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                                                   WriteLiteral(item.AccId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 118 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 124 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\ADisplay.cshtml"
    


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERP_APP.Pages.ADisplayModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ERP_APP.Pages.ADisplayModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ERP_APP.Pages.ADisplayModel>)PageContext?.ViewData;
        public ERP_APP.Pages.ADisplayModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
