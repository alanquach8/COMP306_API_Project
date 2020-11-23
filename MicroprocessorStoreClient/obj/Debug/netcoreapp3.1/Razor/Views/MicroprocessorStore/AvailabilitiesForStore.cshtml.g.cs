#pragma checksum "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc31c20d115d5db43a98118bd362956aedc53d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MicroprocessorStore_AvailabilitiesForStore), @"mvc.1.0.view", @"/Views/MicroprocessorStore/AvailabilitiesForStore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc31c20d115d5db43a98118bd362956aedc53d2", @"/Views/MicroprocessorStore/AvailabilitiesForStore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d0d8013ae00e8daf0e2e483cb69e1ecabe3177", @"/Views/_ViewImports.cshtml")]
    public class Views_MicroprocessorStore_AvailabilitiesForStore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Store>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MicroprocessorStore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateAvailabilityForStore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteStoreAvailability", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
 if (!string.IsNullOrWhiteSpace(ViewBag.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 7 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 8 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Availabilities</h2>\r\n");
#nullable restore
#line 11 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
 if (Model.NumberOfAvailability > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table>
        <thead>
            <tr>
                <th>Name</th>
                <th>Description</th>
                <th>Price</th>
                <th>Quantity</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
             foreach (AvailabilityForStore availability in Model.Availability)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
                   Write(availability.Microprocessor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
                   Write(availability.Microprocessor.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acc31c20d115d5db43a98118bd362956aedc53d27910", async() => {
                WriteLiteral("\r\n                        <td><input type=\"text\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 918, "\"", 945, 1);
#nullable restore
#line 31 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
WriteAttributeValue("", 926, availability.Price, 926, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                        <td><input type=\"text\" name=\"quantity\"");
                BeginWriteAttribute("value", " value=\"", 1018, "\"", 1048, 1);
#nullable restore
#line 32 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
WriteAttributeValue("", 1026, availability.Quantity, 1026, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                        <td>\r\n                            <input type=\"hidden\" name=\"availabilityid\"");
                BeginWriteAttribute("value", " value=\"", 1159, "\"", 1183, 1);
#nullable restore
#line 34 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
WriteAttributeValue("", 1167, availability.Id, 1167, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"storeid\"");
                BeginWriteAttribute("value", " value=\"", 1252, "\"", 1269, 1);
#nullable restore
#line 35 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
WriteAttributeValue("", 1260, Model.Id, 1260, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"microprocessorid\"");
                BeginWriteAttribute("value", " value=\"", 1347, "\"", 1386, 1);
#nullable restore
#line 36 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
WriteAttributeValue("", 1355, availability.Microprocessor.Id, 1355, 31, false);

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
            WriteLiteral("\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acc31c20d115d5db43a98118bd362956aedc53d212618", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-avilabilityid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
                                                                                                                  WriteLiteral(availability.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["avilabilityid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-avilabilityid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["avilabilityid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
                                                                                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-storeid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 45 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>This store has no availailities at the moment.</p>\r\n");
#nullable restore
#line 49 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\AvailabilitiesForStore.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Store> Html { get; private set; }
    }
}
#pragma warning restore 1591
