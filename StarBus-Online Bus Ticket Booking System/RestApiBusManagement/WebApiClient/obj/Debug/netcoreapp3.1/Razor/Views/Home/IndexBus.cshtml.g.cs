#pragma checksum "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "738a46d58d84c1f96d08fff35d26f1bc9f4ec0a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexBus), @"mvc.1.0.view", @"/Views/Home/IndexBus.cshtml")]
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
#line 1 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\_ViewImports.cshtml"
using WebApiClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\_ViewImports.cshtml"
using WebApiClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738a46d58d84c1f96d08fff35d26f1bc9f4ec0a9", @"/Views/Home/IndexBus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b507adef0d358b50ed88e34872440ba3e537b3d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexBus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApiClient.Models.Bus>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
  
    ViewData["Title"] = "IndexBus";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<center>\r\n    <h4>Available Buses</h4>\r\n</center>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
           Write(Html.DisplayNameFor(model => model.source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
           Write(Html.DisplayNameFor(model => model.destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
           Write(Html.DisplayNameFor(model => model.dept_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
           Write(Html.DisplayNameFor(model => model.arrival_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
           Write(Html.DisplayNameFor(model => model.bus_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
               Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
               Write(Html.DisplayFor(modelItem => item.source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
               Write(Html.DisplayFor(modelItem => item.destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
               Write(Html.DisplayFor(modelItem => item.dept_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
               Write(Html.DisplayFor(modelItem => item.arrival_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
               Write(Html.DisplayFor(modelItem => item.bus_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
               Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 66 "C:\Users\LENOVO\source\repos\RestApiBusManagement\WebApiClient\Views\Home\IndexBus.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApiClient.Models.Bus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
