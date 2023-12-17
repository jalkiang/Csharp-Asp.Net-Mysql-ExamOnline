using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EOWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = Request.Url.AbsolutePath;
            switch(url)
            {
                case "/index.aspx":
                case "/Index.aspx":
                    animation.Attributes.Add("class", "animation start-home");
                    break;
                case "/htmls/Login.aspx":
                    animation.Attributes.Add("class", "animation start-login");
                    break;
                default:
                    animation.Attributes.Add("class", "animation ");
                    break;
            }
            /*if(url == "/Index.aspx")
            {
                animation.Attributes.Add("class", "animation start-home");
            }

            else if(url == "/htmls/Login.aspx")
            {
                animation.Attributes.Add("class", "animation start-login");
            }*/

        }

        protected void lb_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/htmls/Register.aspx");
        }

        protected void lb_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/htmls/Login.aspx");
        }
    }
}