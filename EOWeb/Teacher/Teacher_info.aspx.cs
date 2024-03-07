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
            lb_tId.Text = t1[0].TeacherID.ToString();
            lb_tName.Text = t1[0].TeacherName.ToString();
            lb_Subject.Text = t1[0].Subject.ToString();
            lb_tPhone.Text = t1[0].TeacherPhone.ToString();
        }
    }
}