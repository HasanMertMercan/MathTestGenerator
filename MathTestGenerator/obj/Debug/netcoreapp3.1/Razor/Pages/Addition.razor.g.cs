#pragma checksum "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b73b34d173b2b9996918214a44edab1438ea4dd"
// <auto-generated/>
#pragma warning disable 1591
namespace MathTestGenerator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using MathTestGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\GitHub\MathTestGenerator\MathTestGenerator\_Imports.razor"
using MathTestGenerator.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addition")]
    public partial class Addition : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Addition</h3>\r\n\r\n");
            __Blazor.MathTestGenerator.Pages.Addition.TypeInference.CreateGridView_0(__builder, 1, 2, 
#nullable restore
#line 5 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
                     questions

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 5 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
                                          1

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        <th></th>\r\n        <th></th>\r\n        <th></th>\r\n        <th></th>\r\n        ");
                __builder2.AddMarkupContent(6, "<th>Summary</th>\r\n    ");
            }
            , 7, (context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "td");
                __builder2.AddContent(10, 
#nullable restore
#line 14 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
             context.NumbersToUse[0]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n\r\n");
#nullable restore
#line 16 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
         if (context.Operation == Operations.ADDITION)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "            ");
                __builder2.AddMarkupContent(13, "<td>+</td>\r\n");
#nullable restore
#line 19 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
        }
        else if (context.Operation == Operations.EXTRACTION)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(14, "            ");
                __builder2.AddMarkupContent(15, "<td>-</td>\r\n");
#nullable restore
#line 23 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
        }
        else if (context.Operation == Operations.MULTIPLICATION)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(16, "            ");
                __builder2.AddMarkupContent(17, "<td>*</td>\r\n");
#nullable restore
#line 27 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
        }
        else if (context.Operation == Operations.DIVISION)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(18, "            ");
                __builder2.AddMarkupContent(19, "<td>/</td>\r\n");
#nullable restore
#line 31 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 33 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
             context.NumbersToUse[1]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.AddMarkupContent(24, "<td>=</td>\r\n        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 35 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
             context.Result

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
       

    public List<Question> questions = new List<Question>();

    protected override void OnInitialized()
    {
        var i = 10;
        while (i > 0)
        {
            var question = new Question();
            Random rnd = new Random();

            question.NumbersToUse[0] = rnd.Next(50, 101);
            question.NumbersToUse[1] = rnd.Next(1, 50);

            question.Operation = (Operations)rnd.Next(0, 4);

            int result = 0;

            if (question.Operation == Operations.ADDITION)
            {
                result = question.NumbersToUse[0] + question.NumbersToUse[1];
            }
            else if (question.Operation == Operations.EXTRACTION)
            {
                result = question.NumbersToUse[0] - question.NumbersToUse[1];
            }
            else if (question.Operation == Operations.MULTIPLICATION)
            {
                result = question.NumbersToUse[0] * question.NumbersToUse[1];
            }
            else if (question.Operation == Operations.DIVISION)
            {
                result = (int)question.NumbersToUse[0] / question.NumbersToUse[1];
            }

            question.Result = result;

            questions.Add(question);
            i--;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MathTestGenerator.Pages.Addition
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGridView_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.Int32 __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg3)
        {
        __builder.OpenComponent<global::MathTestGenerator.Shared.GridView<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "AllItems", __arg0);
        __builder.AddAttribute(__seq1, "PageSize", __arg1);
        __builder.AddAttribute(__seq2, "GridHeader", __arg2);
        __builder.AddAttribute(__seq3, "GridRow", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
