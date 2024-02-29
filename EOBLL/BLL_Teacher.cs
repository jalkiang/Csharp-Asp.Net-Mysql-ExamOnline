using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EODAL;

namespace EOBLL
{
    public class BLL_Teacher
    {
        public int UserTeacherLogin(Hashtable ht)
        {
            string sql = "select authority from tb_teacher  where tName = @Name and tPassword = @Password union select authority from tb_admin where aName = @Name and aPassword = @Password";
            int rs = DBHelperMysql.excutScal(sql, ht);
            return rs;
        }
    }
}
