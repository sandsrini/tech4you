#pragma checksum "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "942787e23ac8c2a8146d8b3c3e8a6b8842a920f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customizedlaptops_Report), @"mvc.1.0.view", @"/Views/Customizedlaptops/Report.cshtml")]
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
#line 1 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\_ViewImports.cshtml"
using laptopcusmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\_ViewImports.cshtml"
using laptopcusmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942787e23ac8c2a8146d8b3c3e8a6b8842a920f0", @"/Views/Customizedlaptops/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f51d0f24b04b016e09d612f879aa7721851bdb92", @"/Views/_ViewImports.cshtml")]
    public class Views_Customizedlaptops_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<tech4you.Models.Customizedlaptop>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-color"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
  
    ViewData["Title"] = "Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Report Summary</h1>\r\n    <h3>It lists all the purchased laptops</h3>\r\n</div>\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
            WriteLiteral("                Laptop Name\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Brand Name\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Unit Price\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n");
            WriteLiteral("                User Name\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Email\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Quantity\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
           Write(Html.DisplayNameFor(model => model.Grandtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 66 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cuslaptopname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cusbrandname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cusprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 88 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 106 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grandtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "942787e23ac8c2a8146d8b3c3e8a6b8842a920f08214", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
                                              WriteLiteral(item.Cuslaptopid);

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
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 114 "C:\Users\Merit\Desktop\ASPProject\tech4you\laptopcusmvc\Views\Customizedlaptops\Report.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<tech4you.Models.Customizedlaptop>> Html { get; private set; }
    }
}
#pragma warning restore 1591
