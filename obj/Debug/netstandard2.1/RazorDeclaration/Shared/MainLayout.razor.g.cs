#pragma checksum "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7a81ae1ccddd1e90633116ab49c252a9728b972"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor_app_01.Shared
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using blazor_app_01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using blazor_app_01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Shared\MainLayout.razor"
 
    static bool Installable = false;
    static Action OnInstallable;
    protected override void OnInitialized()
    {
        OnInstallable = () => InvokeAsync(StateHasChanged);
    }
    [JSInvokable]
    public static Task PWAInstallable()
    {
        Installable = true;
        OnInstallable.Invoke();
        return Task.CompletedTask;
    }
    ValueTask InstallClicked()
    {
        Installable = false;
        return JSRuntime.InvokeVoidAsync("BlazorPWA.installPWA");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
