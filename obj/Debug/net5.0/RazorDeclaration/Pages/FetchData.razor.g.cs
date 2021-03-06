// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AvailableVaccine.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using AvailableVaccine;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Workspace\SearchVaccineSlot\_Imports.razor"
using AvailableVaccine.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\SearchVaccineSlot\Pages\FetchData.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\Workspace\SearchVaccineSlot\Pages\FetchData.razor"
       
    private Rootobject forecasts;
    private DateTime localtime;
    private System.Timers.Timer refreshTimer;
    private double refreshTimeInterval = 30000;

    protected override async Task OnInitializedAsync()
    {
        await RefreshDose();
    }

    public async Task RefreshDose()
    {
        string toDay = DateTime.Today.ToString("dd-MM-yyyy");

        string URL = "https://cdn-api.co-vin.in/api/v2/appointment/sessions/public/calendarByDistrict?district_id=725&date="+toDay;
        forecasts = await Http.GetFromJsonAsync<Rootobject>(URL);
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
            refreshTimer = new System.Timers.Timer(refreshTimeInterval);
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
