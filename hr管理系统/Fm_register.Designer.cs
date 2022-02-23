namespace hr管理系统
{
    partial class Fm_register
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_pwd_again = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(310, 68);
            this.txt_name.MaxLength = 100;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(228, 25);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(310, 147);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(238, 25);
            this.txt_pwd.TabIndex = 1;
            this.txt_pwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pwd_KeyPress);
            // 
            // txt_pwd_again
            // 
            this.txt_pwd_again.Location = new System.Drawing.Point(310, 229);
            this.txt_pwd_again.Name = "txt_pwd_again";
            this.txt_pwd_again.Size = new System.Drawing.Size(238, 25);
            this.txt_pwd_again.TabIndex = 2;
            this.txt_pwd_again.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pwd_again_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(170, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入你的账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(170, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "请输入你的密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(140, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "请再次输入你的密码";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(244, 333);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(121, 45);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // Fm_register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::hr管理系统.Properties.Resources.register;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pwd_again);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_name);
            this.Name = "Fm_register";
            this.Text = "Fm_register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_pwd_again;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_register;
    }
}