#pragma checksum "E:\Medium\blazore\ToDoApp\ToDoApp\ToDoApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4dc0be14e681194c4bfc333163b840634eb38ca"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ToDoApp.Pages
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
    using ToDoApp.Data;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 9 "E:\Medium\blazore\ToDoApp\ToDoApp\ToDoApp\Pages\Index.razor"
            

    IList<ToDo> todos;

    protected override async Task OnInitAsync()
    {
        todos = await ToDoService.GetToDos();
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToDoService ToDoService { get; set; }
    }
}
#pragma warning restore 1591
