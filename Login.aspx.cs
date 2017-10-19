using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.Label1.Text = Session["UserName"] as string;
    }

    protected void Login1_LoggedIn(object sender, EventArgs e)
    {
        Session["UserName"] = this.Login1.UserName;
    }

    protected void Login1_LoggingIn(object sender, LoginCancelEventArgs e)
    {

    }

    protected void Login1_LoginError(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());

        con.Open();

        string query = "SELECT COUNT(*) FROM UserLogin.[dbo].[User] WHERE (UserName ='" + Login1.UserName.ToString() + "' AND Password ='" + Login1.Password.ToString() + "')";
        SqlCommand cmd = new SqlCommand(query, con);

        string output = cmd.ExecuteScalar().ToString();

        if (output == "1")
        {
            
           Session["UserName"] = Login1.UserName.ToString();
            Response.Redirect("Chaomung.aspx");
            //Response.Write("Dang nhap thanh cong");
           // e.Authenticated = true;
        }
        else
        {
            //Response.Write("<script> alert('Dang nhap that bai') </script>");
            
           // e.Authenticated = false;
        }

    }

}