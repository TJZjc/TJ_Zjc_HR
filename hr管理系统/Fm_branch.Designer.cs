namespace hr管理系统
{
    partial class Fm_branch
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
            this.cb_branch = new System.Windows.Forms.ComboBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_infor = new System.Windows.Forms.DataGridView();
            this.btn_delete_branch = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_infor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(89, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门";
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
            this.cb_branch.Location = new System.Drawing.Point(162, 53);
            this.cb_branch.Name = "cb_branch";
            this.cb_branch.Size = new System.Drawing.Size(121, 23);
            this.cb_branch.TabIndex = 1;
            this.cb_branch.MouseLeave += new System.EventHandler(this.cb_branch_MouseLeave);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(400, 40);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(142, 60);
            this.btn_change.TabIndex = 4;
            this.btn_change.Text = "修改个人信息";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(574, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(142, 60);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "查询个人信息";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_infor);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 327);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "部门信息";
            // 
            // dgv_infor
            // 
            this.dgv_infor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_infor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_infor.Location = new System.Drawing.Point(6, 24);
            this.dgv_infor.Name = "dgv_infor";
            this.dgv_infor.RowHeadersWidth = 51;
            this.dgv_infor.RowTemplate.Height = 27;
            this.dgv_infor.Size = new System.Drawing.Size(938, 297);
            this.dgv_infor.TabIndex = 0;
            // 
            // btn_delete_branch
            // 
            this.btn_delete_branch.Location = new System.Drawing.Point(738, 128);
            this.btn_delete_branch.Name = "btn_delete_branch";
            this.btn_delete_branch.Size = new System.Drawing.Size(142, 60);
            this.btn_delete_branch.TabIndex = 8;
            this.btn_delete_branch.Text = "删除部门信息";
            this.btn_delete_branch.UseVisualStyleBackColor = true;
            this.btn_delete_branch.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(738, 40);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(142, 60);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "删除个人信息";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Fm_branch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(945, 529);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_delete_branch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.cb_branch);
            this.Controls.Add(this.label1);
            this.Name = "Fm_branch";
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.Fm_branch_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_infor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_branch;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete_branch;
        private System.Windows.Forms.DataGridView dgv_infor;
        private System.Windows.Forms.Button btn_delete;
    }
}