namespace hr管理系统
{
    partial class Fm_worktype_partcial_change
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
            this.cb_worktype_now = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_worktype_new = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择要修改的职务";
            // 
            // cb_worktype_now
            // 
            this.cb_worktype_now.FormattingEnabled = true;
            this.cb_worktype_now.Items.AddRange(new object[] {
            "实习生",
            "正式工",
            "副总监",
            "总监",
            "副部长",
            "部长",
            "经理",
            "总经理",
            "董事会成员",
            "董事长"});
            this.cb_worktype_now.Location = new System.Drawing.Point(219, 49);
            this.cb_worktype_now.Name = "cb_worktype_now";
            this.cb_worktype_now.Size = new System.Drawing.Size(121, 23);
            this.cb_worktype_now.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "将职务修改为";
            // 
            // txt_worktype_new
            // 
            this.txt_worktype_new.Location = new System.Drawing.Point(219, 118);
            this.txt_worktype_new.Name = "txt_worktype_new";
            this.txt_worktype_new.Size = new System.Drawing.Size(177, 25);
            this.txt_worktype_new.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fm_worktype_partcial_change
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(652, 216);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_worktype_new);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_worktype_now);
            this.Controls.Add(this.label1);
            this.Name = "Fm_worktype_partcial_change";
            this.Text = "修改职务";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_worktype_now;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_worktype_new;
        private System.Windows.Forms.Button button1;
    }
}