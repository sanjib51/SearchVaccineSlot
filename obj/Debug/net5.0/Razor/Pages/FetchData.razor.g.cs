#pragma checksum "D:\Workspace\AvailableVaccine\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8749bf876590cc087d346baf738f2a4f8e2ea2d"
// <auto-generated/>
#pragma warning disable 1591
namespace AvailableVaccine.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Workspace\AvailableVaccine\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\AvailableVaccine\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\AvailableVaccine\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Workspace\AvailableVaccine\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Workspace\AvailableVaccine\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Workspace\AvailableVaccine\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Workspace\AvailableVaccine\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Workspace\AvailableVaccine\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Workspace\AvailableVaccine\_Imports.razor"
using AvailableVaccine;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Workspace\AvailableVaccine\_Imports.razor"
using AvailableVaccine.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Vaction Doses availability</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "image");
            __builder.AddAttribute(3, "src", "/img/Refresh_v1.png");
            __builder.AddAttribute(4, "alt", "Refresh");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                                                                       RefreshDose

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "id", "btnStart");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                                             StartRefresh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "value", "Start Auto refresh");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "id", "btnStop");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                                            StopRefresh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "value", "Stop Refresh");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "label");
            __builder.AddContent(20, " Last refresh time: ");
            __builder.AddContent(21, 
#nullable restore
#line 11 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                            localtime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table");
            __builder.AddMarkupContent(25, "<thead><tr><th>Name and address</th>\r\n                <th>available_capacity</th>\r\n                <th>date</th>\r\n                <th>available_capacity_dose1</th>\r\n                <th>available_capacity_dose2</th></tr></thead>\r\n        ");
            __builder.OpenElement(26, "tbody");
#nullable restore
#line 30 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
             foreach (var forecast in forecasts.centers)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                 foreach (var session in forecast.sessions)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 36 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                             forecast.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " : ");
            __builder.AddContent(31, 
#nullable restore
#line 36 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                                              forecast.address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 37 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                             session.available_capacity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 38 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                             session.date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 39 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                             session.available_capacity_dose1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 40 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                             session.available_capacity_dose2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
                 

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Workspace\AvailableVaccine\Pages\FetchData.razor"
       
    private Rootobject forecasts;
    private DateTime localtime;
    private System.Timers.Timer refreshTimer;

    protected override async Task OnInitializedAsync()
    {
        await RefreshDose();
    }

    public async Task RefreshDose()
    {
        // forecasts = new Rootobject();
        forecasts = await Http.GetFromJsonAsync<Rootobject>("https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/calendarByDistrict?district_id=725&date=30-05-2021");
        Rootobject vacdata= forecasts;

        var vailableDose = from Center center in vacdata.centers
                           from Session session in center.sessions
                           where (session.available_capacity > 0 || (session.available_capacity_dose1 > 0 || session.available_capacity_dose2 > 0))
                           select center;
        var center1 = vailableDose.ToArray();
        forecasts.centers = center1;
        localtime = DateTime.Now;
        StateHasChanged();
    }

    public void StartRefresh()
    {
        try
        {
            refreshTimer = new System.Timers.Timer(5000);
            refreshTimer.Elapsed += TimerCallback;
            refreshTimer.Enabled = true;
            refreshTimer.Start();

        }
        catch (Exception ex)
        {

        }


    }
    public void TimerCallback(Object source,System.Timers.ElapsedEventArgs e)
    {
        RefreshDose().Wait();       
    }
    public void StopRefresh()
    {
        refreshTimer.Stop();
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
