namespace hr管理系统
{
    partial class Fm_salary
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cb_salary = new System.Windows.Forms.ComboBox();
            this.btn_search_total = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search_partial = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_change_person = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search_by_name = new System.Windows.Forms.Button();
            this.btn_search_by_id = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工资管理";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(432, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(480, 299);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "整体工资管理";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btn_change);
            this.groupBox8.Location = new System.Drawing.Point(6, 184);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(467, 105);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "更新";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(175, 25);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(108, 64);
            this.btn_change.TabIndex = 13;
            this.btn_change.Text = "相同工资修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cb_salary);
            this.groupBox7.Controls.Add(this.btn_search_total);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.btn_search_partial);
            this.groupBox7.Location = new System.Drawing.Point(6, 24);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(468, 142);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "查询";
            // 
            // cb_salary
            // 
            this.cb_salary.FormattingEnabled = true;
            this.cb_salary.Location = new System.Drawing.Point(63, 35);
            this.cb_salary.Name = "cb_salary";
            this.cb_salary.Size = new System.Drawing.Size(220, 23);
            this.cb_salary.TabIndex = 10;
            // 
            // btn_search_total
            // 
            this.btn_search_total.Location = new System.Drawing.Point(275, 86);
            this.btn_search_total.Name = "btn_search_total";
            this.btn_search_total.Size = new System.Drawing.Size(134, 30);
            this.btn_search_total.TabIndex = 9;
            this.btn_search_total.Text = "全部工资查询";
            this.btn_search_total.UseVisualStyleBackColor = true;
            this.btn_search_total.Click += new System.EventHandler(this.btn_search_total_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "工资";
            // 
            // btn_search_partial
            // 
            this.btn_search_partial.Location = new System.Drawing.Point(63, 87);
            this.btn_search_partial.Name = "btn_search_partial";
            this.btn_search_partial.Size = new System.Drawing.Size(134, 30);
            this.btn_search_partial.TabIndex = 8;
            this.btn_search_partial.Text = "资金查询";
            this.btn_search_partial.UseVisualStyleBackColor = true;
            this.btn_search_partial.Click += new System.EventHandler(this.btn_search_partial_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(16, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 300);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "个人工资管理";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_change_person);
            this.groupBox5.Location = new System.Drawing.Point(13, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 118);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "更新";
            // 
            // btn_change_person
            // 
            this.btn_change_person.Location = new System.Drawing.Point(134, 46);
            this.btn_change_person.Name = "btn_change_person";
            this.btn_change_person.Size = new System.Drawing.Size(89, 47);
            this.btn_change_person.TabIndex = 11;
            this.btn_change_person.Text = "个人工资修改";
            this.btn_change_person.UseVisualStyleBackColor = true;
            this.btn_change_person.Click += new System.EventHandler(this.btn_change_person_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btn_search_by_name);
            this.groupBox4.Controls.Add(this.btn_search_by_id);
            this.groupBox4.Controls.Add(this.txt_id);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_name);
            this.groupBox4.Location = new System.Drawing.Point(13, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 142);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // btn_search_by_name
            // 
            this.btn_search_by_name.Location = new System.Drawing.Point(263, 38);
            this.btn_search_by_name.Name = "btn_search_by_name";
            this.btn_search_by_name.Size = new System.Drawing.Size(75, 30);
            this.btn_search_by_name.TabIndex = 7;
            this.btn_search_by_name.Text = "姓名查询";
            this.btn_search_by_name.UseVisualStyleBackColor = true;
            this.btn_search_by_name.Click += new System.EventHandler(this.btn_search_by_name_Click);
            // 
            // btn_search_by_id
            // 
            this.btn_search_by_id.Location = new System.Drawing.Point(263, 78);
            this.btn_search_by_id.Name = "btn_search_by_id";
            this.btn_search_by_id.Size = new System.Drawing.Size(75, 30);
            this.btn_search_by_id.TabIndex = 6;
            this.btn_search_by_id.Text = "id查询";
            this.btn_search_by_id.UseVisualStyleBackColor = true;
            this.btn_search_by_id.Click += new System.EventHandler(this.btn_search_by_id_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(68, 78);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(185, 25);
            this.txt_id.TabIndex = 5;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(68, 38);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(185, 25);
            this.txt_name.TabIndex = 3;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_result);
            this.groupBox2.Location = new System.Drawing.Point(12, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 284);
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
            this.dgv_result.Size = new System.Drawing.Size(912, 260);
            this.dgv_result.TabIndex = 0;
            // 
            // Fm_salary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(942, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fm_salary";
            this.Text = "工资管理";
            this.Load += new System.EventHandler(this.Fm_salary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search_total;
        private System.Windows.Forms.Button btn_search_partial;
        private System.Windows.Forms.Button btn_search_by_name;
        private System.Windows.Forms.Button btn_search_by_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_change_person;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_salary;
        private System.Windows.Forms.DataGridView dgv_result;
    }
}