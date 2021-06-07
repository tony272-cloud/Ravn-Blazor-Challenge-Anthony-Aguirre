#pragma checksum "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonCell.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98646fb066ad12a59de272f77ac1d6a71359890b"
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
#nullable restore
#line 1 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonCell.razor"
using SwapiChallenge.Shared.Data;

#line default
#line hidden
#nullable disable
    public partial class PersonCell : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "person-cell");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonCell.razor"
                                   OnClickCallback

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\n\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "person-cell__content");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "person-cell__info");
            __builder.AddMarkupContent(9, "\n\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "h2");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.AddContent(13, 
#nullable restore
#line 8 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonCell.razor"
                 person.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "low-emphasis");
            __builder.AddMarkupContent(18, "\n              ");
            __builder.AddContent(19, 
#nullable restore
#line 11 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonCell.razor"
               formatSpecies()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " from  ");
            __builder.AddContent(21, 
#nullable restore
#line 11 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonCell.razor"
                                      person.homeworld.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n        ");
            __builder.AddMarkupContent(25, "<div class=\"person-cell__arrow\">\n            <span class=\"arrow-icon\"></span>\n        </div>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    <div class=\"person-cell__bottom-border\"></div>\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonCell.razor"
       
    [Parameter]
    public Person person { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

    protected string formatSpecies()
    {
        return String.Join(" , ", person.species.Select(s => s.name));
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
