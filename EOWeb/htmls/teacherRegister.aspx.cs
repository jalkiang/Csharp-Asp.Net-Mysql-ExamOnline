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
            tb_teacher.TeacherName = this.tb_userName.Text;
            tb_teacher.TeacherPasswood = this.tb_password.Text;

            bLL_Teacher.TeacherRegister(tb_teacher);
        }
    }
}