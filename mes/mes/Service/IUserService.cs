using mes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes.Service
{
    internal interface IUserService
    {
        /// <summary>
        ///  登陆
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        bool Login(User user);
    }
}
