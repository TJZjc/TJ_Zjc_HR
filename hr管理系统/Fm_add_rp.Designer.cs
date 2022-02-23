namespace hr管理系统
{
    partial class Fm_add_rp
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.txt_approver = new System.Windows.Forms.TextBox();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.rtxt_rp_type = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(187, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(140, 25);
            this.txt_id.TabIndex = 1;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入奖惩内容";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(453, 128);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(102, 140);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "发起奖惩时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "奖惩金额";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "奖惩批准人";
            // 
            // txt_money
            // 
            this.txt_money.Location = new System.Drawing.Point(187, 289);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(200, 25);
            this.txt_money.TabIndex = 9;
            this.txt_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_money_KeyPress);
            // 
            // txt_approver
            // 
            this.txt_approver.Location = new System.Drawing.Point(187, 350);
            this.txt_approver.Name = "txt_approver";
            this.txt_approver.Size = new System.Drawing.Size(200, 25);
            this.txt_approver.TabIndex = 10;
            this.txt_approver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_approver_KeyPress);
            // 
            // dtp_time
            // 
            this.dtp_time.Location = new System.Drawing.Point(187, 234);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(200, 25);
            this.dtp_time.TabIndex = 11;
            this.dtp_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_time_KeyPress);
            // 
            // rtxt_rp_type
            // 
            this.rtxt_rp_type.Location = new System.Drawing.Point(187, 99);
            this.rtxt_rp_type.Name = "rtxt_rp_type";
            this.rtxt_rp_type.Size = new System.Drawing.Size(234, 96);
            this.rtxt_rp_type.TabIndex = 12;
            this.rtxt_rp_type.Text = "";
            this.rtxt_rp_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxt_rp_type_KeyPress);
            // 
            // Fm_add_rp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(590, 411);
            this.Controls.Add(this.rtxt_rp_type);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.txt_approver);
            this.Controls.Add(this.txt_money);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Fm_add_rp";
            this.Text = "添加奖惩信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.TextBox txt_approver;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.RichTextBox rtxt_rp_type;
    }
}