#pragma checksum "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34417309bd5785b52305a801077d18769424aa85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoanMedicals_Delete), @"mvc.1.0.view", @"/Views/LoanMedicals/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoanMedicals/Delete.cshtml", typeof(AspNetCore.Views_LoanMedicals_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34417309bd5785b52305a801077d18769424aa85", @"/Views/LoanMedicals/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efc99dbed31dd8b4c5346fc377387804105c941", @"/Views/_ViewImports.cshtml")]
    public class Views_LoanMedicals_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BenefitUploader.Models.LoanMedical>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>LoanMedical</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(307, 46, false);
#line 16 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(353, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(397, 42, false);
#line 19 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(439, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(483, 50, false);
#line 22 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TglAwalBerobat));

#line default
#line hidden
            EndContext();
            BeginContext(533, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(577, 46, false);
#line 25 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TglAwalBerobat));

#line default
#line hidden
            EndContext();
            BeginContext(623, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(667, 51, false);
#line 28 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TglAkhirBerobat));

#line default
#line hidden
            EndContext();
            BeginContext(718, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(762, 47, false);
#line 31 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TglAkhirBerobat));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(853, 49, false);
#line 34 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TempatBerobat));

#line default
#line hidden
            EndContext();
            BeginContext(902, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(946, 45, false);
#line 37 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TempatBerobat));

#line default
#line hidden
            EndContext();
            BeginContext(991, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1035, 46, false);
#line 40 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JenisKlaim));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1125, 42, false);
#line 43 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JenisKlaim));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1211, 51, false);
#line 46 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NominalPotongan));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1306, 47, false);
#line 49 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NominalPotongan));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1397, 46, false);
#line 52 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Keterangan));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1487, 42, false);
#line 55 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Keterangan));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1573, 53, false);
#line 58 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PeriodePemotongan));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1670, 49, false);
#line 61 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PeriodePemotongan));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1763, 45, false);
#line 64 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1852, 41, false);
#line 67 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1937, 47, false);
#line 70 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1984, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2028, 43, false);
#line 73 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2115, 47, false);
#line 76 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2206, 43, false);
#line 79 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2249, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2287, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34417309bd5785b52305a801077d18769424aa8514154", async() => {
                BeginContext(2313, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2323, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34417309bd5785b52305a801077d18769424aa8514547", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 84 "D:\Besol-Basic-apps\BenefitsUploader\BenefitUploader\Views\LoanMedicals\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2359, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2443, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34417309bd5785b52305a801077d18769424aa8516460", async() => {
                    BeginContext(2465, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2481, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2494, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BenefitUploader.Models.LoanMedical> Html { get; private set; }
    }
}
#pragma warning restore 1591
