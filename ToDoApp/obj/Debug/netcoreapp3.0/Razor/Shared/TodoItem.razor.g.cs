#pragma checksum "E:\Medium\blazore\ToDoApp\ToDoApp\ToDoApp\Shared\TodoItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2f4682f9bc5ef817c45de1c3c47aa2bc75b475"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDoApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using ToDoApp.Shared;
    public class TodoItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "tr");
            builder.AddMarkupContent(1, "\n    ");
            builder.OpenElement(2, "td");
            builder.AddAttribute(3, "class", "text-center");
            builder.OpenElement(4, "input");
            builder.AddAttribute(5, "type", "checkbox");
            builder.AddAttribute(6, "checked", Microsoft.AspNetCore.Components.BindMethods.GetValue(Done));
            builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Done = __value, Done));
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(8, "\n    ");
            builder.OpenElement(9, "td");
            builder.AddContent(10, Text);
            builder.CloseElement();
            builder.AddMarkupContent(11, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 6 "E:\Medium\blazore\ToDoApp\ToDoApp\ToDoApp\Shared\TodoItem.razor"
            
    [Parameter]
    string Text { get; set; }
    [Parameter]
    bool Done { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
