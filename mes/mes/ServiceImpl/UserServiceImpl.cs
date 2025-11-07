using mes.Models;
using mes.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace mes.ServiceImpl
{
    public class UserServiceImpl : IUserService
    {
        public bool Login(User user)
        {
            
            if (user.Email == null)
            {
                MessageBox.Show("请填写邮箱地址");
                ShowAlert("请填写邮箱地址");
                return false;
            }
            if (user.Password == null)
            {
                ShowAlert("请填写密码");
                return false;
            }
            return true;
        }
        public void ShowAlert(string message)
        {
            MessageBox.Show(message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool Register(User user)
        {
            if (user == null || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password)) { 
                return false;
            }
            return true;
        }

    }
}
