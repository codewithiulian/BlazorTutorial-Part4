#pragma checksum "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a540986250aa81aa0d44d80b21a28802ad97af2d"
// <auto-generated/>
#pragma warning disable 1591
namespace RecipeManager.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\_Imports.razor"
using RecipeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\_Imports.razor"
using RecipeManager.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<RecipeManager.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 13 "D:\Projects\YouTube\Content\5. RecipeManager-4\Project\tutorial\RecipeManager-4\RecipeManager\RecipeManager\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
