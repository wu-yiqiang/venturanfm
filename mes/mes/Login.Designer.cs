namespace mes
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.HandleLogin = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.HandleExit = new Sunny.UI.UIButton();
            this.HandleRegister = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.Email = new Sunny.UI.UITextBox();
            this.Password = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // HandleLogin
            // 
            this.HandleLogin.CausesValidation = false;
            this.HandleLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HandleLogin.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.HandleLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HandleLogin.Location = new System.Drawing.Point(305, 253);
            this.HandleLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.HandleLogin.Name = "HandleLogin";
            this.HandleLogin.Size = new System.Drawing.Size(100, 35);
            this.HandleLogin.TabIndex = 0;
            this.HandleLogin.Text = "登陆";
            this.HandleLogin.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HandleLogin.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(46, 73);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "账号";
            // 
            // HandleExit
            // 
            this.HandleExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HandleExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.HandleExit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(158)))));
            this.HandleExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(158)))));
            this.HandleExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(158)))));
            this.HandleExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HandleExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(158)))));
            this.HandleExit.Location = new System.Drawing.Point(36, 253);
            this.HandleExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.HandleExit.Name = "HandleExit";
            this.HandleExit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(158)))));
            this.HandleExit.Size = new System.Drawing.Size(100, 35);
            this.HandleExit.TabIndex = 2;
            this.HandleExit.Text = "退出";
            this.HandleExit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HandleExit.Click += new System.EventHandler(this.HandleExit_Click);
            // 
            // HandleRegister
            // 
            this.HandleRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HandleRegister.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HandleRegister.Location = new System.Drawing.Point(166, 253);
            this.HandleRegister.MinimumSize = new System.Drawing.Size(1, 1);
            this.HandleRegister.Name = "HandleRegister";
            this.HandleRegister.Size = new System.Drawing.Size(100, 35);
            this.HandleRegister.TabIndex = 3;
            this.HandleRegister.Text = "注册";
            this.HandleRegister.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HandleRegister.Click += new System.EventHandler(this.HandleRegister_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(46, 137);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "密码";
            // 
            // Email
            // 
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Email.Location = new System.Drawing.Point(131, 67);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Email.MinimumSize = new System.Drawing.Size(1, 16);
            this.Email.Name = "Email";
            this.Email.Padding = new System.Windows.Forms.Padding(5);
            this.Email.ShowText = false;
            this.Email.Size = new System.Drawing.Size(274, 29);
            this.Email.TabIndex = 5;
            this.Email.Text = "sutter.wu@itforce-tech.com";
            this.Email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Email.Watermark = "";
            this.Email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password.Location = new System.Drawing.Point(131, 131);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.MinimumSize = new System.Drawing.Size(1, 16);
            this.Password.Name = "Password";
            this.Password.Padding = new System.Windows.Forms.Padding(5);
            this.Password.PasswordChar = '*';
            this.Password.ShowText = false;
            this.Password.Size = new System.Drawing.Size(274, 29);
            this.Password.TabIndex = 6;
            this.Password.Text = "1234@Abcd";
            this.Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Password.Watermark = "";
            this.Password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 347);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.HandleRegister);
            this.Controls.Add(this.HandleExit);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.HandleLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MES";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton HandleLogin;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton HandleExit;
        private Sunny.UI.UIButton HandleRegister;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox Email;
        private Sunny.UI.UITextBox Password;
    }
}

