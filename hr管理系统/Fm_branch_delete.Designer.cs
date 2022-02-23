namespace hr管理系统
{
    partial class Fm_branch_delete
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
            this.cb_branch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_branch
            // 
            this.cb_branch.FormattingEnabled = true;
            this.cb_branch.Items.AddRange(new object[] {
            "财务部",
            "工程部",
            "人力资源部",
            "保洁部",
            "保安部",
            "科研部",
            "后勤部"});
            this.cb_branch.Location = new System.Drawing.Point(269, 45);
            this.cb_branch.Name = "cb_branch";
            this.cb_branch.Size = new System.Drawing.Size(214, 23);
            this.cb_branch.TabIndex = 0;
            this.cb_branch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_branch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择要删除的部门";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(215, 107);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(126, 53);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Fm_branch_delete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(585, 184);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_branch);
            this.Name = "Fm_branch_delete";
            this.Text = "删除部门";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_branch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
    }
}