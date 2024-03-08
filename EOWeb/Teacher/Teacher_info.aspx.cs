using EOModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EOWeb.Teacher
{
    public partial class Teacher_info : System.Web.UI.Page
    {
        EOBLL.BLL_Teacher bLL_Teacher = new EOBLL.BLL_Teacher();
        tb_Teacher tb_teacher = new  EOModel.tb_Teacher();
        protected void Page_Load(object sender, EventArgs e)
        {
            tb_teacher.TeacherName =  Session["UserName"].ToString();
            List<tb_Teacher> t1 = bLL_Teacher.tInfoList(tb_teacher);
            if (!IsPostBack)
            {
                lb_tId.Text = t1[0].TeacherID.ToString();
                tb_tName.Text = t1[0].TeacherName.ToString();
                tb_Subject.Text = t1[0].Subject.ToString();
                tb_tPhone.Text = t1[0].TeacherPhone.ToString();
            }

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            tb_Teacher tb_teacher = new tb_Teacher();
            tb_teacher.TeacherID= Convert.ToInt32(this.lb_tId.Text);
            tb_teacher.TeacherName = this.tb_tName.Text;
            tb_teacher.TeacherPhone = this.tb_tPhone.Text;
            tb_teacher.Subject=this.tb_Subject.Text;
            bool res = bLL_Teacher.TeacherInfoSave(tb_teacher);
            if (res == false)
            {
                Response.Write("<script>alert('修改失败')</script>");
            }
            else
            {
                Response.Write("<script>alert('修改成功')</script>");
            }
        }
    }
}