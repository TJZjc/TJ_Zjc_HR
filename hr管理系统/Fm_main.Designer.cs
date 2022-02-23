namespace hr管理系统
{
    partial class Fm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basic_information = new System.Windows.Forms.ToolStripMenuItem();
            this.e = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.human_information = new System.Windows.Forms.ToolStripMenuItem();
            this.人事简历资料 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.system_operation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_change = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_find = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_addresslist = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_re_login = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_exit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_lab_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_change_time = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basic_information,
            this.human_information,
            this.system_operation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basic_information
            // 
            this.basic_information.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.e,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.通讯录ToolStripMenuItem});
            this.basic_information.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.basic_information.Name = "basic_information";
            this.basic_information.Size = new System.Drawing.Size(126, 27);
            this.basic_information.Text = "基础信息管理";
            // 
            // e
            // 
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(196, 28);
            this.e.Text = "部门信息管理";
            this.e.Click += new System.EventHandler(this.e_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(196, 28);
            this.toolStripMenuItem5.Text = "奖惩管理";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(196, 28);
            this.toolStripMenuItem6.Text = "工资管理";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(196, 28);
            this.toolStripMenuItem7.Text = "职务管理";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // 通讯录ToolStripMenuItem
            // 
            this.通讯录ToolStripMenuItem.Name = "通讯录ToolStripMenuItem";
            this.通讯录ToolStripMenuItem.Size = new System.Drawing.Size(196, 28);
            this.通讯录ToolStripMenuItem.Text = "通讯录";
            this.通讯录ToolStripMenuItem.Click += new System.EventHandler(this.通讯录ToolStripMenuItem_Click);
            // 
            // human_information
            // 
            this.human_information.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人事简历资料,
            this.toolStripMenuItem8});
            this.human_information.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.human_information.Name = "human_information";
            this.human_information.Size = new System.Drawing.Size(126, 27);
            this.human_information.Text = "人事信息管理";
            // 
            // 人事简历资料
            // 
            this.人事简历资料.Name = "人事简历资料";
            this.人事简历资料.Size = new System.Drawing.Size(196, 28);
            this.人事简历资料.Text = "人事简历资料";
            this.人事简历资料.Click += new System.EventHandler(this.人事简历资料_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(196, 28);
            this.toolStripMenuItem8.Text = "人事资料管理";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // system_operation
            // 
            this.system_operation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.system_operation.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.system_operation.Name = "system_operation";
            this.system_operation.Size = new System.Drawing.Size(92, 27);
            this.system_operation.Text = "系统管理";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(224, 28);
            this.toolStripMenuItem12.Text = "重新登录";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(224, 28);
            this.toolStripMenuItem13.Text = "用户设置";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(224, 28);
            this.toolStripMenuItem14.Text = "退出系统";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_change,
            this.toolStripSeparator1,
            this.btn_find,
            this.toolStripSeparator2,
            this.btn_addresslist,
            this.toolStripSeparator3,
            this.btn_re_login,
            this.toolStripSeparator4,
            this.btn_exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 30);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btn_change.Image = global::hr管理系统.Properties.Resources.查询;
            this.btn_change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(136, 27);
            this.btn_change.Text = "人事档案管理";
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btn_find.Image = global::hr管理系统.Properties.Resources.find;
            this.btn_find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(136, 27);
            this.btn_find.Text = "人事资料查询";
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // btn_addresslist
            // 
            this.btn_addresslist.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btn_addresslist.Image = global::hr管理系统.Properties.Resources.addlist;
            this.btn_addresslist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addresslist.Name = "btn_addresslist";
            this.btn_addresslist.Size = new System.Drawing.Size(85, 27);
            this.btn_addresslist.Text = "通讯录";
            this.btn_addresslist.Click += new System.EventHandler(this.btn_addresslist_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // btn_re_login
            // 
            this.btn_re_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btn_re_login.Image = global::hr管理系统.Properties.Resources.rein;
            this.btn_re_login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_re_login.Name = "btn_re_login";
            this.btn_re_login.Size = new System.Drawing.Size(102, 27);
            this.btn_re_login.Text = "重新登录";
            this.btn_re_login.Click += new System.EventHandler(this.btn_re_login_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.btn_exit.Image = global::hr管理系统.Properties.Resources.exit;
            this.btn_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(102, 27);
            this.btn_exit.Text = "退出系统";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.status_lab_time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 20);
            this.toolStripStatusLabel1.Text = "当前时间:";
            // 
            // status_lab_time
            // 
            this.status_lab_time.Name = "status_lab_time";
            this.status_lab_time.Size = new System.Drawing.Size(13, 20);
            this.status_lab_time.Text = " ";
            // 
            // timer_change_time
            // 
            this.timer_change_time.Interval = 500;
            this.timer_change_time.Tick += new System.EventHandler(this.timer_change_time_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hr管理系统.Properties.Resources.main_6_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 572);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Fm_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1028, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fm_main";
            this.Text = "人事管理系统";
            this.Load += new System.EventHandler(this.Fm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basic_information;
        private System.Windows.Forms.ToolStripMenuItem e;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem human_information;
        private System.Windows.Forms.ToolStripMenuItem 人事简历资料;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem system_operation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_change;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_find;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_addresslist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_re_login;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel status_lab_time;
        private System.Windows.Forms.Timer timer_change_time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 通讯录ToolStripMenuItem;
    }
}

