using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CreateTime { get; set; }
        public int UpdateTime { get; set; }
    }
}
