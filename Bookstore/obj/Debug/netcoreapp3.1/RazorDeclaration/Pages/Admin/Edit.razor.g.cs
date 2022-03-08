// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/book/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/book/create")]
    public partial class Edit : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "/Users/seungeunlee/Projects/mission9/Bookstore/Pages/Admin/Edit.razor"
               
            [Parameter]
            public long Id { get; set; } = 0;

            public string ThemeColor => Id == 0 ? "primary" : "warning";
            public string TitleText => Id == 0 ? "Create" : "Edit";

            public Books b { get; set; } = new Books();

            public IBookstoreRepository repo => Service;

            protected override void OnParametersSet()
            {
                if (Id != 0) //Existing Book
                {
                    b = repo.Books.FirstOrDefault(x => x.BookId == Id);
                }
            }
            public void SaveBooks()
            {
                if (Id == 0) //New Book
                {
                    repo.CreateBooks(b);
                }
                else
                {
                    repo.SaveBooks(b);
                }
                NavManager.NavigateTo("/admin/book");
            }
            [Inject]
            public NavigationManager NavManager { get; set; }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
