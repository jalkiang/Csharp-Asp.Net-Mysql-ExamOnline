﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOModel
{
    public class tb_Teacher
    {
        private int teacherID;
        private string teacherName;
        private string teacherPassword;
        private int authority;
        private string subject;
        private string teacherPhone;
        private string teacherConPassword;

        public int TeacherID { get => teacherID; set => teacherID = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
        public int Authority { get => authority; set => authority = value; }
        public string Subject { get => subject; set => subject = value; }
        public string TeacherPassword { get => teacherPassword; set => teacherPassword = value; }
        public string TeacherPhone { get => teacherPhone; set => teacherPhone = value; }
        public string TeacherConPassword { get => teacherConPassword; set => teacherConPassword = value; }
    }
}
