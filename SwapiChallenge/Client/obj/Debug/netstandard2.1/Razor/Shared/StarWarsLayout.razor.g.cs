#pragma checksum "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\StarWarsLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec3d3a9181eaa09dead5454188b96afc1bd28e2b"
// <auto-generated/>
#pragma warning disable 1591
namespace SwapiChallenge.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\_Imports.razor"
using SwapiChallenge.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\_Imports.razor"
using SwapiChallenge.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class StarWarsLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<header class=\"page-header\">\n    <div class=\"header-title\">\n        People of Star Wars Ravn Challenge\n    </div> \n</header>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page-content content");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 10 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\StarWarsLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
