namespace hr管理系统
{
    partial class Fm_add_addresslist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_qq = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入要修改的id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "QQ号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "电话";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "电子邮箱";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(170, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 25);
            this.txt_id.TabIndex = 6;
            this.txt_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(170, 90);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(100, 25);
            this.txt_name.TabIndex = 7;
            // 
            // txt_qq
            // 
            this.txt_qq.Location = new System.Drawing.Point(170, 138);
            this.txt_qq.Name = "txt_qq";
            this.txt_qq.Size = new System.Drawing.Size(176, 25);
            this.txt_qq.TabIndex = 8;
            this.txt_qq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qq_KeyPress);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(170, 191);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(176, 25);
            this.txt_phone.TabIndex = 9;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(170, 240);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(176, 25);
            this.txt_email.TabIndex = 10;
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(389, 73);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(69, 106);
            this.btn_change.TabIndex = 14;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // Fm_add_addresslist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(543, 321);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_qq);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fm_add_addresslist";
            this.Text = "添加通讯录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_qq;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_change;
    }
}