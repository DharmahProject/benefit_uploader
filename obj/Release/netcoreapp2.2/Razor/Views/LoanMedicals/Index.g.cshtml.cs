#pragma checksum "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5df31ed2bfe3c135cc3af99418dfa6ae6874938"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoanMedicals_Index), @"mvc.1.0.view", @"/Views/LoanMedicals/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoanMedicals/Index.cshtml", typeof(AspNetCore.Views_LoanMedicals_Index))]
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
#line 1 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\_ViewImports.cshtml"
using BenefitUploader;

#line default
#line hidden
#line 2 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\_ViewImports.cshtml"
using BenefitUploader.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5df31ed2bfe3c135cc3af99418dfa6ae6874938", @"/Views/LoanMedicals/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efc99dbed31dd8b4c5346fc377387804105c941", @"/Views/_ViewImports.cshtml")]
    public class Views_LoanMedicals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BenefitUploader.Models.LoanMedical>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Export to excel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "ExportMedical", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
  
    ViewData["Title"] = "Loan Medical List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(158, 253, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <div class=\"col-sm-10\">\r\n            <label style=\"font-size:30px\">Uploaded List</label>\r\n        </div>\r\n        <div class=\"col-sm-2\" style=\"padding-top:15px\">\r\n\r\n            ");
            EndContext();
            BeginContext(411, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5df31ed2bfe3c135cc3af99418dfa6ae68749384846", async() => {
                BeginContext(487, 15, true);
                WriteLiteral("Export to excel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(506, 968, true);
            WriteLiteral(@"
        </div>
    </div>

</div>
<table></table>
<style>
    .myClass label {
        font-weight: bold;
    }

    .responsive-table thead > tr {
        background: linear-gradient(to right, rgb(10, 207, 254) 0%, rgb(73, 90, 255) 100%) !important;
        color: white !important;
    }
</style>

<div class=""main-body"">
    <div class=""page-wrapper"">
        <!-- [ Main Content ] start -->
        <div class=""row"">
            <!-- [ sample-page ] start -->
            <div class=""col-sm-12"">
                <div class=""card"">

                    <div class=""card-block"">
                        <div class=""table-responsive"">
                            <table id=""responsive-table-custom"" class=""responsive-table display table nowrap"" style=""width:100%"">
                                <thead>
                                    <tr>
                                        <th>
                                            ");
            EndContext();
            BeginContext(1475, 46, false);
#line 48 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(1661, 42, false);
#line 51 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Pasien));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(1843, 50, false);
#line 54 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.TglAwalBerobat));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2033, 51, false);
#line 57 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.TglAkhirBerobat));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2224, 49, false);
#line 60 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.TempatBerobat));

#line default
#line hidden
            EndContext();
            BeginContext(2273, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2413, 46, false);
#line 63 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.JenisKlaim));

#line default
#line hidden
            EndContext();
            BeginContext(2459, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2599, 41, false);
#line 66 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Biaya));

#line default
#line hidden
            EndContext();
            BeginContext(2640, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2780, 44, false);
#line 69 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Angsuran));

#line default
#line hidden
            EndContext();
            BeginContext(2824, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2964, 51, false);
#line 72 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.NominalPotongan));

#line default
#line hidden
            EndContext();
            BeginContext(3015, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(3155, 53, false);
#line 75 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.PeriodePemotongan));

#line default
#line hidden
            EndContext();
            BeginContext(3208, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(3348, 46, false);
#line 78 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Keterangan));

#line default
#line hidden
            EndContext();
            BeginContext(3394, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(3534, 45, false);
#line 81 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(3579, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(3719, 47, false);
#line 84 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3766, 226, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th></th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 90 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(4097, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4230, 72, false);
#line 94 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.EmployeeID, item.EmployeeID, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(4302, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4442, 64, false);
#line 97 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.Pasien, item.Pasien, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(4506, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4646, 126, false);
#line 100 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.TglAwalBerobat.ToString("dd-MM-yyyy"), item.TglAwalBerobat.ToString("dd-MM-yyyy"), new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(4772, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4912, 128, false);
#line 103 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.TglAkhirBerobat.ToString("dd-MM-yyyy"), item.TglAkhirBerobat.ToString("dd-MM-yyyy"), new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(5040, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(5180, 78, false);
#line 106 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.TempatBerobat, item.TempatBerobat, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(5258, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(5398, 72, false);
#line 109 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.JenisKlaim, item.JenisKlaim, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(5470, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(5610, 72, false);
#line 112 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.NominalPotongan, item.Biaya, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(5682, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(5822, 75, false);
#line 115 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.NominalPotongan, item.Angsuran, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(5897, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(6037, 82, false);
#line 118 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.NominalPotongan, item.NominalPotongan, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(6119, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(6259, 86, false);
#line 121 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.PeriodePemotongan, item.PeriodePemotongan, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(6345, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(6485, 72, false);
#line 124 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.Keterangan, item.Keterangan, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(6557, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(6697, 70, false);
#line 127 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.CreatedBy, item.CreatedBy, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(6767, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(6907, 60, false);
#line 130 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                       Write(Html.Label(item.CreatedDate.ToString("dd-MM-yyyy hh:mm:ss")));

#line default
#line hidden
            EndContext();
            BeginContext(6967, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 133 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(7098, 399, true);
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <!-- [ sample-page ] end -->
        </div>
        <!-- [ Main Content ] end -->
    </div>
</div>

<style type=""text/css"">
    .goliveprd {
        background-color: #BEE4FF;
    }
</style>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BenefitUploader.Models.LoanMedical>> Html { get; private set; }
    }
}
#pragma warning restore 1591
