﻿using EODAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EOBLL
{
    public class BLL_User
    {
        public int UserLogin(Hashtable ht) 
        {
            string sql = "select IsAdmin from tb_user where uName=@uName and uPwd=@uPwd";
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
            string sql = "Select * from tb_user where uName = @uName";
            int rs = DBHelperMysql.excutScal(sql, ht);
            return rs;
        }
    }
}
