<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>        
        <asp:Login  ID="Login1" runat="server" CreateUserUrl="~/Taotaikhoan.aspx"
                    LoginButtonText="Đăng nhập" OnAuthenticate="Login1_Authenticate"
                    OnLoggedIn="Login1_LoggedIn" OnLoggingIn="Login1_LoggingIn"
                    OnLoginError="Login1_LoginError" PasswordLabelText="Mật khẩu:"
                    PasswordRecoveryUrl="~/RecoveryPass.aspx" RememberMeText="Nhớ đăng nhập cho lần sau"
                    TitleText="Đăng nhập" UserNameLabelText="Đăng Nhập:" FailureText="Tài khoản hoặc mật khẩu không đúng">
        </asp:Login>
    
        <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/RecoveryPass.aspx">Quên tài khoản?</asp:LinkButton>
    
    </div>
    
        <p>
            <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Taotaikhoan.aspx">Tạo tài khoản</asp:LinkButton>
        </p>
        
    </form>
    <session
        mode="StateServer"
        cookieless="false"
        timeout="2000"/>
</body>
</html>