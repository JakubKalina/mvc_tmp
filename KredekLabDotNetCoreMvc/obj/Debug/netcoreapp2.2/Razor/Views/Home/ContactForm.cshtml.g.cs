#pragma checksum "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454da7ee6094d4f785f54be758c76f92742e3a94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactForm), @"mvc.1.0.view", @"/Views/Home/ContactForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactForm.cshtml", typeof(AspNetCore.Views_Home_ContactForm))]
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
#line 1 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\_ViewImports.cshtml"
using KredekLabDotNetCoreMvc;

#line default
#line hidden
#line 2 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\_ViewImports.cshtml"
using KredekLabDotNetCoreMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454da7ee6094d4f785f54be758c76f92742e3a94", @"/Views/Home/ContactForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44cba92a75c7eb19e18e6dc7d3daec18efb20291", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KredekLabDotNetCoreMvc.Models.ContactFormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
  
    ViewData["Title"] = "ContactForm";

#line default
#line hidden
            BeginContext(49, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
  
    ViewBag.Title = "Exercise5";

#line default
#line hidden
            BeginContext(155, 31, true);
            WriteLiteral("\r\n<!--Formularz kontaktowy-->\r\n");
            EndContext();
#line 14 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
 using (Html.BeginForm("ContactForm", "Home", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(259, 23, false);
#line 16 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(286, 148, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>ContactForm</h4>\r\n        <hr />\r\n        <!--Imię-->\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(435, 98, false);
#line 23 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(533, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(589, 98, false);
#line 25 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(687, 109, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!--Nazwisko-->\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(797, 97, false);
#line 30 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(894, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(950, 97, false);
#line 32 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 105, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!--Opis-->\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1153, 100, false);
#line 37 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1309, 100, false);
#line 39 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 255, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-success\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 49 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
}

#line default
#line hidden
            BeginContext(1667, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1681, 40, false);
#line 52 "E:\Jakub\Documents\Programowanie\Kredek\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\KredekLabDotNetCoreMvc\Views\Home\ContactForm.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KredekLabDotNetCoreMvc.Models.ContactFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
