#pragma checksum "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\Dapper\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b57f9bf43d011718d34a03b61332ec22beb6a743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dapper_Read), @"mvc.1.0.view", @"/Views/Dapper/Read.cshtml")]
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
#line 1 "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\_ViewImports.cshtml"
using DapperApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\_ViewImports.cshtml"
using DapperApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b57f9bf43d011718d34a03b61332ec22beb6a743", @"/Views/Dapper/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8475147586b487b10b0a73bf2ff694758bbb3440", @"/Views/_ViewImports.cshtml")]
    public class Views_Dapper_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\Dapper\Read.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .height-30 {
        height: 30px;
    }

    .height-60 {
        height: 60px;
        vertical-align: middle;
    }

    .box {
        margin: 5px;
    }
</style>
<div class=""text-center"">
    <h1 class=""display-4"">Welcome Dapper Bulk Insert</h1>
    <p>Insert Amount of Data you want to insert.</p>
</div>
");
#nullable restore
#line 22 "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\Dapper\Read.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row text-center"">
        <div class=""col-md-4 offset-md-4"">
            <input type=""number"" class=""form-control"" name=""insertQty"" />
        </div>
        <div class=""col-md-4 offset-md-4"" style=""margin-top:5px"">
            <button type=""submit"" class=""btn btn-primary"">Insert</button>
        </div>
    </div>
");
#nullable restore
#line 32 "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\Dapper\Read.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 34 "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\Dapper\Read.cshtml"
  
    if (ViewBag.ExecutionTime != null)
    {
        TimeSpan executeTime = ViewBag.ExecutionTime;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row text-center\">\r\n\r\n            Total Time Take to execute (In Milliseconds) : ");
#nullable restore
#line 40 "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\Dapper\Read.cshtml"
                                                      Write(executeTime.Milliseconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            Total Time Take to execute (In Seconds): ");
#nullable restore
#line 41 "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\Dapper\Read.cshtml"
                                                Write(executeTime.Seconds);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        </div>\r\n");
#nullable restore
#line 43 "H:\Git\Project\DapperApp\DapperApp\DapperApp\DapperApp\Views\Dapper\Read.cshtml"
    }

#line default
#line hidden
#nullable disable
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
