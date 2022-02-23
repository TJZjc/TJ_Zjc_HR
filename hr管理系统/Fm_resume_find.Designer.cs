namespace hr管理系统
{
    partial class Fm_resume_find
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_id = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(137, 81);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(314, 25);
            this.txt_id.TabIndex = 0;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // btn_id
            // 
            this.btn_id.Location = new System.Drawing.Point(523, 63);
            this.btn_id.Name = "btn_id";
            this.btn_id.Size = new System.Drawing.Size(116, 57);
            this.btn_id.TabIndex = 2;
            this.btn_id.Text = "id查询";
            this.btn_id.UseVisualStyleBackColor = true;
            this.btn_id.Click += new System.EventHandler(this.btn_id_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "id";
            // 
            // Fm_resume_find
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(692, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_id);
            this.Controls.Add(this.txt_id);
            this.Name = "Fm_resume_find";
            this.Text = "查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_id;
        private System.Windows.Forms.Label label1;
    }
}