using System;
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

        public int UserTeacherLogin(Hashtable ht)
        {
            string sql = "select authority from tb_teacher  where tName = @Name and tPassword = @Password union select authority from tb_admin where aName = @Name and aPassword = @Password";
            int rs = DBHelperMysql.excutScal(sql, ht);
            return rs;
        }

        public bool TeacherRegister(EOModel.tb_Teacher tb_teacher)
        {
            bool res = false;
            string strsql = "INSERT INTO tb_teacher(tName,tPassword) VALUES('"+tb_teacher.TeacherName+"','"+tb_teacher.TeacherPasswood+"')";
            int i = DBHelperMysql.ExcutSql(strsql);
            if(i>0)
            {
                res = true;
            }
            return res;
        }

    }
}
