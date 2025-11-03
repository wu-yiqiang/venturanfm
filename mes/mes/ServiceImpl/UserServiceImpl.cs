using mes.Models;
using mes.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace mes.ServiceImpl
{
    internal class UserServiceImpl : IUserService
    {
        public bool Login(User user)
        {
            
                if (user == null)
                {
                    return false;
                }
                if (user.Email == "sutter.wu@itforce-tech.com" && user.Password == "1234@Abcd")
                {
                    return true;
                }
                return false;
            
        }
    }
}
