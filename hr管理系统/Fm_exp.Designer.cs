namespace hr管理系统
{
    partial class Fm_exp
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
            this.txt_exp = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_exp
            // 
            this.txt_exp.Location = new System.Drawing.Point(12, 12);
            this.txt_exp.Multiline = true;
            this.txt_exp.Name = "txt_exp";
            this.txt_exp.Size = new System.Drawing.Size(776, 283);
            this.txt_exp.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(327, 327);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(145, 72);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "完成";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Fm_exp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_exp);
            this.Name = "Fm_exp";
            this.Text = "设置简历说明";
            this.Load += new System.EventHandler(this.Fm_exp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_exp;
        private System.Windows.Forms.Button btn_ok;
    }
}