#pragma checksum "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b04210820dc0147c66402dc247560639753b0c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Test.cshtml", typeof(AspNetCore.Views_Home_Test))]
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
#line 1 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\_ViewImports.cshtml"
using TestsWeb;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\_ViewImports.cshtml"
using TestsWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b04210820dc0147c66402dc247560639753b0c24", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e4b01f94e7470dae47a50848dc5e8e82da58503", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
  
    ViewData["Title"] = "Home page";
    int count = 1, countR = 0;

#line default
#line hidden
            BeginContext(79, 127, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n\r\n        <h4 style=\"margin-top: 4%;\"> <span class=\"label label-info\">Questions :</span> </h4>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
             foreach (var q in ViewBag.Questions)
            {

#line default
#line hidden
            BeginContext(272, 290, true);
            WriteLiteral(@"                <div class=""BlockQ"" style=""border: 1px solid #bdbdbd; width: 75%; border-radius: 4px; margin-top: 40px; background-color: #f0ffff; padding: 8px;"">

                    <div class=""Question"" style=""padding: 2%;"">
                        <span class=""label label-warning""> ");
            EndContext();
            BeginContext(563, 36, false);
#line 17 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
                                                      Write(string.Format("{0}{1}.", "Q", count));

#line default
#line hidden
            EndContext();
            BeginContext(599, 38, true);
            WriteLiteral("</span>\r\n                        <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 637, "\"", 681, 1);
#line 18 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
WriteAttributeValue("", 642, string.Format("{0}{1}", "ID_Q", count), 642, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 23, true);
            WriteLiteral(" style=\"display:none;\">");
            EndContext();
            BeginContext(706, 12, false);
#line 18 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
                                                                                            Write(q.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(718, 73, true);
            WriteLiteral("</span>\r\n                        <p style=\"display: inline; padding: 2%;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 791, "\"", 832, 1);
#line 19 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
WriteAttributeValue("", 796, string.Format("{0}{1}", "Q", count), 796, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(833, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(835, 7, false);
#line 19 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
                                                                                                      Write(q.Title);

#line default
#line hidden
            EndContext();
            BeginContext(842, 106, true);
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div class=\"Choices\" style=\"margin-left: 8%;\">\r\n\r\n");
            EndContext();
#line 24 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
                         foreach (var c in q.Answers)
                        {

#line default
#line hidden
            BeginContext(1030, 109, true);
            WriteLiteral("                            <label class=\"radio-inline\">\r\n                                <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1139, "\"", 1198, 1);
#line 27 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
WriteAttributeValue("", 1146, string.Format("{0}{1}", "inlineRadioOptions",count), 1146, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1199, "\"", 1251, 1);
#line 27 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
WriteAttributeValue("", 1204, string.Format("{0}{1}", "inlineRadio", countR), 1204, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1252, "\"", 1268, 1);
#line 27 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
WriteAttributeValue("", 1260, c.Title, 1260, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1269, 30, true);
            WriteLiteral(" style=\"margin-left: -16px;\"> ");
            EndContext();
            BeginContext(1300, 7, false);
#line 27 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
                                                                                                                                                                                                              Write(c.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1307, 46, true);
            WriteLiteral("\r\n                            </label><br />\r\n");
            EndContext();
#line 29 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
                            countR++;
                        }

#line default
#line hidden
            BeginContext(1419, 75, true);
            WriteLiteral("\r\n                    </div> <!--END Choices-->\r\n\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1494, "\"", 1544, 1);
#line 34 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
WriteAttributeValue("", 1499, string.Format("{0}{1}{2}", "Ans","Q", count), 1499, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1545, 81, true);
            WriteLiteral(">\r\n\r\n\r\n                    </div>\r\n\r\n                </div> <!-- END BlockQ -->\r\n");
            EndContext();
#line 40 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
                count++;
            }

#line default
#line hidden
            BeginContext(1667, 60, true);
            WriteLiteral("            <span id=\"countQuections\" style=\"display:none;\">");
            EndContext();
            BeginContext(1728, 5, false);
#line 42 "C:\Users\User\Desktop\TestProject\TestsWeb\Views\Home\Test.cshtml"
                                                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1733, 216, true);
            WriteLiteral("</span>\r\n            <button type=\"button\" id=\"SubmitQuiz\" class=\"btn btn-default\" style=\"margin-top: 10px;\"><span class=\"glyphicon glyphicon-ok\"></span>   Submit Quiz </button>\r\n\r\n\r\n\r\n</div> <!-- END CONTAINER -->\r\n");
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
