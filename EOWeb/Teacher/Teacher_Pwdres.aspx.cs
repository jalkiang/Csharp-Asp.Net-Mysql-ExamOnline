using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EOModel;
using EOBLL;

namespace EOWeb.Teacher
{
    public partial class Teacher_Pwdres : System.Web.UI.Page
    {
        tb_Teacher tb_teacher = new tb_Teacher();
        BLL_Teacher bll_teacher = new BLL_Teacher();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_pwdres_Click(object sender, EventArgs e)
        {
            if(tb_oldpwd.Text == "" || tb_newpwd.Text == "" || tb_conpwd.Text == "")
            {
                Response.Write("<script>alert('不能留空')</script>");
            }
            else if (tb_newpwd.Text != tb_conpwd.Text)
            {
                Response.Write("<script>alert('两次新密码不一致')</script>");
            }
            else
            {
                tb_teacher.TeacherPassword = this.tb_oldpwd.Text;
                tb_teacher.TeacherConPassword = this.tb_conpwd.Text;
                tb_teacher.TeacherName = Session["UserName"].ToString();
                bool res = bll_teacher.ResPwd(tb_teacher);
                if (res == false)
                {
                    Response.Write("<script>alert('原密码错误')</script>");
                }
                else if (res == true)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('修改成功，跳转到登录页面！');", true);
                    Session.Remove("UserName");
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Redirect", "window.location.href='/htmls/teacherLogin.aspx';", true);
                }
            }

        }
    }
}