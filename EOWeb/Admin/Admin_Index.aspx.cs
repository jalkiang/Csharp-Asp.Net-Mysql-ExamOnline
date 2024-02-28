using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EOWeb.Admin
{
    public partial class Admin_Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserName"] == null)
            {
                Response.Write("<script>alert('请登录后再访问！')</script>");
                Response.Write("<script>window.location.href='/htmls/Login.aspx'</script>");
                //Response.Redirect("~/htmls/Login.aspx");
            }
            else if(HttpContext.Current.Session != null)
            {
                string value = HttpContext.Current.Session["UserName"].ToString();
                if(value != "admin")
                {
                    Response.Write("<script>alert('禁止访问！')</script>");
                    Response.Write("<script>window.location.href='/index.aspx'</script>");
                }
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("UserName");
            Response.AddHeader("Refresh", "0");
        }
    }
}