using EOBLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace EOWeb.htmls
{
    public partial class techerLogin : System.Web.UI.Page
    {
        BLL_Teacher bt = new BLL_Teacher();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = tb_userName.Text;
            string password = tb_password.Text;
            Hashtable ht = new Hashtable();
            ht.Add("Name", tb_userName.Text.ToString());
            ht.Add("Password", tb_password.Text.ToString());
            int resilc = bt.UserTeacherLogin(ht);


            if (userName == null || password == null)
            {
                Response.Write("账号密码不能为空");
            }
            else if (resilc == 2)
            {
                Response.Write("登录成功");
                Session["UserName"] = userName;
                Session["Authority"] = 2;
                Response.Redirect("~/Teacher/Teacher_Index.aspx");
            }
            else if(resilc == 3)
            {
                Response.Write("登录成功");
                Session["UserName"] = userName;
                Session["Authority"] = 3;
                int value = (int)Session["Authority"];
                Response.Redirect("~/Admin/Admin_Index.aspx");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误')</script>");
            }
        }
    }
}