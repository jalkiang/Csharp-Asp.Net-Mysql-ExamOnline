using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EOWeb
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void span_logout(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('已退出登录，跳转到登录页面！');", true);
            Session.Remove("UserName");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Redirect", "window.location.href='/htmls/teacherLogin.aspx';", true);
        }
    }
}