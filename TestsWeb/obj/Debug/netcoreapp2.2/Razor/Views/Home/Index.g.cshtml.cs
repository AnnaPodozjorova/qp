#pragma checksum "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "277bc84c48b850b28113f2a916e0d9c04cce0826"
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
#line 1 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\_ViewImports.cshtml"
using TestsWeb;

#line default
#line hidden
#line 2 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\_ViewImports.cshtml"
using TestsWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"277bc84c48b850b28113f2a916e0d9c04cce0826", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e4b01f94e7470dae47a50848dc5e8e82da58503", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestProject.Domain.Entities.Quiz>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(101, 1101, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Quizz</h1>
    


    <div class=""container-fluid text-center"">
        <div class=""row content"">
            <div class=""col-sm-2 sidenav"">
            </div>
            <div class=""col-sm-8 text-center"">
                <h2>Why should you do quizz?</h2>
                <p>In the world of education there are many different ways to teach and to consolidate what has been learned. In years gone by, children were expected to memorise dates, formulae and figures by rote. But this method of teaching can be quite dull, to say the least! One tool becoming more common, especially in online education, is quizzes. In this guide we’ll find out the many reasons why quizzes are valuable in learning.</p>
                <hr>
                <h3><a href=""Home/Test""><button type=""button"" class=""btn btn-primary btn-lg btn-block"">Begin the test!</button></a></h3>
            </div>
            <div class=""col-sm-2 sidenav"">
            </div>
        </div");
            WriteLiteral(">\r\n    </div>\r\n\r\n    <table class=\"table table-striped\">\r\n\r\n        <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml"
             using (Html.BeginForm())
            {

#line default
#line hidden
            BeginContext(1256, 41, true);
            WriteLiteral("                <p>\r\n                    ");
            EndContext();
            BeginContext(1298, 84, false);
#line 33 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Sort by: Title", "Index", new { sortOrder = ViewBag.NameSortParm }));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 24, true);
            WriteLiteral("\r\n                </p>\r\n");
            EndContext();
            BeginContext(1408, 57, true);
            WriteLiteral("                <p>\r\n\r\n                    Find by name: ");
            EndContext();
            BeginContext(1466, 28, false);
#line 38 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml"
                             Write(Html.TextBox("SearchString"));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 84, true);
            WriteLiteral("\r\n                    <input type=\"submit\" value=\"Search\" />\r\n                </p>\r\n");
            EndContext();
#line 41 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1593, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml"
             foreach (var a in ViewBag.Quizs)
            {

#line default
#line hidden
            BeginContext(1657, 48, true);
            WriteLiteral("                <tr>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1705, "\"", 1731, 2);
            WriteAttributeValue("", 1712, "Home/Test/", 1712, 10, true);
#line 46 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 1722, a.QuizId, 1722, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1732, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1735, 12, false);
#line 46 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml"
                                                  Write($"{a.Title}");

#line default
#line hidden
            EndContext();
            BeginContext(1748, 34, true);
            WriteLiteral("</a></td>\r\n                </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Mackaby\source\repos\qp3\TestsWeb\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1797, 141, true);
            WriteLiteral("            <footer class=\"container-fluid text-center\">\r\n        <p>Footer Text</p>\r\n    </footer>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestProject.Domain.Entities.Quiz>> Html { get; private set; }
    }
}
#pragma warning restore 1591
