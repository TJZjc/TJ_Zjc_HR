namespace hr管理系统
{
    partial class Fm_hr_manegment
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::hr管理系统.Properties.Resources.management1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1144, 705);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_insert.Location = new System.Drawing.Point(486, 138);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(149, 71);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "插入信息";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_change.Location = new System.Drawing.Point(486, 255);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(149, 71);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "修改信息";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_delete.Location = new System.Drawing.Point(486, 367);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(149, 71);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "删除信息";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Fm_hr_manegment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1144, 705);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fm_hr_manegment";
            this.Text = "人事资料管理";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_delete;
    }
}