#pragma checksum "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "680ef6d2f3b27a9ee11504cfb15ea0c7a4a4250a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MicroprocessorStore_AvailabilitiesForMicroprocessor), @"mvc.1.0.view", @"/Views/MicroprocessorStore/AvailabilitiesForMicroprocessor.cshtml")]
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
#line 1 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\_ViewImports.cshtml"
using MicroprocessorStoreClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\_ViewImports.cshtml"
using MicroprocessorStoreClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680ef6d2f3b27a9ee11504cfb15ea0c7a4a4250a", @"/Views/MicroprocessorStore/AvailabilitiesForMicroprocessor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d0d8013ae00e8daf0e2e483cb69e1ecabe3177", @"/Views/_ViewImports.cshtml")]
    public class Views_MicroprocessorStore_AvailabilitiesForMicroprocessor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Microprocessor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MicroprocessorStore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateAvailabilityForMicroprocessor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
 if (!string.IsNullOrWhiteSpace(ViewBag.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 7 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 8 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Availabilities</h2>\r\n");
#nullable restore
#line 11 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
 if (Model.NumberOfAvailability > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table>
        <thead>
            <tr>
                <th>Name</th>
                <th>Address</th>
                <th>Price</th>
                <th>Quantity</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
             foreach (AvailabilityForMicroprocessor availability in Model.Availability)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
                   Write(availability.Store.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
                   Write(availability.Store.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "680ef6d2f3b27a9ee11504cfb15ea0c7a4a4250a7551", async() => {
                WriteLiteral("\r\n                        <td><input type=\"text\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 892, "\"", 919, 1);
#nullable restore
#line 30 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
WriteAttributeValue("", 900, availability.Price, 900, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                        <td><input type=\"text\" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 992, "\"", 1022, 1);
#nullable restore
#line 31 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
WriteAttributeValue("", 1000, availability.Quantity, 1000, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                        <td>\r\n                            <input type=\"hidden\" name=\"availabilityid\"");
                BeginWriteAttribute("value", " value=\"", 1133, "\"", 1157, 1);
#nullable restore
#line 33 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
WriteAttributeValue("", 1141, availability.Id, 1141, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"storeid\"");
                BeginWriteAttribute("value", " value=\"", 1226, "\"", 1256, 1);
#nullable restore
#line 34 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
WriteAttributeValue("", 1234, availability.Store.Id, 1234, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"microprocessorid\"");
                BeginWriteAttribute("value", " value=\"", 1334, "\"", 1351, 1);
#nullable restore
#line 35 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
WriteAttributeValue("", 1342, Model.Id, 1342, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button type=\"submit\">Update</button>\r\n                        </td>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 43 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>This microprocessor is not available at any stores at the moment.</p>\r\n");
#nullable restore
#line 47 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForMicroprocessor.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Microprocessor> Html { get; private set; }
    }
}
#pragma warning restore 1591
