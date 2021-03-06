#pragma checksum "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "542acafdd8c4fa00dffff1b85f1e84c2f87d90ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 3 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
using MeetingWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"542acafdd8c4fa00dffff1b85f1e84c2f87d90ce", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459facee8e2ec6c20972d3c1f158eb4e1b3230d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "??????????";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""h-100 w-100 row border m-0"">
    <div class=""h-100 w-25 flex-column border-right"" onmouseout=""getUsers()"">

        <div id=""dialogs-title"" class=""text-center py-3"">?????????????????? ????????????</div>
        <form id=""settings"" class=""px-3 mt-4"">

            <input type=""text"" name=""city"" placeholder=""??????????"" class=""form-control"" onchange=""onChangeSettings()"" />
            ");
#nullable restore
#line 16 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
       Write(Html.DropDownList("Sex", Html.GetEnumSelectList(typeof(Sex)), new { @class = "form-control my-2", @onchange = "onChangeSettings()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div>??????????????:</div>
            <div class=""d-flex align-items-center mt-2"">
                ????
                <input type=""number"" name=""minAge"" id=""minAge"" value=""18"" min=""18"" class=""form-control ml-1"" onchange=""onChangeSettings()"" />
            </div>
            <div class=""d-flex align-items-center mt-2"">
                ????
                <input type=""number"" name=""maxAge"" id=""maxAge"" value=""25"" min=""18"" class=""form-control ml-1"" onchange=""onChangeSettings()"" />
            </div>

        </form>
    </div>
    <div class=""h-100 w-75 pb-2 d-flex flex-column"">
        <div class=""px-3 py-3 dialog-title border-bottom"" style=""font-size: 1.2rem;"">????????????????????????</div>
        <div class=""w-100 h-100 py-3 flex-grow-1 overflow-auto"">
            <div class=""px-5 d-flex flex-column"" id=""users"">

");
#nullable restore
#line 34 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                 for (int i = 0; i < Model.Count; i++)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"d-flex justify-content-between flex-nowrap message\">\r\n                        <div class=\"row m-0 flex-nowrap\">\r\n\r\n                            <div class=\"rounded-circle user-icon overflow-hidden\">\r\n");
#nullable restore
#line 41 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                                 if (Model[i].Photos.Count == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "542acafdd8c4fa00dffff1b85f1e84c2f87d90ce6384", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 44 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=\"", 2097, "\"", 2131, 1);
#nullable restore
#line 47 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
WriteAttributeValue("", 2103, Model[i].Photos.Last().Path, 2103, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100%\" />\r\n");
#nullable restore
#line 48 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"d-flex flex-column\">\r\n");
            WriteLiteral("                                <div class=\"row m-0 p-0 align-content-end\">\r\n                                    <p class=\"user-name pl-2 m-0\">");
#nullable restore
#line 53 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                                                             Write(Model[i].FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n");
            WriteLiteral("                                <p class=\"pl-2 message-body m-0\" style=\"color: #7d7d7d\">\r\n                                    ");
#nullable restore
#line 57 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                               Write(Model[i].City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n");
#nullable restore
#line 60 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                                 if (string.IsNullOrEmpty(Model[i].BriefInformation))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"pl-2 message-body\" style=\"color: #7d7d7d\">\r\n                                        ???????????????????????? ???? ?????????????? ????????????????\r\n                                    </p>\r\n");
#nullable restore
#line 65 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"pl-2 message-body\">\r\n                                        ");
#nullable restore
#line 69 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                                   Write(Model[i].BriefInformation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n");
#nullable restore
#line 71 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <a href=\"#\" class=\" float-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3655, "\"", 3698, 3);
            WriteAttributeValue("", 3665, "createDialogAndOpen(", 3665, 20, true);
#nullable restore
#line 75 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
WriteAttributeValue("", 3685, Model[i].Id, 3685, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3697, ")", 3697, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img src=\"/images/message.png\" width=\"40\" />\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 79 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script>
    var timeout = -10;
    var oldformSerialize = '';
    $(() => {
        //onChangeSettings();
        oldformSerialize = $('#settings').serialize();
    })


    function createDialogAndOpen(userId) {
        send('/api/Dialogs', 'POST', openDialog, JSON.stringify([userId]));
    }
    function openDialog(response) {
        debugger;
        if (response.status == 200)
            window.location = `/Dialogs?id=${response.responseText}`;// TODO: ?????????????? ???? ???????????????? ??????????????
        else
            alert(response.responseText);
    }



    // ?????????????? ?????? ?????????????????? ???????????????? ????????????
    function onChangeSettings() {
        if (timeout != undefined)
            clearTimeout(timeout);
        timeout = setTimeout(getUsers, 1500);
        console.log(timeout);
    }

    // ?????????????????? ??????????????????????????
    function getUsers() {
        if (timeout != undefined)
            clearTimeout(timeout);
        var formSer");
            WriteLiteral(@"ialize = $('#settings').serialize();
        if (formSerialize != oldformSerialize) {
            oldformSerialize = formSerialize;
            send(`/api/Search?${formSerialize}`, 'GET', refreshUsers);
        }
    }

    // ?????????????????? ??????????????????????????
    function refreshUsers(response) {
        var users = response.responseJSON;
        $('#users').html('');
        users.forEach((user, index) => {
            var photoPath = '/images/user.png';
            if (user.photos.length > 0)
                photoPath = user.photos[user.photos.length - 1]

            var briefInformation = '???????????????????????? ???? ?????????????? ????????????????';
            if (user.briefInformation != null && user.briefInformation.length > 0)
                briefInformation = user.briefInformation;
            debugger;
            var userHtml = `
                <div class=""d-flex justify-content-between flex-nowrap message"">
                    <div class=""row m-0 flex-nowrap"">
                    <div class=""rounded-circle ");
            WriteLiteral("user-icon overflow-hidden\">\r\n                        <img src=\"${photoPath}\" style=\"width: 100%\" />\r\n                    </div>\r\n                    <div class=\"d-flex flex-column\">\r\n");
            WriteLiteral("                        <div class=\"row m-0 p-0 align-content-end\">\r\n                            <p class=\"user-name pl-2 m-0\">${user.firstName} ${user.lastName}</p>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <p  class=""pl-2 message-body m-0"" style=""color: #7d7d7d"">
                            ${user.city}
                        </p>
                        <p class=""pl-2 message-body"" style=""color: #7d7d7d"">
                            ${briefInformation}
                        </p>

                    </div>
                </div>
                <a href=""#"" class="" float-right"" onclick=""createDialogAndOpen(${user.id})"">
                    <img src=""/images/message.png"" width=""40"" />
                </a>
            </div>`;

            $('#users').append(userHtml);
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
