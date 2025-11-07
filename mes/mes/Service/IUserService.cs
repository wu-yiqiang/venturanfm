using mes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes.Service
{
    public interface IUserService
    {
        /// <summary>
        ///  登陆
        /// </summary>
        /// <returns></returns>
       bool Login(User user);
       bool Register(User user);
    }
}
