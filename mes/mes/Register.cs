using mes.Models;
using mes.Service;
using mes.ServiceImpl;
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
    public partial class Register : Form
    {
        public IUserService userService { get; set; }
        private void Register_Load(object sender, EventArgs e)
        {
            userService = new UserServiceImpl();
        }
        public Register()
        {
            InitializeComponent();
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HandleRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            userService.Register(user);
        }
    }
}
