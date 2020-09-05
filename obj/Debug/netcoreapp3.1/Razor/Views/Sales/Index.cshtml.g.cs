#pragma checksum "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "253440e670de71c342b15212aa72d8a3c410a314"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_Index), @"mvc.1.0.view", @"/Views/Sales/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"253440e670de71c342b15212aa72d8a3c410a314", @"/Views/Sales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42e933323c0cbf2803ebf06596def8cbed48878", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel<SaleSoft.Models.EF.Sale>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-icons"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
  
    ViewData["Title"] = "Продажи";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""responsive-table"">
    <thead>
        <tr>
            <th>Софт</th>
            <th>Цена за единицу</th>
            <th>Кол-во</th>
            <th>Скидка</th>
            <th>Сумма</th>
            <th>Причина скидки</th>
            <th>Дата</th>
            <th>Клиент</th>
            <th>Магазин</th>
            <th>Операции</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
         foreach (var item in Model.List)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
               Write(item.Soft.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
               Write(item.Soft.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
               Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
               Write(item.Discount.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</td>\r\n                <td>");
#nullable restore
#line 29 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
               Write(item.Сost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
               Write(item.Discount.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
               Write(item.Date.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
               Write(item.Clinet.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
               Write(item.Shop.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "253440e670de71c342b15212aa72d8a3c410a3146576", async() => {
                WriteLiteral(" <i class=\"material-icons \">edit</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1043, "~/Sales/Update/", 1043, 15, true);
#nullable restore
#line 35 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
AddHtmlAttributeValue("", 1058, item.Id, 1058, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1158, "\"", 1186, 3);
            WriteAttributeValue("", 1168, "Delete(\'", 1168, 8, true);
#nullable restore
#line 36 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
WriteAttributeValue("", 1176, item.Id, 1176, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1184, "\')", 1184, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"my-icons\"> <i class=\"material-icons my-icons\">clear</i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "D:\sandbox for project\MVC\MVC_CoreAppTest\Views\Sales\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<page-link page-model=\"Model.PageViewModel\" page-action=\"Index\"></page-link>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        console.log(\"Привет Мир!!!\");\r\n        //вывести подсказку вопрос при удалении\r\n        //напистаь аякс запрос\r\n        //радирект назад на список при успехе\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel<SaleSoft.Models.EF.Sale>> Html { get; private set; }
    }
}
#pragma warning restore 1591
