namespace hr管理系统
{
    partial class Fm_addresslist
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_email = new System.Windows.Forms.CheckBox();
            this.ckb_phone = new System.Windows.Forms.CheckBox();
            this.ckb_qq = new System.Windows.Forms.CheckBox();
            this.btn_search_id = new System.Windows.Forms.Button();
            this.btn_serach_name = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_result);
            this.groupBox2.Location = new System.Drawing.Point(12, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询结果";
            // 
            // dgv_result
            // 
            this.dgv_result.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_result.Location = new System.Drawing.Point(3, 21);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowHeadersWidth = 51;
            this.dgv_result.RowTemplate.Height = 27;
            this.dgv_result.Size = new System.Drawing.Size(530, 173);
            this.dgv_result.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 342);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "个人通讯录管理";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Location = new System.Drawing.Point(10, 237);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 87);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "更新";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(138, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 47);
            this.button6.TabIndex = 11;
            this.button6.Text = "个人通讯修改";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_email);
            this.groupBox1.Controls.Add(this.ckb_phone);
            this.groupBox1.Controls.Add(this.ckb_qq);
            this.groupBox1.Controls.Add(this.btn_search_id);
            this.groupBox1.Controls.Add(this.btn_serach_name);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // ckb_email
            // 
            this.ckb_email.AutoSize = true;
            this.ckb_email.Location = new System.Drawing.Point(250, 153);
            this.ckb_email.Name = "ckb_email";
            this.ckb_email.Size = new System.Drawing.Size(89, 19);
            this.ckb_email.TabIndex = 12;
            this.ckb_email.Text = "电子邮箱";
            this.ckb_email.UseVisualStyleBackColor = true;
            // 
            // ckb_phone
            // 
            this.ckb_phone.AutoSize = true;
            this.ckb_phone.Location = new System.Drawing.Point(142, 153);
            this.ckb_phone.Name = "ckb_phone";
            this.ckb_phone.Size = new System.Drawing.Size(59, 19);
            this.ckb_phone.TabIndex = 11;
            this.ckb_phone.Text = "电话";
            this.ckb_phone.UseVisualStyleBackColor = true;
            // 
            // ckb_qq
            // 
            this.ckb_qq.AutoSize = true;
            this.ckb_qq.Location = new System.Drawing.Point(33, 153);
            this.ckb_qq.Name = "ckb_qq";
            this.ckb_qq.Size = new System.Drawing.Size(45, 19);
            this.ckb_qq.TabIndex = 10;
            this.ckb_qq.Text = "QQ";
            this.ckb_qq.UseVisualStyleBackColor = true;
            // 
            // btn_search_id
            // 
            this.btn_search_id.Location = new System.Drawing.Point(300, 78);
            this.btn_search_id.Name = "btn_search_id";
            this.btn_search_id.Size = new System.Drawing.Size(75, 30);
            this.btn_search_id.TabIndex = 9;
            this.btn_search_id.Text = "id查询";
            this.btn_search_id.UseVisualStyleBackColor = true;
            this.btn_search_id.Click += new System.EventHandler(this.btn_search_id_Click);
            // 
            // btn_serach_name
            // 
            this.btn_serach_name.Location = new System.Drawing.Point(300, 24);
            this.btn_serach_name.Name = "btn_serach_name";
            this.btn_serach_name.Size = new System.Drawing.Size(75, 30);
            this.btn_serach_name.TabIndex = 8;
            this.btn_serach_name.Text = "姓名查询";
            this.btn_serach_name.UseVisualStyleBackColor = true;
            this.btn_serach_name.Click += new System.EventHandler(this.btn_serach_name_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(83, 29);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(185, 25);
            this.txt_name.TabIndex = 6;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(83, 78);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(185, 25);
            this.txt_id.TabIndex = 4;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(429, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 342);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "部分查询";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(22, 263);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 61);
            this.button9.TabIndex = 3;
            this.button9.Text = "全部信息查询";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(22, 186);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 61);
            this.button8.TabIndex = 2;
            this.button8.Text = "全部电子邮箱查询";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 61);
            this.button4.TabIndex = 1;
            this.button4.Text = "全部电话查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 61);
            this.button3.TabIndex = 0;
            this.button3.Text = "全部QQ查询";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Fm_addresslist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(572, 569);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Fm_addresslist";
            this.Text = "通讯录";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search_id;
        private System.Windows.Forms.Button btn_serach_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox ckb_email;
        private System.Windows.Forms.CheckBox ckb_phone;
        private System.Windows.Forms.CheckBox ckb_qq;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv_result;
    }
}