#pragma checksum "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e8b13cee13d33206a31e29f3d137594a2057b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\_ViewImports.cshtml"
using RTInsiderTourGuide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\_ViewImports.cshtml"
using RTInsiderTourGuide.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e8b13cee13d33206a31e29f3d137594a2057b5", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8874b0b419974924cf310dba7596ea851544849e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tour>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Any", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Adventure Tour", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Attractions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Experiences Tours", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Private Tours", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Scheduled Tours", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProccessSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""/"">Runtime Terror</a>
        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/"">Home</a>
            </li>
");
#nullable restore
#line 10 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
              
              if (Context.Session.GetInt32("userId") != null)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"nav-item\">\n                        <a class=\"nav-link\" href=\"/userdashboard\">My Dashboard</a>\n                  </li>\n");
#nullable restore
#line 16 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
              }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
              
              if (Context.Session.GetInt32("userId") == 1)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"nav-item\">\n                        <a class=\"nav-link\" href=\"/admin\">Admin Dashboard</a>\n                  </li>\n");
#nullable restore
#line 24 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
              }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item active\">\n                <a class=\"nav-link\" href=\"/SearchTours\">Search For Tours</a>\n            </li>\n            <li class=\"nav-item\">\n                <a class=\"nav-link\" href=\"#\">Contact Us</a>\n            </li>\n");
#nullable restore
#line 32 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
              
              if (Context.Session.GetInt32("userId") != null)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"login\">\n                    <a class=\"nav-link\" href=\"/logout\">Logout</a>\n                  </li>\n");
#nullable restore
#line 38 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
              }
              else
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"login\">\n                  <a class=\"nav-link\" href=\"/login\">Login</a>\n                </li>\n");
#nullable restore
#line 44 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
              }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</nav>\n\n<main class=\"container\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b511731", async() => {
                WriteLiteral("\n        <h3 style=\"margin-bottom: 35px;\"><u>Search:</u></h3>\n        <div class=\"row row-cols-5\">\n            <div class=\"col\">\n                <label");
                BeginWriteAttribute("for", " for=\"", 1798, "\"", 1804, 0);
                EndWriteAttribute();
                WriteLiteral(">Keywords</label>\n                <input type=\"text\" class=\"form-control\" name=\"keywords\">\n            </div>\n            <div class=\"col\">\n                <label");
                BeginWriteAttribute("for", " for=\"", 1967, "\"", 1973, 0);
                EndWriteAttribute();
                WriteLiteral(">Destination</label>\n                <input type=\"text\" class=\"form-control\" name=\"dest\">\n            </div>\n            <div class=\"col\">\n                <label");
                BeginWriteAttribute("for", " for=\"", 2135, "\"", 2141, 0);
                EndWriteAttribute();
                WriteLiteral(">Category</label>\n                <select type=\"text\" class=\"form-control\" name=\"category\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b513064", async() => {
                    WriteLiteral("Any");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b514303", async() => {
                    WriteLiteral("Adventure Tour");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b515553", async() => {
                    WriteLiteral("Attractions");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b516800", async() => {
                    WriteLiteral("Experiences Tours");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b518053", async() => {
                    WriteLiteral("Private Tours");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b519302", async() => {
                    WriteLiteral("Scheduled Tours");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </select>\n            </div>\n            <div class=\"col\">\n                <label");
                BeginWriteAttribute("for", " for=\"", 2759, "\"", 2765, 0);
                EndWriteAttribute();
                WriteLiteral(">Duration</label>\n                <select type=\"text\" class=\"form-control\" name=\"days\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b520901", async() => {
                    WriteLiteral("Any");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b522140", async() => {
                    WriteLiteral("One Day");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b523383", async() => {
                    WriteLiteral("Two Days");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b524627", async() => {
                    WriteLiteral("Three Days");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b525873", async() => {
                    WriteLiteral("Four Days");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e8b13cee13d33206a31e29f3d137594a2057b527120", async() => {
                    WriteLiteral("Five Days");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </select>\n            </div>\n            <div class=\"col\" style=\" text-align: center; padding-top: 29px;\">\n                <button class=\"searchBtn\" >Search</button>\n            </div>\n            </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 89 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
      
        if (Model != null && Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"searchResults\">\n                <h3><u>Search Results:</u></h3>\n                <div class=\"row row-cols-1 row-cols-md-3 mt-4\">\n\n");
#nullable restore
#line 96 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
                      
                        foreach (Tour t in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 mb-4\">\n                            <div class=\"card\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3869, "\"", 3891, 2);
            WriteAttributeValue("", 3876, "/tour/", 3876, 6, true);
#nullable restore
#line 101 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
WriteAttributeValue("", 3882, t.TourId, 3882, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3930, "\"", 3958, 1);
#nullable restore
#line 102 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
WriteAttributeValue("", 3936, t.ImagesOfTour[0].Url, 3936, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top card-img\">\n                                </a>\n                                <div class=\"card-body\">\n                                <h6 class=\"card-title\"><a");
            BeginWriteAttribute("href", " href=\"", 4141, "\"", 4163, 2);
            WriteAttributeValue("", 4148, "/tour/", 4148, 6, true);
#nullable restore
#line 105 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
WriteAttributeValue("", 4154, t.TourId, 4154, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 105 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
                                                                            Write(t.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\n                                <p class=\"text-center price\" >$");
#nullable restore
#line 106 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
                                                          Write(t.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>Includes transportation, the mentioned meals, and a tour guide</p>\n                                <p class=\"card-text\">Availability : ");
#nullable restore
#line 108 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
                                                               Write(t.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" day/s.</p>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4486, "\"", 4508, 2);
            WriteAttributeValue("", 4493, "/tour/", 4493, 6, true);
#nullable restore
#line 109 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
WriteAttributeValue("", 4499, t.TourId, 4499, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><u>View More...</u></a>\n                                </div>\n                            </div>\n                            </div>\n");
#nullable restore
#line 113 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div> \n");
#nullable restore
#line 118 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
        }
        else if (Model != null && Model.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"searchResults\">\n                <h3 class=\"text-center\" ><u>Sorry nothing matched your search criteria. <br> Please try again with different keywords</u></h3>\n            </div>\n");
#nullable restore
#line 124 "C:\Users\halmu\OneDrive\Documents\C#.NET core\ORMsLINQ\RTInsiderTourGuide\RTInsiderTourGuide\Views\Home\Search.cshtml"
        }
        
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tour>> Html { get; private set; }
    }
}
#pragma warning restore 1591
