using EODAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EOBLL
{
    public class BLL_Student
    {
        public int UserLogin(Hashtable ht) 
        {
            string sql = "select * from tb_student where uName=@uName and uPassword=@uPassword";
            int rs = DBHelperMysql.excutScal(sql, ht);
            return rs;
        }

        public int UserRegister(Hashtable ht)
        {
            string sql = "INSERT INTO tb_user(uName,uPwd) VALUES(@username,@password)";
            int rs = DBHelperMysql.excutScal(sql, ht);
            return rs;
        }

        public int SearchUser(Hashtable ht)
        {
            string sql = "Select * from tb_user where uName = @uName65";
            int rs = DBHelperMysql.excutScal(sql, ht);
            return rs;
        }
    }
}
