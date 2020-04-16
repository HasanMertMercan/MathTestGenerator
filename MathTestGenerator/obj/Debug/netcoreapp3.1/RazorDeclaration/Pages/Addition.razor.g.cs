#pragma checksum "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7a35d85becec8aace723f2a0a865f8ab8a5b12b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\GitHub\MathTestGenerator\MathTestGenerator\Pages\Addition.razor"
       

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
#pragma warning restore 1591
