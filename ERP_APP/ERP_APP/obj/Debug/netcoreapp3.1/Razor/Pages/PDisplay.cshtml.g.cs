#pragma checksum "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22792caf3bcef9884ee643f349feaa97fda07569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ERP_APP.Pages.Pages_PDisplay), @"mvc.1.0.razor-page", @"/Pages/PDisplay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22792caf3bcef9884ee643f349feaa97fda07569", @"/Pages/PDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac2cf96785da3d5c324994398138bfd2db269517", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PDisplay : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./PEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./PDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./PDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./SCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_LayoutWelcome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
 if (@Model.UserRole == "Admin" || @Model.UserRole == "Üretim")
{
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h3 class=""m-0 font-weight-bold text-primary"">Üretim Planlama</h3>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">


                <thead>
                    <tr>
                        <th>
                            <h9> Ürün ID </h9>
                        </th>

                        <th>
                            <h9> Stok Numarası </h9>
                        </th>
                        <th>
                            <h9> Sipariş Numarası </h9>
                        </th>
                        <th>
                            <h9> İş Emri Numarası </h9>
                        </th>
                        <th>
                            <h9> Ürün Adeti </h9>
                        </th>
                        <th>
                            <h9> Şirket Adı </");
            WriteLiteral(@"h9>
                        </th>
                        <th>
                            <h9> Seri Numarası </h9>
                        </th>
                        <th>
                            <h9> Durumu </h9>
                        </th>
                        <th>
                            <h9> Son İşlem Tarihi </h9>
                        </th>
                        <th>
                            <h9> Üretim Tipi </h9>
                        </th>
                        <th>
                            <h9> Kablaj Tipi </h9>
                        </th>
                        <th>
                            <h9> Bildirimler </h9>
                        </th>
                        <th>
                            <h9> Nerede </h9>
                        </th>

                        <th>
                            <h9> Ara Denetim </h9>
                        </th>
                        <th>
                            <h9> Son denetim </h9>
   ");
            WriteLiteral(@"                     </th>
                        <th>
                            <h9> Test </h9>
                        </th>
                        <th>

                            <h9> Not </h9>

                        </th>

                        
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 84 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                     foreach (var item in Model.TblProduction)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 88 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 92 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product.StokNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 95 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product.OrderNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 98 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product.WorkOrderNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 101 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product.Piece));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 104 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Product.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 108 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SerialNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 111 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 114 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UpdateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 117 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProductionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 120 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.HarnessType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 123 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Notification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 126 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 130 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IsOuality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 133 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IsFinal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 136 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IsTest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 139 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n");
#nullable restore
#line 142 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                         if (@Model.UserRole == "Admin" || @Model.UserRole == "Üretim" || @Model.UserRole == "Test" || @Model.UserRole == "Kalite")
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22792caf3bcef9884ee643f349feaa97fda0756915262", async() => {
                WriteLiteral("\r\n\r\n                                    <span class=\"text\">Düzenle</span>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                                                        WriteLiteral(item.ProductionId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 151 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"

                           
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22792caf3bcef9884ee643f349feaa97fda0756917946", async() => {
                WriteLiteral("\r\n\r\n                                <span class=\"text\">Detaylar</span>\r\n                            ");
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
#line 155 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                                                       WriteLiteral(item.ProductionId);

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
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 160 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                         if (@Model.UserRole == "Admin" || @Model.UserRole == "Üretim" || @Model.UserRole == "Test" || @Model.UserRole == "Kalite")
                        {

                          

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22792caf3bcef9884ee643f349feaa97fda0756920774", async() => {
                WriteLiteral(@"
                                    <span class=""icon text-white-50"">
                                        <i class=""fas fa-trash""></i>
                                    </span>
                                    <span class=""text"">Sil</span>
                                ");
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
#line 165 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                                                          WriteLiteral(item.ProductionId);

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
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 172 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 174 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                         if (@Model.UserRole == "Admin" || @Model.UserRole == "Sevkiyat")
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                             <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22792caf3bcef9884ee643f349feaa97fda0756923920", async() => {
                WriteLiteral(@"
                                    <span class=""icon text-white-50"">
                                        <i class=""fas fa-arrow-right""></i>
                                    </span>
                                    <span class=""text"">Sevk Et</span>

                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 179 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                                                          WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        \r\n                             </td>\r\n");
#nullable restore
#line 189 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 191 "C:\Users\zge\source\repos\ERP_APP\ERP_APP\Pages\PDisplay.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERP_APP.Pages.PDisplayModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ERP_APP.Pages.PDisplayModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ERP_APP.Pages.PDisplayModel>)PageContext?.ViewData;
        public ERP_APP.Pages.PDisplayModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591