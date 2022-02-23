namespace hr管理系统
{
    partial class Fm_login
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
            this.lb_uid = new System.Windows.Forms.Label();
            this.lb_pwd = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_uid
            // 
            this.lb_uid.AutoSize = true;
            this.lb_uid.Location = new System.Drawing.Point(258, 250);
            this.lb_uid.Name = "lb_uid";
            this.lb_uid.Size = new System.Drawing.Size(37, 15);
            this.lb_uid.TabIndex = 1;
            this.lb_uid.Text = "账号";
            // 
            // lb_pwd
            // 
            this.lb_pwd.AutoSize = true;
            this.lb_pwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pwd.Location = new System.Drawing.Point(258, 298);
            this.lb_pwd.Name = "lb_pwd";
            this.lb_pwd.Size = new System.Drawing.Size(37, 15);
            this.lb_pwd.TabIndex = 2;
            this.lb_pwd.Text = "密码";
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(316, 247);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(208, 25);
            this.txt_uid.TabIndex = 3;
            this.txt_uid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_uid_KeyPress);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(316, 295);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(208, 25);
            this.txt_pwd.TabIndex = 4;
            this.txt_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pwd_KeyPress);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_register.Location = new System.Drawing.Point(187, 377);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(108, 35);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(525, 377);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(108, 35);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::hr管理系统.Properties.Resources.load3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Fm_login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.lb_pwd);
            this.Controls.Add(this.lb_uid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fm_login";
            this.Text = "登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fm_load_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_uid;
        private System.Windows.Forms.Label lb_pwd;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
    }
}