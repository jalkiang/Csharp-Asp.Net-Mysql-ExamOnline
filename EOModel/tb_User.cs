using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOModel
{
    public class Tb_User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime JoinTime { get; set; }
        public bool IsAdmin { get; set; }
    }
}
