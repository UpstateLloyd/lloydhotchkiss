#pragma checksum "/home/upstatelloyd/Projects/lloydhotchkiss/Pages/Calculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba49bf092c31fd800609502c2513245c9be37125"
// <auto-generated/>
#pragma warning disable 1591
namespace lloydhotchkiss.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using lloydhotchkiss;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/upstatelloyd/Projects/lloydhotchkiss/_Imports.razor"
using lloydhotchkiss.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculator")]
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""wrap""><div class=""calculator-grid""><div class=""output""><div data-previous-operand class=""previous-operand"">123</div>
            <div data-current-operand class=""current-operand"">123</div></div>                            
    
        
        <button data-all-clear class=""span-two"">AC</button>  
        <button data-delete>DEL</button>
        <button data-operation>/</button>
        <button data-number>1</button>
        <button data-number>2</button>
        <button data-number>3</button>
        <button data-operation>*</button>
        <button data-number>4</button>
        <button data-number>5</button>
        <button data-number>6</button>
        <button data-operation>+</button>
        <button data-number>7</button>
        <button data-number>8</button>
        <button data-number>9</button>
        <button data-operation>-</button>
        <button data-number>.</button>
        <button data-number>0</button>
        <button data-equals class=""span-two"">=</button></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
