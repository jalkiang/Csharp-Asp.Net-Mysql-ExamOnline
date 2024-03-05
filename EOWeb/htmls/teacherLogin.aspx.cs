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
        EOBLL.BLL_Teacher bLL_Teacher = new BLL_Teacher();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = tb_userName.Text;
            string password = tb_password.Text;

            EOModel.tb_Teacher tb_teacher = new EOModel.tb_Teacher();

            tb_teacher.TeacherName = this.tb_userName.Text;
            tb_teacher.TeacherPassword = this.tb_password.Text;
            int resilc = bLL_Teacher.UserTeacherLogin(tb_teacher);




            if (userName == null || password == null)
            {
                Response.Write("账号密码不能为空");
            }
            else if (resilc == 2)
            {
                Session["UserName"] = userName;
                tb_teacher.Authority = 2;

                
                object j =  bLL_Teacher.TeacherInfoList(tb_teacher);
                //Response.Redirect("~/Teacher/Teacher_Index.aspx");
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