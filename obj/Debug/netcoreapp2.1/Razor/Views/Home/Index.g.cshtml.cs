#pragma checksum "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c140b2205825143e70c57ffdf62a1f8414903e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/_ViewImports.cshtml"
using Tamagotchi;

#line default
#line hidden
#line 2 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/_ViewImports.cshtml"
using Tamagotchi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c140b2205825143e70c57ffdf62a1f8414903e6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a994ff1fc0730c5933aa46669ef685e6d3b1b38", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tamagotchi.Models.Pet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(75, 1480, true);
            WriteLiteral(@"
<!-- <meta http-equiv=""refresh"" content=""2""> -->

<div class=""center"" style=""width: 30%;
background: url(http://blog.pressan.is/wp-content/uploads/sites/90/2010/11/green-field-wallpapers_8739_1024x7681.jpg);
background-position:bottom"">

<div class=""row center"" >
    <div style=""width: 90%; margin-top: 10px"" class=""btn-group btn-group-justified center"" role=""group"" aria-label=""..."">
        <div class=""btn-group"" role=""group"">
            <button id=""cure"" type=""button"" class=""btn btn-lg"">
                <i class=""fas fa-syringe""></i>
            </button>
        </div>
        <div class=""btn-group"" role=""group"">
            <button id=""eat"" type=""button"" class=""btn btn-lg"">
                <i class=""fas fa-utensils""></i>
            </button>
        </div>
        <div class=""btn-group"" role=""group"">
            <button id=""sleep"" type=""button"" class=""btn btn-lg"">
                <i class=""fas fa-lightbulb""></i>
            </button>
        </div>
        <div class=""btn-group"" ");
            WriteLiteral(@"role=""group"">
            <button id=""flush"" type=""button"" class=""btn btn-lg"">
                <i class=""fas fa-shower""></i>
            </button>
        </div>
        <div class=""btn-group"" role=""group"">
            <button id=""play"" type=""button"" class=""btn btn-lg"">
                <i class=""fas fa-gamepad""></i>
            </button>
        </div>
    </div>
</div>

<div class=""row center"">
        
        <p>I am <span id=""state"">");
            EndContext();
            BeginContext(1556, 11, false);
#line 44 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
                            Write(Model.State);

#line default
#line hidden
            EndContext();
            BeginContext(1567, 214, true);
            WriteLiteral("</span></p>\r\n        <img id=\"petimg\" style=\"width: 200px\" src=\"http://2.bp.blogspot.com/-pEi1Tz0Xj9o/Ui3--vUDuXI/AAAAAAAAAp8/9bMzxDo3Rq8/s1600/tumblr_m1i3b73kEI1r6gk4zo1_500.gif\">\r\n        <h4 style=\"color:white\">");
            EndContext();
            BeginContext(1782, 10, false);
#line 46 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1792, 175, true);
            WriteLiteral("</h4>\r\n        <div class=\"center\" style=\"width: 90%\">\r\n        <div class=\"progress\">\r\n        <div id=\"happyBar\" class=\"progress-bar progress-bar-success\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1967, "\"", 1995, 1);
#line 49 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
WriteAttributeValue("", 1983, Model.Happy, 1983, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1996, 38, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2034, "\"", 2062, 3);
            WriteAttributeValue("", 2042, "width:", 2042, 6, true);
#line 49 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
WriteAttributeValue(" ", 2048, Model.Happy, 2049, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2061, "%", 2061, 1, true);
            EndWriteAttribute();
            BeginContext(2063, 175, true);
            WriteLiteral(">\r\n           Happy\r\n        </div>\r\n        </div>\r\n\r\n        <div class=\"progress\">\r\n        <div id=\"healthBar\" class=\"progress-bar progress-bar-success\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2238, "\"", 2267, 1);
#line 55 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
WriteAttributeValue("", 2254, Model.Health, 2254, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2268, 38, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2306, "\"", 2335, 3);
            WriteAttributeValue("", 2314, "width:", 2314, 6, true);
#line 55 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
WriteAttributeValue(" ", 2320, Model.Health, 2321, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2334, "%", 2334, 1, true);
            EndWriteAttribute();
            BeginContext(2336, 175, true);
            WriteLiteral(">\r\n            Health\r\n        </div>\r\n        </div>\r\n        <div class=\"progress\">\r\n        <div id=\"hungerBar\" class=\"progress-bar progress-bar-success\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2511, "\"", 2540, 1);
#line 60 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
WriteAttributeValue("", 2527, Model.Hunger, 2527, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2541, 38, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2579, "\"", 2608, 3);
            WriteAttributeValue("", 2587, "width:", 2587, 6, true);
#line 60 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
WriteAttributeValue(" ", 2593, Model.Hunger, 2594, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2607, "%", 2607, 1, true);
            EndWriteAttribute();
            BeginContext(2609, 161, true);
            WriteLiteral(">\r\n            Hunger\r\n        </div>\r\n        </div>   \r\n\r\n    </div> \r\n\r\n</div>\r\n\r\n</div>\r\n\r\n<a class=\"btn btn-danger\" style=\"float: right\">Excluir Pet</a>\r\n\r\n");
            EndContext();
            BeginContext(2770, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "982fd5e8e5244b958d3b98a5f9f875cd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2821, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2823, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab27b15db1ea4b2182d0780a3b971843", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 74 "/home/rodrigo/UTFPR/LP/Tamagotchi/Views/Home/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2885, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tamagotchi.Models.Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591
