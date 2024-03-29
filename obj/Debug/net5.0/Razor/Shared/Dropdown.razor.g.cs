#pragma checksum "D:\mobile app\Zadanie11\Shared\Dropdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f64eb361076bd091c3da644c830caa7c0f71461"
// <auto-generated/>
#pragma warning disable 1591
namespace Zadanie11.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\mobile app\Zadanie11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\mobile app\Zadanie11\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\mobile app\Zadanie11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\mobile app\Zadanie11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\mobile app\Zadanie11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\mobile app\Zadanie11\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\mobile app\Zadanie11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\mobile app\Zadanie11\_Imports.razor"
using Zadanie11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\mobile app\Zadanie11\_Imports.razor"
using Zadanie11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\mobile app\Zadanie11\Shared\Dropdown.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class Dropdown<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dropdown");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary dropdown-toggle mr-4");
            __builder.AddAttribute(4, "data-toggle", "dropdown");
            __builder.AddAttribute(5, "type", "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "D:\mobile app\Zadanie11\Shared\Dropdown.razor"
                                                                                                        e => this.show=!this.show 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "aria-haspopup", "true");
            __builder.AddAttribute(8, "aria-expanded", "false");
#nullable restore
#line 6 "D:\mobile app\Zadanie11\Shared\Dropdown.razor"
__builder.AddContent(9, Tip);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __Blazor.Zadanie11.Shared.Dropdown.TypeInference.CreateCascadingValue_0(__builder, 11, 12, "Dropdown", 13, 
#nullable restore
#line 8 "D:\mobile app\Zadanie11\Shared\Dropdown.razor"
                                            this

#line default
#line hidden
#nullable disable
            , 14, (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "dropdown-menu" + " " + (
#nullable restore
#line 9 "D:\mobile app\Zadanie11\Shared\Dropdown.razor"
                                    show? "show":""

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 10 "D:\mobile app\Zadanie11\Shared\Dropdown.razor"
__builder2.AddContent(17, ChildContent);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\mobile app\Zadanie11\Shared\Dropdown.razor"
       
    [Parameter]
    public RenderFragment InitialTip { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public EventCallback<TItem> OnSelected { get; set; }

    private bool show = false;
    private RenderFragment Tip;

    protected override void OnInitialized() { this.Tip = InitialTip; }
    public async Task HandleSelect(TItem item, RenderFragment<TItem> contentFragment)
    {
        this.Tip = contentFragment.Invoke(item);
        this.show = false;
        StateHasChanged();
        await this.OnSelected.InvokeAsync(item);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Zadanie11.Shared.Dropdown
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
