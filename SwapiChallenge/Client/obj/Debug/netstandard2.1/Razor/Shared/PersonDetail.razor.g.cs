#pragma checksum "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2869c9cfe39d2250be11061d4373a34e4c366329"
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
#line 1 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
using SwapiChallenge.Shared.Data;

#line default
#line hidden
#nullable disable
    public partial class PersonDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "person-detail__wrapper");
            __builder.AddMarkupContent(2, "\n\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "person-detail__content");
            __builder.AddMarkupContent(5, "\n\n        ");
            __builder.OpenElement(6, "header");
            __builder.AddAttribute(7, "class", "page-header");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "header-title");
            __builder.AddMarkupContent(11, "\n                ");
            __builder.AddContent(12, 
#nullable restore
#line 8 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
                 person.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.AddMarkupContent(16, "<div class=\"h2 person-detail__section-title\">\n            General Information\n\n        </div>\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "person-detail__info");
            __builder.AddMarkupContent(19, "\n\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "info-item");
            __builder.AddMarkupContent(22, "\n                ");
            __builder.AddMarkupContent(23, "<div class=\"h2 low-emphasis\">\n                    Height\n                </div>\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "low-emphasis");
            __builder.AddMarkupContent(26, "\n                    ");
            __builder.AddContent(27, 
#nullable restore
#line 22 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
                     person.height

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "info-item");
            __builder.AddMarkupContent(33, "\n                ");
            __builder.AddMarkupContent(34, "<div class=\"h2 low-emphasis\">\n                    Eye Color\n                </div>\n                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "low-emphasis");
            __builder.AddMarkupContent(37, "\n                    ");
            __builder.AddContent(38, 
#nullable restore
#line 31 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
                     person.eye_color

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "info-item");
            __builder.AddMarkupContent(44, "\n                ");
            __builder.AddMarkupContent(45, "<div class=\"h2 low-emphasis\">\n                    Hair Color\n                </div>\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "low-emphasis");
            __builder.AddMarkupContent(48, "\n                    ");
            __builder.AddContent(49, 
#nullable restore
#line 40 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
                     person.hair_color

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "info-item");
            __builder.AddMarkupContent(55, "\n                ");
            __builder.AddMarkupContent(56, "<div class=\"h2 low-emphasis\">\n                    Skin Color\n                </div>\n                ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "low-emphasis");
            __builder.AddMarkupContent(59, "\n                    ");
            __builder.AddContent(60, 
#nullable restore
#line 48 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
                     person.skin_color

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(61, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "info-item");
            __builder.AddMarkupContent(66, "\n                ");
            __builder.AddMarkupContent(67, "<div class=\"h2 low-emphasis\">\n                    Birth Year\n                </div>\n                ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "low-emphasis");
            __builder.AddMarkupContent(70, "\n                    ");
            __builder.AddContent(71, 
#nullable restore
#line 56 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
                     person.birth_year

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(72, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n        ");
            __builder.AddMarkupContent(76, "<div class=\"h2 person-detail__section-title\">\n            Vehicles\n        </div>\n        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "person-detail__info");
            __builder.AddMarkupContent(79, "\n\n");
#nullable restore
#line 66 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
             foreach (var vehicle in person.vehicles)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "            ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "h2 low-emphasis");
            __builder.AddMarkupContent(83, "\n                ");
            __builder.AddContent(84, 
#nullable restore
#line 69 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
                 vehicle.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(85, "\n            ");
            __builder.CloseElement();
#nullable restore
#line 70 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
                  }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(86, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "D:\Proyectos\RavnBlazor\SwapiChallenge\Client\Shared\PersonDetail.razor"
       
    [Parameter]
    public Person person { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
