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
        BLL_Student bu = new BLL_Student();
        protected void Page_Load(object sender, EventArgs e)
        {
            //设置条件登录后无法进入注册界面
            if (Session["UserName"] != null)
            {
                string value = HttpContext.Current.Session["UserName"].ToString();
                if (value != "admin")
                {
                    Response.Write("<script>alert('您已登录！')</script>");
                    Response.Write("<script>window.location.href='/index.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('您已登录！')</script>");
                    Response.Write("<script>window.location.href='/Admin/index.aspx'</script>");
                }
            }
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

                Hashtable ht2 = new Hashtable();
                ht2.Add("uName", tb_userName.Text.ToString());
                int rsUser = bu.SearchUser(ht2);
                if (rsUser == 0) 
                {
                    resilc = bu.UserRegister(ht);
                    Response.Write("<script>alert('登录成功！')</script>");
                    Response.Redirect("~/htmls/Login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('用户已存在！')</script>");
                }


            }
        }
    }
}