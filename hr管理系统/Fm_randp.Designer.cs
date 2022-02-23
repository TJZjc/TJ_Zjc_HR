namespace hr管理系统
{
    partial class Fm_randp
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
            this.dgv_total = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_id = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_total)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_total);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 269);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全部奖惩记录";
            // 
            // dgv_total
            // 
            this.dgv_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_total.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_total.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_total.Location = new System.Drawing.Point(3, 21);
            this.dgv_total.Name = "dgv_total";
            this.dgv_total.RowHeadersWidth = 51;
            this.dgv_total.RowTemplate.Height = 27;
            this.dgv_total.Size = new System.Drawing.Size(555, 245);
            this.dgv_total.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_result);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_id);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 287);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "个人奖惩";
            // 
            // dgv_result
            // 
            this.dgv_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_result.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(6, 173);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowHeadersWidth = 51;
            this.dgv_result.RowTemplate.Height = 27;
            this.dgv_result.Size = new System.Drawing.Size(552, 108);
            this.dgv_result.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(30, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "查询结果";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(366, 101);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 54);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(220, 101);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(99, 54);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_id
            // 
            this.btn_id.Location = new System.Drawing.Point(350, 19);
            this.btn_id.Name = "btn_id";
            this.btn_id.Size = new System.Drawing.Size(115, 48);
            this.btn_id.TabIndex = 2;
            this.btn_id.Text = "id查询";
            this.btn_id.UseVisualStyleBackColor = true;
            this.btn_id.Click += new System.EventHandler(this.btn_id_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(33, 33);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(286, 25);
            this.txt_id.TabIndex = 0;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // Fm_randp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fm_randp";
            this.Text = "奖惩管理";
            this.Load += new System.EventHandler(this.Fm_randp_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_total)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.DataGridView dgv_total;
    }
}