#pragma checksum "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a141a150044d46d2488a2958899e2a472b52e91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SensorsList), @"mvc.1.0.view", @"/Views/Shared/_SensorsList.cshtml")]
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
#line 1 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/_ViewImports.cshtml"
using FYP_APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/_ViewImports.cshtml"
using FYP_APP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a141a150044d46d2488a2958899e2a472b52e91", @"/Views/Shared/_SensorsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1103289fd338f5238efba9485e51b05468496a5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SensorsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dragButton.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/rightArrow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("36"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
  
    List<List<FYP_WEB_APP.Models.SensorsListModel>> SensorsByroomList = ViewData["SensorsListModel"] as List<List<FYP_WEB_APP.Models.SensorsListModel>>;


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a141a150044d46d2488a2958899e2a472b52e915320", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""modal fade"" id=""EditSensors"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">

    <div class=""modal-dialog modal-dialog-centered"" role=""document"">

        <div class=""modal-content"" id=""EditSensorsBody"">


        </div>

    </div>
</div>
<div class=""p-2 bd-highlight"">
    <div class=""card d-flex flex-column mb-2 mx-2 p-2""");
            BeginWriteAttribute("style", " style=\"", 708, "\"", 716, 0);
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"row justify-content-between align-items-center mb-2 d-flex flex-wrap\">\n            <div class=\"col \">\n                <div class=\"col h4\">\n                    Sensor List\n                </div>\n            </div>\n");
#nullable restore
#line 28 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
             if (!ViewData["NotGroup"].Equals("true"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!--\n        <div class=\" d-flex justify-content-center align-items-center\">\n            <a class=\"btn btn-outline-dark mx-2\" href=\'");
#nullable restore
#line 32 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                                  Write(ViewBag.roomIdSortParm);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>\n                roomId\n                <img src=\"~/img/icon/");
#nullable restore
#line 34 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                Write(ViewBag.sortIMG);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" height=\"25\" />\n            </a>\n        </div>\n        -->\n");
#nullable restore
#line 38 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex justify-content-end\">\n");
#nullable restore
#line 40 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                 if (ViewData["roomID"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"btn btn-outline-success px-2 mr-3\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1539, "\"", 1583, 3);
            WriteAttributeValue("", 1549, "AddtSensors(\'", 1549, 13, true);
#nullable restore
#line 42 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue("", 1562, ViewData["roomID"], 1562, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1581, "\')", 1581, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n                        &#43; Add\n                    </a>\n");
#nullable restore
#line 45 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"#\" class=\"btn btn-outline-success px-2 mr-3\" onclick=\"AddtSensors()\">\n                        &#43; Add\n                    </a>\n");
#nullable restore
#line 50 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n            </div>\n        </div>\n");
#nullable restore
#line 57 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
         if (SensorsByroomList.Count == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning text-center font-weight-bold\" role=\"alert\">\n                <h3>Please try again, no corresponding conditions.  </h3>\n            </div>\n");
#nullable restore
#line 61 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
            }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
             foreach (var getSensorsByroom in SensorsByroomList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card m-2\">\n");
#nullable restore
#line 67 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                     if (!ViewData["NotGroup"].Equals("true"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-header p-0\"");
            BeginWriteAttribute("id", " id=\"", 2413, "\"", 2458, 2);
            WriteAttributeValue("", 2418, "heading_", 2418, 8, true);
#nullable restore
#line 69 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue("", 2426, getSensorsByroom.First().roomId, 2426, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <h3 class=\"mb-0\">\n                                <button class=\"btn btn-outline-secondary w-100 border-0\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 71 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                                                                                                                  Write(getSensorsByroom.First().roomId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 2696, "\"", 2753, 2);
            WriteAttributeValue("", 2712, "collapse_", 2712, 9, true);
#nullable restore
#line 71 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue("", 2721, getSensorsByroom.First().roomId, 2721, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    ");
#nullable restore
#line 72 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                               Write(getSensorsByroom.First().roomId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </button>\n                            </h3>\n                        </div>\n");
#nullable restore
#line 76 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 2978, "\"", 3024, 2);
            WriteAttributeValue("", 2983, "collapse_", 2983, 9, true);
#nullable restore
#line 77 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue("", 2992, getSensorsByroom.First().roomId, 2992, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse show\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3047, "\"", 3105, 2);
            WriteAttributeValue("", 3065, "heading_", 3065, 8, true);
#nullable restore
#line 77 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue("", 3073, getSensorsByroom.First().roomId, 3073, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"card-body d-flex flex-wrap\">\n");
#nullable restore
#line 79 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                             foreach (var sensorModel in getSensorsByroom)
                            {
                                string turnOFstr = sensorModel.status ? "Online" : "Offline";
                                string turnOFClr = sensorModel.status ? "badge-success" : "badge-danger";
                                string expStr = sensorModel.Exception;
                                switch (sensorModel.sensorId.Substring(0, 2))
                                {
                                    case "TS":
                                        ViewData["devicesType"] = "Temperature";
                                        ViewData["TypeColor"] = "TSensor";
                                        break;
                                    case "LS":
                                        ViewData["devicesType"] = "Luminosity";
                                        ViewData["TypeColor"] = "LSensor";
                                        break;
                                    case "HS":
                                        ViewData["devicesType"] = "Humidity";
                                        ViewData["TypeColor"] = "HSensor";
                                        break;
                                    case "AS":
                                        ViewData["devicesType"] = "Air Quality";
                                        ViewData["TypeColor"] = "ASensor";
                                        break;

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 4724, "\"", 4780, 5);
            WriteAttributeValue("", 4732, "card", 4732, 4, true);
            WriteAttributeValue(" ", 4736, "text-white", 4737, 11, true);
#nullable restore
#line 104 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue(" ", 4747, ViewData["TypeColor"], 4748, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4770, "mb-3", 4771, 5, true);
            WriteAttributeValue(" ", 4775, "mx-3", 4776, 5, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 15rem; min-width:13rem;\">\n                                ");
#nullable restore
#line 105 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                           Write(Html.Partial("_loader", "sensorLoader"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <div class=""card-header"">
                                    <div class=""d-flex bd-highlight align-items-center"">
                                        <div class=""mr-auto text-white bd-highlight"">
                                            <a class=""  align-middle text-white h-100"" href=""#"">
                                                ");
#nullable restore
#line 110 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                           Write(ViewData["devicesType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <div class=""dropdown  bd-highlight"">

                                            <button role=""button"" class=""btn  float-right mt-1 ml-2"" type=""button"" id=""dropdownMenuButton0"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a141a150044d46d2488a2958899e2a472b52e9119419", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5757, "width:", 5757, 6, true);
            AddHtmlAttributeValue(" ", 5763, "16px;", 5764, 6, true);
#nullable restore
#line 116 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
AddHtmlAttributeValue("", 5769, ViewData["backimg"], 5769, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            </button>\n                                            <div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuButton0\">\n                                                <a href=\"#\" class=\"btn text-success mx-2\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6079, "\"", 6125, 3);
            WriteAttributeValue("", 6089, "EditSensors(\'", 6089, 13, true);
#nullable restore
#line 119 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue("", 6102, sensorModel.sensorId, 6102, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6123, "\')", 6123, 2, true);
            EndWriteAttribute();
            WriteLiteral(">edit </a>\n\n                                                <a href=\"#\" class=\"btn text-danger mx-2\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6226, "\"", 6272, 3);
            WriteAttributeValue("", 6236, "DropSensors(\'", 6236, 13, true);
#nullable restore
#line 121 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue("", 6249, sensorModel.sensorId, 6249, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6270, "\')", 6270, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">Delete </a>
                                            </div>
                                        </div>
                                    </div>


                                </div>
                                <div class=""card-body"">
                                    <p class=""ard-text p-0 m-0""><b>");
#nullable restore
#line 129 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                                              Write(sensorModel.roomId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 129 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                                                                  Write(sensorModel.sensorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n                                    <input id=\"dropSensorID\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6715, "\"", 6744, 1);
#nullable restore
#line 130 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue("", 6723, sensorModel.sensorId, 6723, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                                    <h4 class=\"card-title\" style=\"margin-top:5px\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a141a150044d46d2488a2958899e2a472b52e9124302", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6882, "~/img/icon/", 6882, 11, true);
#nullable restore
#line 132 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
AddHtmlAttributeValue("", 6893, sensorModel.typeImg, 6893, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        ");
#nullable restore
#line 133 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                   Write(sensorModel.current_Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 133 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                                              Write(sensorModel.typeUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </h4>\n                                    <a");
            BeginWriteAttribute("class", " class=\"", 7097, "\"", 7140, 4);
            WriteAttributeValue("", 7105, "shadow", 7105, 6, true);
            WriteAttributeValue(" ", 7111, "badge", 7112, 6, true);
            WriteAttributeValue(" ", 7117, "badge-pill", 7118, 11, true);
#nullable restore
#line 135 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
WriteAttributeValue("  ", 7128, turnOFClr, 7130, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:-2px; margin-top:2px font-size: 14px\" href=\"#\">");
#nullable restore
#line 135 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                                                                                                                                Write(turnOFstr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    <p class=\"card-text my-1\" style=\"font-size:12px\">\n");
#nullable restore
#line 137 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                         if (sensorModel.current_Time != DateTime.MinValue)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <b style=\"font-size:14px\">");
#nullable restore
#line 139 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                                                 Write(sensorModel.latest_checking_time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n");
#nullable restore
#line 140 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <b> N/A </b>\n");
#nullable restore
#line 144 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </p>\n                                </div>\n                            </div>\n");
#nullable restore
#line 148 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 155 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "/Users/shingwaichan/Desktop/INB/Intelligent-Energy-Management-System-for-Buildings-INB/FYP_WEB_APP/Views/Shared/_SensorsList.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<script>

    var EditSensors = function (sensorId) {

        var url = ""/Sensors/EditSensors/"" + sensorId;

        $(""#EditSensorsBody"").load(url, function () {
            $(""#EditSensors"").modal(""show"");

        })

    }
    var DropSensors = function (sensorId) {

        var url = ""/Sensors/DropSensors/"" + sensorId;

        $(""#EditSensorsBody"").load(url, function () {
            $(""#EditSensors"").modal(""show"");
        })

    }
    var AddtSensors = function () {

        var url = ""/Sensors/AddSensors"";

        $(""#EditSensorsBody"").load(url, function () {
            $(""#EditSensors"").modal(""show"");

        })

    }
    var AddtSensors = function (roomid) {

        var url = ""/Sensors/AddSensors/"" + roomid;

        $(""#EditSensorsBody"").load(url, function () {
            $(""#EditSensors"").modal(""show"");

        })

    }
</script>");
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
