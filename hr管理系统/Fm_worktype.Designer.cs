namespace hr管理系统
{
    partial class Fm_worktype
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
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_id = new System.Windows.Forms.Button();
            this.btn_name = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_change_worktype = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_search_worktype = new System.Windows.Forms.Button();
            this.cb_worktype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_result);
            this.groupBox1.Location = new System.Drawing.Point(12, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询结果";
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
            this.dgv_result.Size = new System.Drawing.Size(855, 204);
            this.dgv_result.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "个人职务管理";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Location = new System.Drawing.Point(6, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 87);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "更新";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(141, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 47);
            this.button6.TabIndex = 11;
            this.button6.Text = "个人职务修改";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_id);
            this.groupBox3.Controls.Add(this.btn_name);
            this.groupBox3.Controls.Add(this.txt_name);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 119);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询";
            // 
            // btn_id
            // 
            this.btn_id.Location = new System.Drawing.Point(300, 78);
            this.btn_id.Name = "btn_id";
            this.btn_id.Size = new System.Drawing.Size(75, 30);
            this.btn_id.TabIndex = 9;
            this.btn_id.Text = "id查询";
            this.btn_id.UseVisualStyleBackColor = true;
            this.btn_id.Click += new System.EventHandler(this.btn_id_Click);
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(300, 24);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(75, 30);
            this.btn_name.TabIndex = 8;
            this.btn_name.Text = "姓名查询";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
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
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(452, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 252);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "整体职务管理";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_change_worktype);
            this.groupBox7.Location = new System.Drawing.Point(6, 146);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(408, 100);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "更新";
            // 
            // btn_change_worktype
            // 
            this.btn_change_worktype.Location = new System.Drawing.Point(139, 28);
            this.btn_change_worktype.Name = "btn_change_worktype";
            this.btn_change_worktype.Size = new System.Drawing.Size(108, 64);
            this.btn_change_worktype.TabIndex = 14;
            this.btn_change_worktype.Text = "相同职务修改";
            this.btn_change_worktype.UseVisualStyleBackColor = true;
            this.btn_change_worktype.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.btn_search_worktype);
            this.groupBox6.Controls.Add(this.cb_worktype);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(6, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(408, 108);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "查询";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(237, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "全部职务查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_search_worktype
            // 
            this.btn_search_worktype.Location = new System.Drawing.Point(77, 65);
            this.btn_search_worktype.Name = "btn_search_worktype";
            this.btn_search_worktype.Size = new System.Drawing.Size(134, 30);
            this.btn_search_worktype.TabIndex = 9;
            this.btn_search_worktype.Text = "职务查询";
            this.btn_search_worktype.UseVisualStyleBackColor = true;
            this.btn_search_worktype.Click += new System.EventHandler(this.btn_search_worktype_Click);
            // 
            // cb_worktype
            // 
            this.cb_worktype.FormattingEnabled = true;
            this.cb_worktype.Items.AddRange(new object[] {
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
            this.cb_worktype.Location = new System.Drawing.Point(77, 29);
            this.cb_worktype.Name = "cb_worktype";
            this.cb_worktype.Size = new System.Drawing.Size(170, 23);
            this.cb_worktype.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "职务";
            // 
            // Fm_worktype
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(885, 511);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fm_worktype";
            this.Text = "职务管理";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Button btn_id;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cb_worktype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search_worktype;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_change_worktype;
        private System.Windows.Forms.DataGridView dgv_result;
    }
}