#pragma checksum "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Softs\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebc1726e0af50631454044bd75124b6366e56656"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Softs_Update), @"mvc.1.0.view", @"/Views/Softs/Update.cshtml")]
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
#line 1 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\_ViewImports.cshtml"
using SaleSoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\_ViewImports.cshtml"
using SaleSoft.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebc1726e0af50631454044bd75124b6366e56656", @"/Views/Softs/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42e933323c0cbf2803ebf06596def8cbed48878", @"/Views/_ViewImports.cshtml")]
    public class Views_Softs_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SaleSoft.Models.EF.Soft>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col s8 offset-s2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateSoft", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Softs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Softs\Update.cshtml"
  
    ViewData["Title"] = "Обновление Софта";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row center-align\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebc1726e0af50631454044bd75124b6366e566564698", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 254, "\"", 271, 1);
#nullable restore
#line 8 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Softs\Update.cshtml"
WriteAttributeValue("", 262, Model.Id, 262, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <div class=\"row\">\r\n            <div class=\"input-field col s12 \">\r\n                <input id=\"name\" type=\"text\" name=\"Name\" class=\"validate\" autocomplete=\"off\" required");
                BeginWriteAttribute("value", " value=\"", 453, "\"", 472, 1);
#nullable restore
#line 11 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Softs\Update.cshtml"
WriteAttributeValue("", 461, Model.Name, 461, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <label for=""name"">Наименование</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""input-field col s12 "">
                <input id=""des"" type=""text"" name=""Des"" class=""validate"" autocomplete=""off"" required");
                BeginWriteAttribute("value", " value=\"", 744, "\"", 762, 1);
#nullable restore
#line 17 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Softs\Update.cshtml"
WriteAttributeValue("", 752, Model.Des, 752, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <label for=""des"">Описание</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""input-field col s12 "">
                <input id=""price"" type=""number"" name=""PriceStr"" class=""validate"" autocomplete=""off"" min=""1"" step="".1"" required");
                BeginWriteAttribute("value", " value=\"", 1056, "\"", 1104, 1);
#nullable restore
#line 23 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Softs\Update.cshtml"
WriteAttributeValue("", 1064, Model.Price.ToString().Replace(',','.'), 1064, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <label for=""price"">Цена</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""input-field col s12 "">
                <input id=""count"" type=""number"" name=""Count"" class=""validate"" autocomplete=""off"" min=""1"" required");
                BeginWriteAttribute("value", " value=\"", 1383, "\"", 1403, 1);
#nullable restore
#line 29 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Softs\Update.cshtml"
WriteAttributeValue("", 1391, Model.Count, 1391, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <label for=""count"">Кол-во</label>
            </div>
        </div>
        <div class=""row"">
            <div class=""input-field col s12 "">
                <button class=""btn waves-effect waves-light"" type=""submit"" name=""action"">Сохранить</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaleSoft.Models.EF.Soft> Html { get; private set; }
    }
}
#pragma warning restore 1591
