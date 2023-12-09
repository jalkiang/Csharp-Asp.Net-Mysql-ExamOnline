using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EODAL;

namespace EOWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string sql = "select * from tb_user where uName=@uName and uPwd=@uPwd";
            string userName = tb_userName.Text;
            string password = tb_password.Text;
            Hashtable ht = new Hashtable();
            ht.Add("uName", tb_userName.Text.ToString());
            ht.Add("uPwd", tb_password.Text.ToString());
            int resilc = DBHelperMysql.excutScal(sql, ht);

            if (userName == null || password == null)
            {
                Response.Write("账号密码不能为空");
            }
            else if(resilc > 0) 
            {
                Response.Write("登录成功");
                Session["UserName"] = userName;
                Response.Redirect("Index.aspx");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误')</script>");
            }
        }
    }
}