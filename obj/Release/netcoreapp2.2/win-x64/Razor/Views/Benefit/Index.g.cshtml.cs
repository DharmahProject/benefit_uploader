#pragma checksum "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d3b09a00f0d4216fd42babf06698b158a34db15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Benefit_Index), @"mvc.1.0.view", @"/Views/Benefit/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Benefit/Index.cshtml", typeof(AspNetCore.Views_Benefit_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d3b09a00f0d4216fd42babf06698b158a34db15", @"/Views/Benefit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efc99dbed31dd8b4c5346fc377387804105c941", @"/Views/_ViewImports.cshtml")]
    public class Views_Benefit_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BenefitUploader.Models.Benefit>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Export to excel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
  
    ViewData["Title"] = "Uploaded List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 233, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <div class=\"col-sm-10\">\r\n            <label style=\"font-size:30px\">Uploaded List</label>\r\n        </div>\r\n        <div class=\"col-sm-2\" style=\"padding-top:15px\">\r\n\r\n            ");
            EndContext();
            BeginContext(383, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3b09a00f0d4216fd42babf06698b158a34db154765", async() => {
                BeginContext(452, 15, true);
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
            BeginContext(471, 968, true);
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
            BeginContext(1440, 46, false);
#line 45 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(1626, 40, false);
#line 48 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(1806, 44, false);
#line 51 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.PersArea));

#line default
#line hidden
            EndContext();
            BeginContext(1850, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(1990, 46, false);
#line 54 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.CutOffDate));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2176, 48, false);
#line 57 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.LimitTahunan));

#line default
#line hidden
            EndContext();
            BeginContext(2224, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2364, 48, false);
#line 60 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.KlaimDibayar));

#line default
#line hidden
            EndContext();
            BeginContext(2412, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2552, 46, false);
#line 63 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.OverPlafon));

#line default
#line hidden
            EndContext();
            BeginContext(2598, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2738, 45, false);
#line 66 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2783, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2923, 47, false);
#line 69 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2970, 226, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th></th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 75 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(3301, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3446, 27, false);
#line 79 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                           Write(Html.Label(item.EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(3473, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3625, 21, false);
#line 82 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                           Write(Html.Label(item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3646, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3798, 25, false);
#line 85 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                           Write(Html.Label(item.PersArea));

#line default
#line hidden
            EndContext();
            BeginContext(3823, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3975, 118, false);
#line 88 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                           Write(Html.Label(item.CutOffDate.ToString("dd-MM-yyyy"), item.CutOffDate.ToString("dd-MM-yyyy"), new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(4093, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4245, 76, false);
#line 91 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                           Write(Html.Label(item.LimitTahunan, item.LimitTahunan, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(4321, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4448, 149, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4598, 76, false);
#line 95 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                           Write(Html.Label(item.KlaimDibayar, item.KlaimDibayar, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(4674, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4826, 72, false);
#line 98 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                           Write(Html.Label(item.OverPlafon, item.OverPlafon, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(4898, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5050, 70, false);
#line 101 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                           Write(Html.Label(item.CreatedBy, item.CreatedBy, new { @class = "myClass" }));

#line default
#line hidden
            EndContext();
            BeginContext(5120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5203, 149, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5353, 60, false);
#line 105 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                           Write(Html.Label(item.CreatedDate.ToString("dd-MM-yyyy hh:mm:ss")));

#line default
#line hidden
            EndContext();
            BeginContext(5413, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 108 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\Benefit\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5552, 399, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BenefitUploader.Models.Benefit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
