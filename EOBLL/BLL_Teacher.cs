using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EODAL;
using EOModel;
using MySql.Data.MySqlClient;

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

        public List<tb_Teacher> tInfoList(EOModel.tb_Teacher tb_teacher)
        {
            string strsql = "SELECT * FROM tb_teacher where tName = '"+tb_teacher.TeacherName+"'";
            List<tb_Teacher> t1 =  DBHelperMysql.seledb(strsql);
            return t1;
        }

        public bool TeacherInfoSave(EOModel.tb_Teacher tb_teacher)
        {
            bool res = false;
            string strsql = "UPDATE tb_teacher SET tName = '"+tb_teacher.TeacherName+"',tPhone = '"+tb_teacher.TeacherPhone+"',`subject` = '"+tb_teacher.Subject+"' WHERE tId = '"+tb_teacher.TeacherID+"';";
            int i = DBHelperMysql.ExcutSql(strsql);
            if (i > 0)
            {
                res = true;
            }
            return res;
        }

        public bool ResPwd(EOModel.tb_Teacher tb_teacher)
        {
            bool res = false;
            string strsql = "UPDATE tb_teacher SET tPassword = '"+tb_teacher.TeacherConPassword+"' WHERE tPassword = '"+tb_teacher.TeacherPassword+"' and tName='"+tb_teacher.TeacherName+"';";
            int i = DBHelperMysql.ExcutSql(strsql);
            if (i > 0)
            {
                res = true;
            }
            return res;
        }
    }
}
