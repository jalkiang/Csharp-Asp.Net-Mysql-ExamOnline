using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EOWeb.htmls
{
    public partial class teacherRegister : System.Web.UI.Page
    {
        EOBLL.BLL_Teacher bLL_Teacher = new EOBLL.BLL_Teacher();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Register_Click(object sender, EventArgs e)
        {
            EOModel.tb_Teacher tb_teacher = new EOModel.tb_Teacher();

            if (tb_userName.Text == "" || tb_password.Text == "" || tb_confirmPassword.Text == "")
            {
                Response.Write("<script>alert('不能留空')</script>");
            }
            else if (tb_password.Text != tb_confirmPassword.Text)
            {
                Response.Write("<script>alert('两次密码不一致')</script>");

            }
            else
            {
                tb_teacher.TeacherName = this.tb_userName.Text;
                tb_teacher.TeacherPassword = this.tb_password.Text;
                tb_teacher.Subject = this.DropDownList1.Text;
                bool res = bLL_Teacher.TeacherRegister(tb_teacher);
                if (res == false)
                {
                    Response.Write("<script>alert('注册失败')</script>");
                }
                else
                {
                    Response.Write("<script>alert('注册成功，跳转到登录界面')</script>");
                }
                
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lb_Login_Click(object sender, EventArgs e)
        {

        }
    }
}