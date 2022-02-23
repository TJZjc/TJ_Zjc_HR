namespace hr管理系统
{
    partial class Fm_set_user
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_newpwd = new System.Windows.Forms.TextBox();
            this.txt_new_pwd_again = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::hr管理系统.Properties.Resources.set_user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "更改密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "再次输入更改密码";
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(409, 98);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.ReadOnly = true;
            this.txt_uid.Size = new System.Drawing.Size(160, 25);
            this.txt_uid.TabIndex = 4;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(409, 180);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.ReadOnly = true;
            this.txt_pwd.Size = new System.Drawing.Size(160, 25);
            this.txt_pwd.TabIndex = 5;
            // 
            // txt_newpwd
            // 
            this.txt_newpwd.Location = new System.Drawing.Point(409, 268);
            this.txt_newpwd.Name = "txt_newpwd";
            this.txt_newpwd.Size = new System.Drawing.Size(160, 25);
            this.txt_newpwd.TabIndex = 0;
            this.txt_newpwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_newpwd_KeyPress);
            // 
            // txt_new_pwd_again
            // 
            this.txt_new_pwd_again.Location = new System.Drawing.Point(409, 359);
            this.txt_new_pwd_again.Name = "txt_new_pwd_again";
            this.txt_new_pwd_again.Size = new System.Drawing.Size(160, 25);
            this.txt_new_pwd_again.TabIndex = 1;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(663, 337);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(94, 37);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(663, 399);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(94, 37);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Fm_set_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txt_new_pwd_again);
            this.Controls.Add(this.txt_newpwd);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fm_set_user";
            this.Text = "用户设置";
            this.Load += new System.EventHandler(this.Fm_set_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_newpwd;
        private System.Windows.Forms.TextBox txt_new_pwd_again;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_cancel;
    }
}