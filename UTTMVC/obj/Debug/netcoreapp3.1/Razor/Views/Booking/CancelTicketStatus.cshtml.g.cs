#pragma checksum "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ca582e70676f164ef668f2383412051b3e5c2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_CancelTicketStatus), @"mvc.1.0.view", @"/Views/Booking/CancelTicketStatus.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\CTS\Practise\UTTMVC\Views\_ViewImports.cshtml"
using UTTMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\CTS\Practise\UTTMVC\Views\_ViewImports.cshtml"
using UTTMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ca582e70676f164ef668f2383412051b3e5c2d", @"/Views/Booking/CancelTicketStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34e483840b40bb87266ee68f447d09d69d72cc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_CancelTicketStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UTTMVC.Models.TicketDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
  
    ViewData["Title"] = "CancelTicketStatus";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    h1 {
        background-color: #ffc324;
        background-size: auto;
        height: auto;
        background-repeat: no-repeat;
        padding-bottom: 10px;
        color: antiquewhite;
        text-align: center;
    }

    #PageBody {
        background-color: azure;
        padding: 5%;
    }

    table, td, tr {
        border: solid;
    }

    a {
        text-decoration: none;
        color: black;
    }

        a:hover {
            text-decoration: none;
            color: black;
        }

    #PageFooter {
        text-align: center;
        color: black;
    }

    .pointer {
        cursor: pointer;
        color:black;
    }
    body {
        color: #ffc324;
    }
</style>
<h1>Ticket</h1>
<div id=""PageBody"">
    <table class=""table"">
        <tr>
            <td>
                ");
#nullable restore
#line 56 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.Route));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayFor(model => model.Route));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.TramType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayFor(model => model.TramType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Purchase Time</td>\r\n            <td id=\"TimePrint\"></td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfPassenger));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayFor(model => model.NumberOfPassenger));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayNameFor(model => model.TicketFare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
           Write(Html.DisplayFor(model => model.TicketFare));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </td>
        </tr>
        <tr>
            <td colspan=""2"" style=""text-align:center;font-weight:bold"">
                Ticket Cancelled
            </td>
        </tr>
    </table>
    <script type=""text/javascript"">
        var myDate = new Date();
        var myDay = myDate.getDay();


        // get hour value.
        var hours = myDate.getHours();
        var ampm = hours >= 12 ? 'PM' : 'AM';
        hours = hours % 12;
        hours = hours ? hours : 12;
        var minutes = myDate.getMinutes();
        minutes = minutes < 10 ? '0' + minutes : minutes;
        var myTime = hours + "" : "" + minutes + ampm;
        document.getElementById(""TimePrint"").innerHTML = myTime;
    </script>
</div>
<div id=""PageFooter"">
    <a");
            BeginWriteAttribute("href", " href=\"", 3150, "\"", 3177, 1);
#nullable restore
#line 129 "E:\CTS\Practise\UTTMVC\Views\Booking\CancelTicketStatus.cshtml"
WriteAttributeValue("", 3157, Url.Action("Index"), 3157, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home Page</a> |\r\n    <span class=\"pointer\" onclick=\"window.print()\">Print Ticket</span>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UTTMVC.Models.TicketDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
