namespace hr管理系统
{
    partial class Fm_salary_change_partcial
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
            this.cb_salary_now = new System.Windows.Forms.ComboBox();
            this.txt_salary_new = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择要修改的工资额度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "将额度修改为";
            // 
            // cb_salary_now
            // 
            this.cb_salary_now.FormattingEnabled = true;
            this.cb_salary_now.Location = new System.Drawing.Point(201, 40);
            this.cb_salary_now.Name = "cb_salary_now";
            this.cb_salary_now.Size = new System.Drawing.Size(121, 23);
            this.cb_salary_now.TabIndex = 2;
            // 
            // txt_salary_new
            // 
            this.txt_salary_new.Location = new System.Drawing.Point(199, 113);
            this.txt_salary_new.Name = "txt_salary_new";
            this.txt_salary_new.Size = new System.Drawing.Size(162, 25);
            this.txt_salary_new.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(423, 43);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(111, 73);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Fm_salary_change_partcial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(566, 198);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_salary_new);
            this.Controls.Add(this.cb_salary_now);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fm_salary_change_partcial";
            this.Text = "修改工资";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_salary_now;
        private System.Windows.Forms.TextBox txt_salary_new;
        private System.Windows.Forms.Button btn_ok;
    }
}