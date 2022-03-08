#pragma checksum "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fce4c486faf4c806403a69c5387af9fb2704aa5"
// <auto-generated/>
#pragma warning disable 1591
namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    public partial class ShoppingCartTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Shopping Cart Table</h3>\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-striped table bordered");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "thead");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\n            ");
            __builder.OpenElement(8, "th");
            __builder.AddAttribute(9, "colspan", "5");
            __builder.AddAttribute(10, "class", "text-center");
            __builder.AddContent(11, 
#nullable restore
#line 5 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n    ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\n");
#nullable restore
#line 10 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
         if (Shoppings?.Count()>0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                 foreach (Shopping s in Shoppings)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                    ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\n                        ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "mark");
            __builder.AddContent(22, 
#nullable restore
#line 15 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                                   s.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                        ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "abbr");
            __builder.AddAttribute(26, "title", "attribute");
            __builder.AddContent(27, 
#nullable restore
#line 16 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                                                     s.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.AddMarkupContent(29, "<td><mark>Books</mark></td>\n                        ");
            __builder.AddMarkupContent(30, "<td><mark>Quantity</mark></td>\n\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddMarkupContent(32, "\n                            ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                                                                              x => ShoppingCartSelected.InvokeAsync(s.ShoppingId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\n                                ");
            __builder.AddContent(37, 
#nullable restore
#line 22 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                                 ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n");
#nullable restore
#line 27 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                     foreach (BasketLineItem bli in s.Lines)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                        ");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "\n                            <td colspan=\"2\"></td>\n                            ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 31 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                                 bli.Books.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                            ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 32 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                                 bli.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n");
#nullable restore
#line 34 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                ");
            __builder.AddMarkupContent(53, "<tr>\n                    <td colspan=\"5\" class=\"text-center\"></td>\n                </tr>\n");
#nullable restore
#line 42 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/ShoppingCartTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Shoppings";

    [Parameter]
    public IEnumerable<Shopping> Shoppings { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";

    [Parameter]
    public EventCallback<int> ShoppingCartSelected { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
