#pragma checksum "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "658f2db04eb1463c9051fea79595d89448064c48"
// <auto-generated/>
#pragma warning disable 1591
namespace HobbyWebsite.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using HobbyWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using HobbyWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<global::MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<global::MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <div class=\"header-info\">\r\n            <div class=\"header-info_title\">Scorecard</div>\r\n            <div class=\"header-info_subtitle\">Azure Static Web App by Hans Voll</div>\r\n        </div>\r\n    </div>\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "px-2");
            __builder.AddMarkupContent(12, "\r\n        ");
#nullable restore
#line 14 "C:\Users\hvoll\source\repos\Azure\HobbyWebsite\HobbyWebsite\Shared\MainLayout.razor"
__builder.AddContent(13, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
