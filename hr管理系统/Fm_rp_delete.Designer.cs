namespace hr管理系统
{
    partial class Fm_rp_delete
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要删除的奖惩记录的ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(330, 59);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(182, 25);
            this.txt_id.TabIndex = 1;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(217, 140);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 45);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Fm_rp_delete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(577, 236);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Fm_rp_delete";
            this.Text = "删除奖惩信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_delete;
    }
}