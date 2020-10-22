#pragma checksum "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d91e812fb6841e738039b1c15994887ac60b4df1"
// <auto-generated/>
#pragma warning disable 1591
namespace RemoteLabBlazerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\_Imports.razor"
using RemoteLabBlazerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\_Imports.razor"
using RemoteLabBlazerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
using DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
using RemoteLabBlazerApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Computer")]
    public partial class Computer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Get a computer</h4>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
                                          OnButtonPress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h4>Your computer:</h4>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
 if (computers is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 18 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
}

else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-striped");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<thead>\r\n            <tr>\r\n                <th>Computer</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 29 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
         if (buttonPress == 1)
        {
            if (selectedComputer is null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "              ");
            __builder.AddMarkupContent(17, "<tr>\r\n                <td>No computers are avaliable</td>\r\n            </tr>   \r\n");
#nullable restore
#line 36 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "            ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 40 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
                     selectedComputer.FQDN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 42 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "            ");
            __builder.AddMarkupContent(26, "<tr>\r\n                <td>Press the Button</td>\r\n            </tr>  \r\n");
#nullable restore
#line 49 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 52 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\NiCrutch\source\repos\RemoteLabBlazerApp\RemoteLabBlazerApp\Pages\Computer.razor"
       
    private List<ComputerModel> computers;

    private int buttonPress = 0;

    private ComputerModel selectedComputer;


    protected override async Task OnInitializedAsync()
    {
        computers = await _db.GetComputer();
    }


    private async Task OnButtonPress()
    {
        foreach (var computer in computers)
        {
            if (computer.RDPStatus == "Free")
            {
                selectedComputer = computer;
                selectedComputer.RDPStatus = "Occupied";

                await _db.UpdateComputer(selectedComputer);

                await OnInitializedAsync();

                break;
            }
        }
        buttonPress = 1;

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IComputerData _db { get; set; }
    }
}
#pragma warning restore 1591
