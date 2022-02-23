namespace hr管理系统
{
    partial class Fm_branch_change
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_branch_now = new System.Windows.Forms.TextBox();
            this.cb_branch_change = new System.Windows.Forms.ComboBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入员工ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "当前所在部门";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "请选择将要转入的部门";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(201, 34);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 25);
            this.txt_id.TabIndex = 4;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(201, 114);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(181, 25);
            this.txt_name.TabIndex = 5;
            // 
            // txt_branch_now
            // 
            this.txt_branch_now.Location = new System.Drawing.Point(201, 167);
            this.txt_branch_now.Name = "txt_branch_now";
            this.txt_branch_now.ReadOnly = true;
            this.txt_branch_now.Size = new System.Drawing.Size(181, 25);
            this.txt_branch_now.TabIndex = 6;
            // 
            // cb_branch_change
            // 
            this.cb_branch_change.FormattingEnabled = true;
            this.cb_branch_change.Items.AddRange(new object[] {
            "财务部",
            "工程部",
            "人力资源部",
            "保洁部",
            "保安部",
            "科研部",
            "后勤部"});
            this.cb_branch_change.Location = new System.Drawing.Point(201, 219);
            this.cb_branch_change.Name = "cb_branch_change";
            this.cb_branch_change.Size = new System.Drawing.Size(181, 23);
            this.cb_branch_change.TabIndex = 7;
            this.cb_branch_change.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_branch_change_KeyPress);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(467, 76);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(74, 97);
            this.btn_change.TabIndex = 8;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // Fm_branch_change
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(572, 280);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.cb_branch_change);
            this.Controls.Add(this.txt_branch_now);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fm_branch_change";
            this.Text = "修改部门";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_branch_now;
        private System.Windows.Forms.ComboBox cb_branch_change;
        private System.Windows.Forms.Button btn_change;
    }
}