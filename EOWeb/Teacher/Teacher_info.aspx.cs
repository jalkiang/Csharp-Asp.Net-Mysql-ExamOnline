﻿using System;
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
        EOModel.tb_Teacher tb_teacher = new EOModel.tb_Teacher();
        protected void Page_Load(object sender, EventArgs e)
        {
            int teaId = tb_teacher.TeacherID;
        }
    }
}