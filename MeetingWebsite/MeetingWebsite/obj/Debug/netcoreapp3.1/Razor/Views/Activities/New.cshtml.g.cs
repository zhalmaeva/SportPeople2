#pragma checksum "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Activities\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e64314dcd8471f8756e839174d4b94653648ab11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activities_New), @"mvc.1.0.view", @"/Views/Activities/New.cshtml")]
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
#line 2 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Activities\New.cshtml"
using MeetingWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64314dcd8471f8756e839174d4b94653648ab11", @"/Views/Activities/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459facee8e2ec6c20972d3c1f158eb4e1b3230d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Activities_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MeetingWebsite.ModelsView.Activities.NewActivityModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Activities\New.cshtml"
  
    ViewData["Title"] = "Новое событие";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex flex-column w-75 border ml-3"">
    <div class=""card-header"">
        <span>Новое событие</span>
    </div>
    <form action=""/api/Activities"" method=""POST"" class=""p-2 pt-5"" onsubmit=""sendForm(this, event, OnNewActivity, { onStart: () => $('#error-text').hide(), data:  GetFormData()})"">
        <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>

        <div class=""form-group d-flex "">
            <label class=""control-label col-4 text-right"" style=""line-height: 38px;"">Город</label>
            <input name=""City"" id=""City"" placeholder=""Город"" class=""form-control col-5"" />
        </div>

        <div class=""form-group d-flex "">
            <label class=""control-label col-4 text-right"" style=""line-height: 38px;"">Вид спорта</label>
");
            WriteLiteral("            ");
#nullable restore
#line 22 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Activities\New.cshtml"
       Write(Html.DropDownList("SportKind", Html.GetEnumSelectList(typeof(SportKind)), new { @class = "form-control col-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group d-flex \">\r\n            <label class=\"control-label col-4 text-right\" style=\"line-height: 38px;\">Уровень</label>\r\n");
            WriteLiteral("            ");
#nullable restore
#line 28 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Activities\New.cshtml"
       Write(Html.DropDownList("Level", Html.GetEnumSelectList(typeof(Level)), new { @class = "form-control col-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

        <div class=""form-group d-flex "">
            <label class=""control-label col-4 text-right"" style=""line-height: 38px;"">Дата</label>
            <input name=""Date"" id=""Date"" placeholder=""Дата"" class=""form-control col-5"" />
          
        </div>

        <div class=""form-group d-flex "">
            <label class=""control-label col-4 text-right"" style=""line-height: 38px;"">Дата</label>
            <input");
            BeginWriteAttribute("min", " min =\"", 2012, "\"", 2032, 1);
#nullable restore
#line 39 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Activities\New.cshtml"
WriteAttributeValue("", 2019, DateTime.Now, 2019, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type =""datetime-local"" name=""dateTime"" id=""dateTime"" class=""form-control col-5"" />
        </div>

        <div class=""form-group d-flex "">
            <label class=""control-label col-4 text-right"" style=""line-height: 38px;"">Адрес</label>
            <input name=""Address"" id=""Address"" placeholder=""Адрес"" class=""form-control col-5"" />
        </div>

        <div class=""form-group d-flex "">
            <label class=""control-label col-4 text-right"" style=""line-height: 38px;"">Количество человек</label>
            <input name=""Count"" id=""Count"" placeholder=""Количество человек"" class=""form-control col-5"" />
        </div>

        <div class=""form-group d-flex "">
            <label class=""control-label col-4 text-right"" style=""line-height: 38px;"">Стоимость</label>
            <input name=""Price"" id=""Price"" placeholder=""Стоимость"" class=""form-control col-5"" />
        </div>

        <div class=""form-group d-flex "">
            <label class=""control-label col-4 text-right"">Дополнительная информ");
            WriteLiteral(@"ация</label>

            <textarea name=""Description"" id=""Description"" placeholder=""Дополнительная информация"" class=""form-control col-5""></textarea>
        </div>
        <div class=""form-group mb-1 d-flex justify-content-center"">
            <input type=""submit"" class=""btn btn-sm btn-primary disabled"" value=""Сохранить"" />
        </div>
        <div class=""text-center"">
            <label class=""text-danger"" id=""error""></label>
        </div>
    </form>
</div>

<script>
    function GetFormData() {
        return JSON.stringify({
            ""SportKind"": parseInt( $('#SportKind').val()),
            ""level"": parseInt($('#Level').val()),
            ""Date"": $('#Date').val(),
            ""City"": $('#City').val(),
            ""Count"": $('#Count').val(),
            ""Address"": $('#Address').val(),
            ""Price"": $('#Price').val(),
            ""Description"": $('#Description').val(),
        })
    }

    function OnNewActivity(response) {
        if (response.status == 200) {");
            WriteLiteral(@"
            var redirectUrl = new URL(window.location.href).searchParams.get(""redirectUrl"")
            //Если есть куда, то перенаправить
            if (redirectUrl != undefined && redirectUrl != """") {
                window.location.replace(redirectUrl);
            } else {
                window.location = '/Activities';
            }
        }
        else {
            if (response.status == 400) {
                $('#error-text').text(response.responseText);
                $('#error-text').show();
            }
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MeetingWebsite.ModelsView.Activities.NewActivityModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
