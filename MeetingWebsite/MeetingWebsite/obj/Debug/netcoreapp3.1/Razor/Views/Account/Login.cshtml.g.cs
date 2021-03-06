#pragma checksum "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6fbec4efd119a703583abc6d633b0ac76f198d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6fbec4efd119a703583abc6d633b0ac76f198d5", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459facee8e2ec6c20972d3c1f158eb4e1b3230d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MeetingWebsite\MeetingWebsite\MeetingWebsite\MeetingWebsite\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Авторизация";
    Layout = "_LayoutEmpty";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""center-child vh-100"">
    <form action=""/api/User"" method=""GET"" class=""card p-5"" style=""width: 30rem;"" onsubmit=""sendForm(this, event, onLogin, { onStart: () => $('#error-text').hide() })"">

        <label class=""mx-auto font-weight-bold"">Авторизация</label>
        <input type=""text"" name=""username"" id=""username"" placeholder=""Email/Login/Номер телефона"" required class=""form-control w-90 mx-auto mt-2"">
        <input type=""password"" name=""password"" id=""password"" placeholder=""Пароль"" required class=""form-control w-90 mx-auto mt-2"">

        <span id=""error-text"" class=""w-90 mx-auto mb-2"" style=""display: none;color: red;""></span>

        <input type=""submit"" value=""Войти"" class=""btn btn-primary w-90 mx-auto mt-2"">
        <a href=""/Account/Registration"" class=""card-link mx-auto"" onclick=""OpenLink(this,event)"">Регистрация</a>

    </form>
</div>


<script>
    //Авторизация
    function onLogin(response) {
        if (response.status == 200) {
            $.cookie(""Authorization""");
            WriteLiteral(@", `Bearer ${response.responseJSON.access_token}`, { path: '/' });
            GetUserInfoFromServer();
            var redirectUrl = new URL(window.location.href).searchParams.get(""redirectUrl"")
            //Если есть куда, то перенаправить
            if (redirectUrl != undefined && redirectUrl != """") {
                window.location.replace(redirectUrl);
            } else {
                window.location = '/Dialogs';
            }
            //Иначе отправить на какую-то страницу
            //TODO: доделать
        }
        else {
            $('#error-text').text(response.responseJSON.errorText);
            $('#error-text').show();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
