#pragma checksum "D:\mobile app\Zadanie11\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eb706a2c0acb03ffa739e44d54fa3ff1d9f0973"
// <auto-generated/>
#pragma warning disable 1591
namespace Zadanie11.Pages
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
#line 5 "D:\mobile app\Zadanie11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

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
#line 2 "D:\mobile app\Zadanie11\Pages\Index.razor"
using MultiLanguageSupport.MLIndex;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-none d-md-block");
            __builder.OpenElement(2, "nav");
            __builder.AddAttribute(3, "class", "navbar navbar-expand-md py-0 navbar-light bg-light");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "class", "navbar-brand");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\mobile app\Zadanie11\Pages\Index.razor"
                                              HomeClick

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 20 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(9, MLIndex.appname);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            \r\n            \r\n            \r\n            \r\n            \r\n            \r\n            \r\n            ");
            __builder.AddMarkupContent(11, @"<button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Przełącznik nawigacyjny""><span class=""navbar-toggler-icon""></span></button>
            
            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "collapse navbar-collapse");
            __builder.AddAttribute(14, "id", "navbarSupportedContent");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "navbar-nav me-auto mb-2 mb-md-0");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "nav-link");
            __builder.AddAttribute(21, "aria-current", "Opcja 1");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\mobile app\Zadanie11\Pages\Index.razor"
                                                                             Option1Click

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 45 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(23, MLIndex.alarmclock);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "nav-link");
            __builder.AddAttribute(29, "aria-current", "Opcja 2");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\mobile app\Zadanie11\Pages\Index.razor"
                                                                             Option2Click

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 48 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(31, MLIndex.alarm);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "li");
            __builder.AddAttribute(34, "class", "nav-item");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "aria-current", "Opcja 3");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\mobile app\Zadanie11\Pages\Index.razor"
                                                                             Option3Click

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 51 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(39, MLIndex.stopwatch);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "hidden", 
#nullable restore
#line 58 "D:\mobile app\Zadanie11\Pages\Index.razor"
                  home

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(43, "h1");
#nullable restore
#line 59 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(44, MLIndex.appname);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    \r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "hidden", 
#nullable restore
#line 62 "D:\mobile app\Zadanie11\Pages\Index.razor"
                  option1

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(48, "h1");
#nullable restore
#line 63 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(49, MLIndex.alarmclock);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    \r\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "hidden", 
#nullable restore
#line 66 "D:\mobile app\Zadanie11\Pages\Index.razor"
                  option2

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(53, "h1");
#nullable restore
#line 67 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(54, MLIndex.alarm);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "hidden", 
#nullable restore
#line 69 "D:\mobile app\Zadanie11\Pages\Index.razor"
                  option3

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(58, "h1");
#nullable restore
#line 70 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(59, MLIndex.stopwatch);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    \r\n");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "d-none d-md-block d-lg-none");
            __builder.OpenElement(63, "p");
            __builder.AddAttribute(64, "hidden", 
#nullable restore
#line 116 "D:\mobile app\Zadanie11\Pages\Index.razor"
                textsize

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(65, "Program Stopwatch - tekst na średnie ekrany");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "d-none d-md-none d-lg-block");
            __builder.OpenElement(69, "p");
            __builder.AddAttribute(70, "hidden", 
#nullable restore
#line 119 "D:\mobile app\Zadanie11\Pages\Index.razor"
                textsize

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(71, " Program Stopwatch - tekst na duże ekrany");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "d-md-none");
            __builder.OpenElement(75, "nav");
            __builder.AddAttribute(76, "id", "navbarsm");
            __builder.AddAttribute(77, "class", "navbar navbar-light bg-light");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "container-fluid");
            __builder.OpenElement(80, "a");
            __builder.AddAttribute(81, "class", "navbar-brand");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 130 "D:\mobile app\Zadanie11\Pages\Index.razor"
                                              HomeClick

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 130 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(83, MLIndex.appname);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            \r\n            \r\n            \r\n            \r\n            \r\n            \r\n            \r\n            ");
            __builder.AddMarkupContent(85, @"<button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Przełącznik nawigacyjny""><span class=""navbar-toggler-icon""></span></button>
            
            ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "collapse navbar-collapse");
            __builder.AddAttribute(88, "id", "navbarSupportedContent");
            __builder.OpenElement(89, "ul");
            __builder.AddAttribute(90, "class", "navbar-nav me-auto mb-2 mb-md-0");
            __builder.OpenElement(91, "li");
            __builder.AddAttribute(92, "class", "nav-item");
            __builder.OpenElement(93, "a");
            __builder.AddAttribute(94, "class", "nav-link");
            __builder.AddAttribute(95, "aria-current", "Opcja 1");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 155 "D:\mobile app\Zadanie11\Pages\Index.razor"
                                                                             Option1Click

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 155 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(97, MLIndex.alarmclock);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.OpenElement(99, "li");
            __builder.AddAttribute(100, "class", "nav-item");
            __builder.OpenElement(101, "a");
            __builder.AddAttribute(102, "class", "nav-link");
            __builder.AddAttribute(103, "aria-current", "Opcja 2");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 158 "D:\mobile app\Zadanie11\Pages\Index.razor"
                                                                             Option2Click

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 158 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(105, MLIndex.alarm);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                    ");
            __builder.OpenElement(107, "li");
            __builder.AddAttribute(108, "class", "nav-item");
            __builder.OpenElement(109, "a");
            __builder.AddAttribute(110, "class", "nav-link");
            __builder.AddAttribute(111, "aria-current", "Opcja 3");
            __builder.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 161 "D:\mobile app\Zadanie11\Pages\Index.razor"
                                                                             Option3Click

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 161 "D:\mobile app\Zadanie11\Pages\Index.razor"
__builder.AddContent(113, MLIndex.stopwatch);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\r\n    \r\n    \r\n    \r\n    ");
            __builder.OpenElement(115, "p");
            __builder.AddAttribute(116, "hidden", 
#nullable restore
#line 171 "D:\mobile app\Zadanie11\Pages\Index.razor"
                textsize

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(117, "Program Stopwatch - tekst na małe ekrany");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "hidden", 
#nullable restore
#line 174 "D:\mobile app\Zadanie11\Pages\Index.razor"
              option1

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<Zadanie11.Pages.Alarmclock>(121);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "hidden", 
#nullable restore
#line 177 "D:\mobile app\Zadanie11\Pages\Index.razor"
              option2

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<Zadanie11.Pages.Alarm>(125);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "hidden", 
#nullable restore
#line 180 "D:\mobile app\Zadanie11\Pages\Index.razor"
              option3

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<Zadanie11.Pages.Stopwatch>(129);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "D:\mobile app\Zadanie11\Pages\Index.razor"
           
        private bool home = false;
        private bool option1 = true;
        private bool option2 = true;
        private bool option3 = true;
        private bool textsize = false;

        private void HomeClick()
        {
            home = false;
            option1 = true;
            option2 = true;
            option3 = true;
            textsize = false;
        }

        private void Option1Click()
        {
            home = true;
            option1 = false;
            option2 = true;
            option3 = true;
            textsize = true;
        }

        private void Option2Click()
        {
            home = true;
            option1 = true;
            option2 = false;
            option3 = true;
            textsize = true;
        }
        private void Option3Click()
        {
            home = true;
            option1 = true;
            option2 = true;
            option3 = false;
            textsize = true;
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
