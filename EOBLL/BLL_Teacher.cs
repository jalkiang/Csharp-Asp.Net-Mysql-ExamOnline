﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EODAL;
using EOModel;

namespace EOBLL
{
    public class BLL_Teacher
    {
        tb_Teacher tbTeacher = new tb_Teacher();

        public int UserTeacherLogin(EOModel.tb_Teacher tb_teacher)
        {
            string sql = "select authority from tb_teacher  where tName = '"+tb_teacher.TeacherName+"' and tPassword = '"+tb_teacher.TeacherPassword+"' union select authority from tb_admin where aName = '"+tb_teacher.TeacherName+"' and aPassword = '"+tb_teacher.TeacherPassword+"'";
            int res = DBHelperMysql.ExcutSqlrint(sql);
            return res;
        }

        public bool TeacherRegister(EOModel.tb_Teacher tb_teacher)
        {
            bool res = false;
            string strsql = "INSERT INTO tb_teacher(tName,tPassword,subject) VALUES('"+tb_teacher.TeacherName+"','"+tb_teacher.TeacherPassword+"','"+tb_teacher.Subject+"')";
            int i = DBHelperMysql.ExcutSql(strsql);
            if(i>0)
            {
                res = true;
            }
            return res;
        }

        public object TeacherInfoList(EOModel.tb_Teacher tb_teacher)
        {
            string strsql = "SELECT * FROM tb_teacher where tName = '"+tb_teacher.TeacherName+"'";
            object i = DBHelperMysql.ExcutSqlrobj(strsql);
            return i;
        }

    }
}
