using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes.Models
{
    public class UserDb
    { 
        public List<User> Users { get; set; }
        public UserDb() {
            InitUser();
        }
        private void InitUser()
        {
            Users = new List<User>();
            User user1 = new User() { Email = "sutter.wu@itforce-tech.com", Password = "1234@Abcd" };
        }
    }
}
