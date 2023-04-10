#pragma checksum "C:\Users\Student\OneDrive\Работен плот\Diplomen-proekt\Motorex\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f524c276e097f9432bb1c647eb11a268c9dd20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Student\OneDrive\Работен плот\Diplomen-proekt\Motorex\Views\_ViewImports.cshtml"
using Motorex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\OneDrive\Работен плот\Diplomen-proekt\Motorex\Views\_ViewImports.cshtml"
using Motorex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f524c276e097f9432bb1c647eb11a268c9dd20", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67637ce6d81cee7ab1face473092279c8cfe459b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2f524c276e097f9432bb1c647eb11a268c9dd203248", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>My Bootstrap Home Page</title>
    <!-- Link to Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2f524c276e097f9432bb1c647eb11a268c9dd204512", async() => {
                WriteLiteral(@"
    <!-- Navbar -->
    <nav class=""navbar navbar-expand-md bg-dark navbar-dark"">
        <a class=""navbar-brand"" href=""https://t4.ftcdn.net/jpg/04/84/78/85/360_F_484788506_7GScMKPVlR6Vt6YODBLPWNjCf13PWn1c.jpg"">Logo</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#collapsibleNavbar"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""collapsibleNavbar"">
            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-item active"">
                    <a class=""nav-link"">Home</a>
                </li>
            </ul>
        </div>
    </nav>

    <!-- Hero Section -->
    <header class=""jumbotron text-center"">
        <h1>Welcome to Motorex</h1>
        <p>This is a site with quality</p>
        <a href=""https://localhost:44366/Identity/Account/Login"" class=""btn btn-primary"">Get Started</a>
    </header>

    <!-- Main Content Section -->
    <section class=""");
                WriteLiteral(@"container mt-4"">
        <h2>Featured Products</h2>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Motorcycles</h5>
                        <p class=""card-text"">Take a look at our new fresh motorcycles and take one for yourself</p>
                        <a href=""https://localhost:44366/Motor"" class=""btn btn-primary"">Learn More</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Equipment</h5>
                        <p class=""card-text"">Rule number 1 Buy safe, take a look at our equipment and buy 1 for yourself</p>
                        <a href=""https://localhost:44366/Motor?SearchStringBrandName=&SearchStringCategoryName=Dresses"" class=""btn btn-primary"">Learn More</a>
  ");
                WriteLiteral(@"                  </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Registration</h5>
                        <p class=""card-text"">You liked something? Go and order it when you make a registration</p>
                        <a href=""https://localhost:44366/Identity/Account/Register"" class=""btn btn-primary"">Learn More</a>
                    </div>
                </div>
            </div>
        </div>
    </section>

  
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
