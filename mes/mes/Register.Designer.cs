namespace mes
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.HandleRegister = new Sunny.UI.UIButton();
            this.HandleCancel = new Sunny.UI.UIButton();
            this.email = new Sunny.UI.UITextBox();
            this.password = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.phone = new Sunny.UI.UITextBox();
            this.SendVerify = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(36, 60);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "账号";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(36, 119);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "密码";
            // 
            // HandleRegister
            // 
            this.HandleRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HandleRegister.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HandleRegister.Location = new System.Drawing.Point(262, 265);
            this.HandleRegister.MinimumSize = new System.Drawing.Size(1, 1);
            this.HandleRegister.Name = "HandleRegister";
            this.HandleRegister.Size = new System.Drawing.Size(100, 35);
            this.HandleRegister.TabIndex = 4;
            this.HandleRegister.Text = "注册";
            this.HandleRegister.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // HandleCancel
            // 
            this.HandleCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HandleCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HandleCancel.Location = new System.Drawing.Point(39, 265);
            this.HandleCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.HandleCancel.Name = "HandleCancel";
            this.HandleCancel.Size = new System.Drawing.Size(100, 35);
            this.HandleCancel.TabIndex = 5;
            this.HandleCancel.Text = "取消";
            this.HandleCancel.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HandleCancel.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.email.Location = new System.Drawing.Point(94, 54);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.MinimumSize = new System.Drawing.Size(1, 16);
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(5);
            this.email.ShowText = false;
            this.email.Size = new System.Drawing.Size(268, 29);
            this.email.TabIndex = 6;
            this.email.Text = "sutter.wu@itforce-tech.com";
            this.email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.email.Watermark = "";
            this.email.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(94, 113);
            this.password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password.MinimumSize = new System.Drawing.Size(1, 16);
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(5);
            this.password.PasswordChar = '*';
            this.password.ShowText = false;
            this.password.Size = new System.Drawing.Size(268, 29);
            this.password.TabIndex = 7;
            this.password.Text = "1234@Abcd";
            this.password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.password.Watermark = "";
            this.password.TextChanged += new System.EventHandler(this.uiTextBox2_TextChanged);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(36, 175);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "手机号";
            // 
            // phone
            // 
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.DoubleValue = 15770870823D;
            this.phone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.Location = new System.Drawing.Point(94, 168);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.MinimumSize = new System.Drawing.Size(1, 16);
            this.phone.Name = "phone";
            this.phone.Padding = new System.Windows.Forms.Padding(5);
            this.phone.ShowText = false;
            this.phone.Size = new System.Drawing.Size(191, 30);
            this.phone.TabIndex = 9;
            this.phone.Text = "15770870823";
            this.phone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.phone.Watermark = "";
            this.phone.TextChanged += new System.EventHandler(this.uiTextBox3_TextChanged);
            // 
            // SendVerify
            // 
            this.SendVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendVerify.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendVerify.Location = new System.Drawing.Point(292, 168);
            this.SendVerify.MinimumSize = new System.Drawing.Size(1, 1);
            this.SendVerify.Name = "SendVerify";
            this.SendVerify.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SendVerify.RectSelectedColor = System.Drawing.Color.Cyan;
            this.SendVerify.Size = new System.Drawing.Size(70, 30);
            this.SendVerify.TabIndex = 10;
            this.SendVerify.Text = "发送验证码";
            this.SendVerify.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 353);
            this.Controls.Add(this.SendVerify);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.HandleCancel);
            this.Controls.Add(this.HandleRegister);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton HandleRegister;
        private Sunny.UI.UIButton HandleCancel;
        private Sunny.UI.UITextBox email;
        private Sunny.UI.UITextBox password;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox phone;
        private Sunny.UI.UIButton SendVerify;
    }
}