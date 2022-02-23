namespace hr管理系统
{
    partial class Fm_worktype_change
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_worktype_new = new System.Windows.Forms.ComboBox();
            this.txt_branch = new System.Windows.Forms.TextBox();
            this.txt_worktype_now = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pb = new System.Windows.Forms.TextBox();
            this.txt_pe = new System.Windows.Forms.TextBox();
            this.txt_sex = new System.Windows.Forms.TextBox();
            this.txt_wb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "部门";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "当前职务";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(111, 94);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(100, 25);
            this.txt_name.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(111, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 25);
            this.txt_id.TabIndex = 8;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            this.txt_id.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 91);
            this.button3.TabIndex = 15;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "修改职务为";
            // 
            // cb_worktype_new
            // 
            this.cb_worktype_new.FormattingEnabled = true;
            this.cb_worktype_new.Items.AddRange(new object[] {
            "实习生",
            "正式工",
            "副总监",
            "总监",
            "副部长",
            "部长",
            "经理",
            "总经理",
            "董事会成员",
            "董事长"});
            this.cb_worktype_new.Location = new System.Drawing.Point(111, 352);
            this.cb_worktype_new.Name = "cb_worktype_new";
            this.cb_worktype_new.Size = new System.Drawing.Size(121, 23);
            this.cb_worktype_new.TabIndex = 18;
            // 
            // txt_branch
            // 
            this.txt_branch.Location = new System.Drawing.Point(310, 94);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.ReadOnly = true;
            this.txt_branch.Size = new System.Drawing.Size(100, 25);
            this.txt_branch.TabIndex = 19;
            // 
            // txt_worktype_now
            // 
            this.txt_worktype_now.Location = new System.Drawing.Point(111, 294);
            this.txt_worktype_now.Name = "txt_worktype_now";
            this.txt_worktype_now.ReadOnly = true;
            this.txt_worktype_now.Size = new System.Drawing.Size(139, 25);
            this.txt_worktype_now.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "性别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "合同开始时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "合同结束时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "工作开始时间";
            // 
            // txt_pb
            // 
            this.txt_pb.Location = new System.Drawing.Point(111, 160);
            this.txt_pb.Name = "txt_pb";
            this.txt_pb.ReadOnly = true;
            this.txt_pb.Size = new System.Drawing.Size(139, 25);
            this.txt_pb.TabIndex = 25;
            // 
            // txt_pe
            // 
            this.txt_pe.Location = new System.Drawing.Point(404, 160);
            this.txt_pe.Name = "txt_pe";
            this.txt_pe.ReadOnly = true;
            this.txt_pe.Size = new System.Drawing.Size(139, 25);
            this.txt_pe.TabIndex = 26;
            // 
            // txt_sex
            // 
            this.txt_sex.Location = new System.Drawing.Point(310, 32);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.ReadOnly = true;
            this.txt_sex.Size = new System.Drawing.Size(100, 25);
            this.txt_sex.TabIndex = 27;
            // 
            // txt_wb
            // 
            this.txt_wb.Location = new System.Drawing.Point(111, 225);
            this.txt_wb.Name = "txt_wb";
            this.txt_wb.ReadOnly = true;
            this.txt_wb.Size = new System.Drawing.Size(139, 25);
            this.txt_wb.TabIndex = 28;
            // 
            // Fm_worktype_change
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(578, 413);
            this.Controls.Add(this.txt_wb);
            this.Controls.Add(this.txt_sex);
            this.Controls.Add(this.txt_pe);
            this.Controls.Add(this.txt_pb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_worktype_now);
            this.Controls.Add(this.txt_branch);
            this.Controls.Add(this.cb_worktype_new);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Fm_worktype_change";
            this.Text = "修改职务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_worktype_new;
        private System.Windows.Forms.TextBox txt_branch;
        private System.Windows.Forms.TextBox txt_worktype_now;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pb;
        private System.Windows.Forms.TextBox txt_pe;
        private System.Windows.Forms.TextBox txt_sex;
        private System.Windows.Forms.TextBox txt_wb;
    }
}