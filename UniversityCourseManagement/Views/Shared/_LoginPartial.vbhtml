@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated
    @Using Html.BeginForm("Logout", "Account", New With {.area = ""}, FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav">
            <li class="nav-item">
                @Html.ActionLink("Hello " + User.Identity.GetUserName() + "!", "Index", "Manage", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.title = "Manage", .class = "nav-link"})
            </li>
            <li class="nav-item"><a href="javascript:sessionStorage.removeItem('accessToken');$('#logoutForm').submit();" class="nav-link">Log off</a></li>
        </ul>
    End Using
Else
    @<ul class="nav navbar-nav navbar-right">
        <li>@Html.ActionLink("Register", "Register", "Account", routeValues := New With { .area = "" }, htmlAttributes := New With { .id = "registerLink" })</li>
        <li>@Html.ActionLink("Log in", "Login", "Account", routeValues := New With { .area = "" }, htmlAttributes := New With { .id = "loginLink" })</li>
    </ul>
End If
