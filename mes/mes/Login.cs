using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            
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
            bool isEmailChecked = CheckedInput(email);
            bool isPwdChecked = CheckedInput(password);
            if (!isEmailChecked || !isPwdChecked) {
                this.HandleLogin.Enabled = false;
                return;
            }
            this.HandleLogin.Enabled = true;
        }
        private bool CheckedInput(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            return true;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            string password = Password.Text.Trim();
            bool isEmailChecked = CheckedInput(email);
            bool isPwdChecked = CheckedInput(password);
            if (!isEmailChecked || !isPwdChecked)
            {
                this.HandleLogin.Enabled = false;
                return;
            }
            this.HandleLogin.Enabled = true;
        }
    }
}
