namespace JJB10Manager
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_connState = new System.Windows.Forms.Button();
            this.btn_Query = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_Query = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_qurey = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MacAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upTimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_check = new System.Windows.Forms.Button();
            this.dtp_timer = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_main = new System.Windows.Forms.GroupBox();
            this.gb_Conn = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_manager = new System.Windows.Forms.GroupBox();
            this.btn_parameter = new System.Windows.Forms.Button();
            this.btn_person = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_runLog = new System.Windows.Forms.ListBox();
            this.lab_1 = new System.Windows.Forms.Label();
            this.lab_2 = new System.Windows.Forms.Label();
            this.lab_3 = new System.Windows.Forms.Label();
            this.lab_4 = new System.Windows.Forms.Label();
            this.lab_appName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gb_Query.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qurey)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gb_Conn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gb_manager.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_main
            // 
            this.btn_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_main.Font = new System.Drawing.Font("宋体", 22F);
            this.btn_main.Location = new System.Drawing.Point(15, 130);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(195, 65);
            this.btn_main.TabIndex = 0;
            this.btn_main.Text = "首页";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_connState
            // 
            this.btn_connState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_connState.Font = new System.Drawing.Font("宋体", 22F);
            this.btn_connState.Location = new System.Drawing.Point(15, 246);
            this.btn_connState.Name = "btn_connState";
            this.btn_connState.Size = new System.Drawing.Size(195, 65);
            this.btn_connState.TabIndex = 0;
            this.btn_connState.Text = "连接状态";
            this.btn_connState.UseVisualStyleBackColor = true;
            this.btn_connState.Click += new System.EventHandler(this.btn_connState_Click);
            // 
            // btn_Query
            // 
            this.btn_Query.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Query.Font = new System.Drawing.Font("宋体", 22F);
            this.btn_Query.Location = new System.Drawing.Point(15, 353);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(195, 65);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "数据查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_set
            // 
            this.btn_set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_set.Font = new System.Drawing.Font("宋体", 22F);
            this.btn_set.Location = new System.Drawing.Point(15, 471);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(195, 65);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "配置管理";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gb_Query);
            this.panel1.Controls.Add(this.gb_main);
            this.panel1.Controls.Add(this.gb_Conn);
            this.panel1.Controls.Add(this.gb_manager);
            this.panel1.Location = new System.Drawing.Point(273, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 406);
            this.panel1.TabIndex = 3;
            // 
            // gb_Query
            // 
            this.gb_Query.Controls.Add(this.groupBox4);
            this.gb_Query.Controls.Add(this.groupBox3);
            this.gb_Query.Location = new System.Drawing.Point(11, 49);
            this.gb_Query.Name = "gb_Query";
            this.gb_Query.Size = new System.Drawing.Size(678, 237);
            this.gb_Query.TabIndex = 5;
            this.gb_Query.TabStop = false;
            this.gb_Query.Text = "数据查询";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_qurey);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(672, 161);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // dgv_qurey
            // 
            this.dgv_qurey.AllowUserToAddRows = false;
            this.dgv_qurey.AllowUserToDeleteRows = false;
            this.dgv_qurey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qurey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.MacAddress,
            this.wz,
            this.realValue,
            this.timer,
            this.upTimer});
            this.dgv_qurey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_qurey.Location = new System.Drawing.Point(3, 16);
            this.dgv_qurey.Name = "dgv_qurey";
            this.dgv_qurey.ReadOnly = true;
            this.dgv_qurey.RowHeadersVisible = false;
            this.dgv_qurey.RowTemplate.Height = 23;
            this.dgv_qurey.Size = new System.Drawing.Size(666, 142);
            this.dgv_qurey.TabIndex = 0;
            // 
            // index
            // 
            this.index.HeaderText = "序号";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 60;
            // 
            // MacAddress
            // 
            this.MacAddress.HeaderText = "MAC地址";
            this.MacAddress.Name = "MacAddress";
            this.MacAddress.ReadOnly = true;
            this.MacAddress.Width = 120;
            // 
            // wz
            // 
            this.wz.HeaderText = "采集地点";
            this.wz.Name = "wz";
            this.wz.ReadOnly = true;
            this.wz.Width = 150;
            // 
            // realValue
            // 
            this.realValue.HeaderText = "实时值";
            this.realValue.Name = "realValue";
            this.realValue.ReadOnly = true;
            this.realValue.Width = 70;
            // 
            // timer
            // 
            this.timer.HeaderText = "采集时间";
            this.timer.Name = "timer";
            this.timer.ReadOnly = true;
            this.timer.Width = 130;
            // 
            // upTimer
            // 
            this.upTimer.HeaderText = "上传时间";
            this.upTimer.Name = "upTimer";
            this.upTimer.ReadOnly = true;
            this.upTimer.Width = 130;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.btn_check);
            this.groupBox3.Controls.Add(this.dtp_timer);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 57);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(623, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "更多";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(214, 21);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(57, 25);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "查询";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // dtp_timer
            // 
            this.dtp_timer.Location = new System.Drawing.Point(76, 22);
            this.dtp_timer.Name = "dtp_timer";
            this.dtp_timer.Size = new System.Drawing.Size(122, 20);
            this.dtp_timer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "采集时间";
            // 
            // gb_main
            // 
            this.gb_main.BackgroundImage = global::JJB10Manager.Properties.Resources.BXY;
            this.gb_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_main.Location = new System.Drawing.Point(58, 103);
            this.gb_main.Name = "gb_main";
            this.gb_main.Size = new System.Drawing.Size(200, 108);
            this.gb_main.TabIndex = 0;
            this.gb_main.TabStop = false;
            // 
            // gb_Conn
            // 
            this.gb_Conn.Controls.Add(this.dgv);
            this.gb_Conn.Location = new System.Drawing.Point(354, 30);
            this.gb_Conn.Name = "gb_Conn";
            this.gb_Conn.Size = new System.Drawing.Size(595, 99);
            this.gb_Conn.TabIndex = 0;
            this.gb_Conn.TabStop = false;
            this.gb_Conn.Text = "当前连接设备信息";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.IP,
            this.Mac,
            this.操作});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(589, 80);
            this.dgv.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP地址";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Width = 150;
            // 
            // Mac
            // 
            this.Mac.HeaderText = "MAC地址";
            this.Mac.Name = "Mac";
            this.Mac.ReadOnly = true;
            this.Mac.Width = 200;
            // 
            // 操作
            // 
            this.操作.HeaderText = "doAction";
            this.操作.Name = "操作";
            this.操作.ReadOnly = true;
            this.操作.Width = 80;
            // 
            // gb_manager
            // 
            this.gb_manager.Controls.Add(this.btn_parameter);
            this.gb_manager.Controls.Add(this.btn_person);
            this.gb_manager.Location = new System.Drawing.Point(357, 147);
            this.gb_manager.Name = "gb_manager";
            this.gb_manager.Size = new System.Drawing.Size(424, 92);
            this.gb_manager.TabIndex = 4;
            this.gb_manager.TabStop = false;
            this.gb_manager.Text = "配置管理";
            // 
            // btn_parameter
            // 
            this.btn_parameter.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_parameter.Location = new System.Drawing.Point(174, 35);
            this.btn_parameter.Name = "btn_parameter";
            this.btn_parameter.Size = new System.Drawing.Size(101, 44);
            this.btn_parameter.TabIndex = 0;
            this.btn_parameter.Text = "参数管理";
            this.btn_parameter.UseVisualStyleBackColor = true;
            // 
            // btn_person
            // 
            this.btn_person.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_person.Location = new System.Drawing.Point(28, 35);
            this.btn_person.Name = "btn_person";
            this.btn_person.Size = new System.Drawing.Size(101, 44);
            this.btn_person.TabIndex = 0;
            this.btn_person.Text = "人员管理";
            this.btn_person.UseVisualStyleBackColor = true;
            this.btn_person.Click += new System.EventHandler(this.btn_person_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb_runLog);
            this.groupBox1.Location = new System.Drawing.Point(6, 570);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运行日志";
            // 
            // lb_runLog
            // 
            this.lb_runLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_runLog.FormattingEnabled = true;
            this.lb_runLog.Location = new System.Drawing.Point(3, 16);
            this.lb_runLog.Name = "lb_runLog";
            this.lb_runLog.Size = new System.Drawing.Size(965, 147);
            this.lb_runLog.TabIndex = 0;
            // 
            // lab_1
            // 
            this.lab_1.AutoSize = true;
            this.lab_1.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_1.Location = new System.Drawing.Point(212, 142);
            this.lab_1.Name = "lab_1";
            this.lab_1.Size = new System.Drawing.Size(59, 40);
            this.lab_1.TabIndex = 6;
            this.lab_1.Text = ">>";
            // 
            // lab_2
            // 
            this.lab_2.AutoSize = true;
            this.lab_2.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_2.Location = new System.Drawing.Point(212, 257);
            this.lab_2.Name = "lab_2";
            this.lab_2.Size = new System.Drawing.Size(59, 40);
            this.lab_2.TabIndex = 6;
            this.lab_2.Text = ">>";
            // 
            // lab_3
            // 
            this.lab_3.AutoSize = true;
            this.lab_3.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_3.Location = new System.Drawing.Point(212, 365);
            this.lab_3.Name = "lab_3";
            this.lab_3.Size = new System.Drawing.Size(59, 40);
            this.lab_3.TabIndex = 6;
            this.lab_3.Text = ">>";
            // 
            // lab_4
            // 
            this.lab_4.AutoSize = true;
            this.lab_4.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_4.Location = new System.Drawing.Point(212, 482);
            this.lab_4.Name = "lab_4";
            this.lab_4.Size = new System.Drawing.Size(59, 40);
            this.lab_4.TabIndex = 6;
            this.lab_4.Text = ">>";
            // 
            // lab_appName
            // 
            this.lab_appName.Font = new System.Drawing.Font("华文仿宋", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_appName.Location = new System.Drawing.Point(48, 10);
            this.lab_appName.Name = "lab_appName";
            this.lab_appName.Size = new System.Drawing.Size(884, 90);
            this.lab_appName.TabIndex = 7;
            this.lab_appName.Text = "label1";
            this.lab_appName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 741);
            this.Controls.Add(this.lab_appName);
            this.Controls.Add(this.lab_4);
            this.Controls.Add(this.lab_3);
            this.Controls.Add(this.lab_2);
            this.Controls.Add(this.lab_1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.btn_connState);
            this.Controls.Add(this.btn_main);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.gb_Query.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qurey)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_Conn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gb_manager.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_connState;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_Conn;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作;
        private System.Windows.Forms.Button btn_person;
        private System.Windows.Forms.Button btn_parameter;
        private System.Windows.Forms.GroupBox gb_manager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_main;
        private System.Windows.Forms.GroupBox gb_Query;
        private System.Windows.Forms.ListBox lb_runLog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.DateTimePicker dtp_timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_qurey;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn MacAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn wz;
        private System.Windows.Forms.DataGridViewTextBoxColumn realValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn upTimer;
        private System.Windows.Forms.Label lab_1;
        private System.Windows.Forms.Label lab_2;
        private System.Windows.Forms.Label lab_3;
        private System.Windows.Forms.Label lab_4;
        private System.Windows.Forms.Label lab_appName;
    }
}

