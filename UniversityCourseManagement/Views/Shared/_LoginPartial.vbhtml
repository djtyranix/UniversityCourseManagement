@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated
    @Using Html.BeginForm("LogOff", "Account", New With {.area = ""}, FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav">
            <li class="nav-item">
                @Html.ActionLink("Hello " + User.Identity.GetUserName() + "!", "Index", "Manage", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.title = "Manage", .class = "nav-link"})
            </li>
            <li class="nav-item"><a href="javascript:sessionStorage.removeItem('accessToken');$('#logoutForm').submit();" class="nav-link">Logout</a></li>
        </ul>
    End Using
Else
    @<ul class="nav navbar-nav navbar-right">
        <li class="nav-item">@Html.ActionLink("Register", "Register", "Account", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.id = "registerLink", .class = "nav-link"})</li>
        <li class="nav-item">@Html.ActionLink("Log in", "Login", "Account", routeValues:=New With {.area = ""}, htmlAttributes:=New With {.id = "loginLink", .class = "nav-link"})</li>
    </ul>
End If
