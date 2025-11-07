using mes.Models;
using mes.Service;
using mes.ServiceImpl;
using mes.Utils;
using mes.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
namespace mes
{
    public partial class Login : Form
    {
        private IUserService userService { get; set; }
        private void Login_Load(object sender, EventArgs e)
        {
            userService = new UserServiceImpl();
        }
        public Login()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = Email.Text.Trim();
            user.Password = Password.Text.Trim();
            if (userService.Login(user))
            {
                //MessageBox.Show("登录成功");
                Alert.Info("Login Successful");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("登陆失败");
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void HandleRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.FormClosed += Register_FormClosed;
            this.Hide();
            register.ShowDialog();
        }

        private void HandleExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            string password = Password.Text.Trim();
            //bool isEmailChecked = UserCheckUtils.CheckedInput(email);
            //bool isPwdChecked = UserCheckUtils.CheckedInput(password);
            //if (!isEmailChecked || !isPwdChecked) {
            //    this.HandleLogin.Enabled = false;
            //    return;
            //}
            this.HandleLogin.Enabled = true;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            string password = Password.Text.Trim();
            //bool isEmailChecked = UserCheckUtils.CheckedInput(email);
            //bool isPwdChecked = UserCheckUtils.CheckedInput(password);
            //if (!isEmailChecked || !isPwdChecked)
            //{
            //    this.HandleLogin.Enabled = false;
            //    return;
            //}
            this.HandleLogin.Enabled = true;
        }
    }
}
