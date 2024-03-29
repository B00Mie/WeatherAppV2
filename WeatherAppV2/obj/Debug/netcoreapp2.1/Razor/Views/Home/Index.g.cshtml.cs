#pragma checksum "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10aa9ea29ade17911d5ac210972967cd35242747"
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
#line 1 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\_ViewImports.cshtml"
using WeatherAppV2;

#line default
#line hidden
#line 2 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\_ViewImports.cshtml"
using WeatherAppV2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10aa9ea29ade17911d5ac210972967cd35242747", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a59c9b575c880e8a54b278d57bc66450e59b7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "metric", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "imperial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "en", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ua", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ru", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var celsius = "C°";
    var kelvin = "K°";
    var fahrenheight = "F°";
    var forecast = (ForecastVM)ViewData["forecast"];


#line default
#line hidden
            BeginContext(180, 132, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 text-center\">\r\n        <h1>Weather App</h1>\r\n        <div class=\"form\">\r\n            ");
            EndContext();
            BeginContext(312, 999, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2f203d7e3dc4b13a1b5f65e659fc21b", async() => {
                BeginContext(345, 309, true);
                WriteLiteral(@"
                <div class=""col-md-12"">
                    <input type=""text"" name=""city"" placeholder=""Type in a city name"" />
                </div>
                <div class=""col-md-12"">
                    <p>Measurement unit:</p>
                    <select name=""unit"">
                        ");
                EndContext();
                BeginContext(654, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74daa01e79c34819b76fbb7a66df24f5", async() => {
                    BeginContext(677, 6, true);
                    WriteLiteral("Metric");
                    EndContext();
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
                EndContext();
                BeginContext(692, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(718, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "726e4bd1cef34f64bdb30253e9015432", async() => {
                    BeginContext(743, 8, true);
                    WriteLiteral("Imperial");
                    EndContext();
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
                EndContext();
                BeginContext(760, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(786, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c86c8879f24f8a980c2b58917942c9", async() => {
                    BeginContext(803, 6, true);
                    WriteLiteral("Kelvin");
                    EndContext();
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
                EndContext();
                BeginContext(818, 202, true);
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <div class=\"col-md-12\">\r\n                    <p>Language:</p>\r\n                    <select name=\"lang\">\r\n                        ");
                EndContext();
                BeginContext(1020, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c49592b090d64243991b056849c83d09", async() => {
                    BeginContext(1039, 7, true);
                    WriteLiteral("English");
                    EndContext();
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
                EndContext();
                BeginContext(1055, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1081, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d78dcc564934da088eb01d51f3e0144", async() => {
                    BeginContext(1100, 9, true);
                    WriteLiteral("Ukrainian");
                    EndContext();
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
                EndContext();
                BeginContext(1118, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1144, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e3eac66d964091b452e44e9553f68a", async() => {
                    BeginContext(1163, 7, true);
                    WriteLiteral("Russian");
                    EndContext();
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
                EndContext();
                BeginContext(1179, 125, true);
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <input type=\"submit\" value=\"Search\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1311, 31, true);
            WriteLiteral("\r\n            <p class=\"error\">");
            EndContext();
            BeginContext(1343, 16, false);
#line 36 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                        Write(ViewBag.errorMsg);

#line default
#line hidden
            EndContext();
            BeginContext(1359, 109, true);
            WriteLiteral("</p>\r\n            \r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 46 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
         if (ViewBag.weather != null)
        {

#line default
#line hidden
            BeginContext(1516, 43, true);
            WriteLiteral("<h1>Current Weather:</h1>\r\n            <h3>");
            EndContext();
            BeginContext(1560, 20, false);
#line 48 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
           Write(ViewBag.weather.name);

#line default
#line hidden
            EndContext();
            BeginContext(1580, 23, true);
            WriteLiteral("</h3>\r\n            <h4>");
            EndContext();
            BeginContext(1604, 38, false);
#line 49 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
           Write(ViewBag.weather.Weather[0].description);

#line default
#line hidden
            EndContext();
            BeginContext(1642, 4, true);
            WriteLiteral("<img");
            EndContext();
            BeginWriteAttribute("src", " src=", 1646, "", 1741, 1);
#line 49 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1651, string.Format("http://openweathermap.org/img/w/{0}.png", ViewBag.weather.Weather[0].icon), 1651, 90, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1741, 10, true);
            WriteLiteral(" /></h4>\r\n");
            EndContext();
            BeginContext(1767, 46, true);
            WriteLiteral("            <p>\r\n                Temperature: ");
            EndContext();
            BeginContext(1814, 37, false);
#line 53 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                        Write(Math.Round(ViewBag.weather.Main.temp));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                 if (ViewBag.unit == "metric")
                {
                    ViewBag.unit = celsius;
                }
                else if (ViewBag.unit == "imperial")
                {
                    ViewBag.unit = fahrenheight;
                }
                else
                {
                    ViewBag.unit = kelvin;
                }

#line default
#line hidden
            BeginContext(2230, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2247, 12, false);
#line 66 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
           Write(ViewBag.unit);

#line default
#line hidden
            EndContext();
            BeginContext(2259, 45, true);
            WriteLiteral("\r\n            </p>\r\n            <p>Humidity: ");
            EndContext();
            BeginContext(2305, 29, false);
#line 68 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                    Write(ViewBag.weather.Main.humidity);

#line default
#line hidden
            EndContext();
            BeginContext(2334, 28, true);
            WriteLiteral("%</p>\r\n            <p>Wind: ");
            EndContext();
            BeginContext(2363, 38, false);
#line 69 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                Write(Math.Round(ViewBag.weather.Wind.speed));

#line default
#line hidden
            EndContext();
            BeginContext(2401, 9, true);
            WriteLiteral("m/s</p>\r\n");
            EndContext();
#line 70 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2421, 40, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-md-8\">\r\n");
            EndContext();
#line 73 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
         if (ViewBag.forecast != null)
        {

#line default
#line hidden
            BeginContext(2512, 54, true);
            WriteLiteral("            <h1>5-day Forecast:</h1>\r\n            <h3>");
            EndContext();
            BeginContext(2567, 26, false);
#line 76 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
           Write(ViewBag.forecast.City.name);

#line default
#line hidden
            EndContext();
            BeginContext(2593, 50, true);
            WriteLiteral("</h3>\r\n            <table>\r\n                <tr>\r\n");
            EndContext();
#line 79 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                     for (int i = 0; i < forecast.list.Count; i += 8)
                    {

#line default
#line hidden
            BeginContext(2737, 64, true);
            WriteLiteral("                        <td>\r\n                            <p><b>");
            EndContext();
            BeginContext(2802, 63, false);
#line 82 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                             Write(Convert.ToDateTime(forecast.list[i].dt_txt).ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2865, 41, true);
            WriteLiteral("</b></p>\r\n                            <p>");
            EndContext();
            BeginContext(2907, 39, false);
#line 83 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                          Write(forecast.list[i].weather[0].description);

#line default
#line hidden
            EndContext();
            BeginContext(2946, 4, true);
            WriteLiteral("<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2950, "\"", 3047, 1);
#line 83 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
WriteAttributeValue("", 2956, string.Format("http://openweathermap.org/img/w/{0}.png", forecast.list[i].weather[0].icon), 2956, 91, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3048, 106, true);
            WriteLiteral(" style=\"width:40px;\"/></p>\r\n                            <p>\r\n                                Temperature: ");
            EndContext();
            BeginContext(3155, 38, false);
#line 85 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                                        Write(Math.Round(forecast.list[i].main.temp));

#line default
#line hidden
            EndContext();
            BeginContext(3193, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3228, 12, false);
#line 86 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                           Write(ViewBag.unit);

#line default
#line hidden
            EndContext();
            BeginContext(3240, 77, true);
            WriteLiteral("\r\n                            </p>\r\n                            <p>Humidity: ");
            EndContext();
            BeginContext(3318, 30, false);
#line 88 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                                    Write(forecast.list[i].main.humidity);

#line default
#line hidden
            EndContext();
            BeginContext(3348, 44, true);
            WriteLiteral("%</p>\r\n                            <p>Wind: ");
            EndContext();
            BeginContext(3394, 27, false);
#line 89 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"
                                 Write(forecast.list[i].wind.speed);

#line default
#line hidden
            EndContext();
            BeginContext(3422, 40, true);
            WriteLiteral("m/s</p>\r\n                        </td>\r\n");
            EndContext();
#line 91 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(3487, 47, true);
            WriteLiteral("                </tr>\r\n\r\n            </table>\r\n");
            EndContext();
#line 96 "C:\Users\boome\source\repos\WeatherAppV2\WeatherAppV2\Views\Home\Index.cshtml"


        }

#line default
#line hidden
            BeginContext(3549, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
