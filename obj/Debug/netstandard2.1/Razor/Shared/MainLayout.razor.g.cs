#pragma checksum "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7a81ae1ccddd1e90633116ab49c252a9728b972"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 4 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Shared\MainLayout.razor"
 if (Installable)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "install-prompt col-sm-8 col-sm-offset-2 col-lg-6 col-lg-offset-3");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.AddMarkupContent(7, "<span>Install app?</span>\r\n            ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "installButton btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Shared\MainLayout.razor"
                                                                      () => InstallClicked()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "cancelButton btn btn-danger");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Shared\MainLayout.razor"
                                                                    ()=>Installable=false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "No");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 13 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Shared\MainLayout.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "sidebar");
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenComponent<blazor_app_01.Shared.NavMenu>(24);
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "main");
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.AddMarkupContent(30, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "content px-4");
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.AddContent(34, 
#nullable restore
#line 25 "C:\Users\TTaylor\TP Training Code and Stuff\Python and Other stuff\blazor-app-01\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
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
