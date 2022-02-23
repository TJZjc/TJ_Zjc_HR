namespace hr管理系统
{
    partial class Fm_salary_change
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.txt_work_type = new System.Windows.Forms.TextBox();
            this.txt_branch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_salary_new = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "部门";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "职务";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "当前工资";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(117, 45);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(146, 25);
            this.txt_id.TabIndex = 9;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(117, 91);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(146, 25);
            this.txt_name.TabIndex = 10;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(117, 248);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.ReadOnly = true;
            this.txt_salary.Size = new System.Drawing.Size(146, 25);
            this.txt_salary.TabIndex = 13;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(332, 75);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(70, 136);
            this.btn_change.TabIndex = 16;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_work_type
            // 
            this.txt_work_type.Location = new System.Drawing.Point(117, 193);
            this.txt_work_type.Name = "txt_work_type";
            this.txt_work_type.ReadOnly = true;
            this.txt_work_type.Size = new System.Drawing.Size(146, 25);
            this.txt_work_type.TabIndex = 18;
            // 
            // txt_branch
            // 
            this.txt_branch.Location = new System.Drawing.Point(117, 142);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.ReadOnly = true;
            this.txt_branch.Size = new System.Drawing.Size(146, 25);
            this.txt_branch.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "修改工资为";
            // 
            // txt_salary_new
            // 
            this.txt_salary_new.Location = new System.Drawing.Point(117, 294);
            this.txt_salary_new.Name = "txt_salary_new";
            this.txt_salary_new.Size = new System.Drawing.Size(146, 25);
            this.txt_salary_new.TabIndex = 21;
            // 
            // Fm_salary_change
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(437, 347);
            this.Controls.Add(this.txt_salary_new);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_branch);
            this.Controls.Add(this.txt_work_type);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Fm_salary_change";
            this.Text = "修改工资";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox txt_work_type;
        private System.Windows.Forms.TextBox txt_branch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_salary_new;
    }
}