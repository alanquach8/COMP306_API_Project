#pragma checksum "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\UpdateMicroprocessor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8f839120c016774ba592e7da413886cd5faf23c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MicroprocessorStore_UpdateMicroprocessor), @"mvc.1.0.view", @"/Views/MicroprocessorStore/UpdateMicroprocessor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8f839120c016774ba592e7da413886cd5faf23c", @"/Views/MicroprocessorStore/UpdateMicroprocessor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d0d8013ae00e8daf0e2e483cb69e1ecabe3177", @"/Views/_ViewImports.cshtml")]
    public class Views_MicroprocessorStore_UpdateMicroprocessor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Microprocessor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MicroprocessorStore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Microprocessors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateMicroprocessorInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\UpdateMicroprocessor.cshtml"
 if (!string.IsNullOrWhiteSpace(ViewBag.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 5 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\UpdateMicroprocessor.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 6 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\UpdateMicroprocessor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Update Form For Microprocessor ID = ");
#nullable restore
#line 8 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\UpdateMicroprocessor.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8f839120c016774ba592e7da413886cd5faf23c6190", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 305, "\"", 322, 1);
#nullable restore
#line 11 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\UpdateMicroprocessor.cshtml"
WriteAttributeValue("", 313, Model.Id, 313, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <label>Name:</label><input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 382, "\"", 401, 1);
#nullable restore
#line 12 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\UpdateMicroprocessor.cshtml"
WriteAttributeValue("", 390, Model.Name, 390, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label>Description:</label><input type=\"text\" name=\"description\"");
                BeginWriteAttribute("value", " value=\"", 487, "\"", 513, 1);
#nullable restore
#line 14 "C:\Users\alanq\Desktop\COMP306 - API Project\MicroprocessorStoreAPIProject\MicroprocessorStoreClient\Views\MicroprocessorStore\UpdateMicroprocessor.cshtml"
WriteAttributeValue("", 495, Model.Description, 495, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <button type=\"submit\">Update</button>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8f839120c016774ba592e7da413886cd5faf23c8061", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
