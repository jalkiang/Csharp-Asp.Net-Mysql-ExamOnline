using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EOBLL;

namespace EOWeb.htmls
{
    public partial class Register : System.Web.UI.Page
    {
        BLL_User bu = new BLL_User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = tb_userName.Text;
            string password = tb_password.Text; 
            string confirmPassword = tb_confirmPassword.Text;


            int resilc;

            if (userName == "" || password == "" || confirmPassword == "")
            {
                Response.Write("<script>alert('不能留空')</script>");
            }
            else if (password != confirmPassword)
            {
                Response.Write("<script>alert('两次密码不一致')</script>");

            }

            else
            {
                Hashtable ht = new Hashtable();
                ht.Add("username", tb_userName.Text.ToString());
                ht.Add("password", tb_password.Text.ToString());
                resilc = bu.UserRegister(ht);
                Response.Write("注册成功");
                Response.Redirect("~/htmls/Login.aspx");
            }
        }
    }
}