namespace SaaS
{
    partial class Owner_Management
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Owner_Management));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ownername = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cha = new System.Windows.Forms.Button();
            this.btn_xiu = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ldname_cbb = new System.Windows.Forms.ComboBox();
            this.xqname_cbb = new System.Windows.Forms.ComboBox();
            this.dgv_Owner = new System.Windows.Forms.DataGridView();
            this.Vlage_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_proportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stay_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.shenfen_tb = new System.Windows.Forms.TextBox();
            this.yename_tb = new System.Windows.Forms.TextBox();
            this.room_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_sex = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.proportion_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_MX = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Owner)).BeginInit();
            this.CMS_delete.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ownername);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_cha);
            this.groupBox1.Location = new System.Drawing.Point(374, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(264, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找信息";
            // 
            // ownername
            // 
            this.ownername.Location = new System.Drawing.Point(55, 21);
            this.ownername.Margin = new System.Windows.Forms.Padding(2);
            this.ownername.Name = "ownername";
            this.ownername.Size = new System.Drawing.Size(108, 21);
            this.ownername.TabIndex = 1;
            this.ownername.WatermarkText = "业主姓名或房间号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "查询：";
            // 
            // btn_cha
            // 
            this.btn_cha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_cha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cha.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cha.ForeColor = System.Drawing.Color.White;
            this.btn_cha.Location = new System.Drawing.Point(169, 17);
            this.btn_cha.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cha.Name = "btn_cha";
            this.btn_cha.Size = new System.Drawing.Size(81, 25);
            this.btn_cha.TabIndex = 2;
            this.btn_cha.Text = "查询";
            this.btn_cha.UseVisualStyleBackColor = false;
            this.btn_cha.Click += new System.EventHandler(this.btn_cha_Click);
            // 
            // btn_xiu
            // 
            this.btn_xiu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_xiu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xiu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_xiu.ForeColor = System.Drawing.Color.White;
            this.btn_xiu.Location = new System.Drawing.Point(18, 17);
            this.btn_xiu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xiu.Name = "btn_xiu";
            this.btn_xiu.Size = new System.Drawing.Size(60, 25);
            this.btn_xiu.TabIndex = 1;
            this.btn_xiu.Text = "修改";
            this.btn_xiu.UseVisualStyleBackColor = false;
            this.btn_xiu.Click += new System.EventHandler(this.btn_xiu_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(91, 18);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(60, 25);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ldname_cbb
            // 
            this.ldname_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ldname_cbb.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ldname_cbb.FormattingEnabled = true;
            this.ldname_cbb.Location = new System.Drawing.Point(187, 34);
            this.ldname_cbb.Margin = new System.Windows.Forms.Padding(2);
            this.ldname_cbb.Name = "ldname_cbb";
            this.ldname_cbb.Size = new System.Drawing.Size(70, 25);
            this.ldname_cbb.TabIndex = 2;
            // 
            // xqname_cbb
            // 
            this.xqname_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xqname_cbb.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.xqname_cbb.FormattingEnabled = true;
            this.xqname_cbb.Location = new System.Drawing.Point(58, 34);
            this.xqname_cbb.Margin = new System.Windows.Forms.Padding(2);
            this.xqname_cbb.Name = "xqname_cbb";
            this.xqname_cbb.Size = new System.Drawing.Size(70, 25);
            this.xqname_cbb.TabIndex = 1;
            // 
            // dgv_Owner
            // 
            this.dgv_Owner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Owner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Owner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Owner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Owner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vlage_name,
            this.building_name,
            this.owner_name,
            this.col_sex,
            this.room_num,
            this.col_proportion,
            this.owner_tel,
            this.owner_card,
            this.col_stay_time,
            this.owner_number});
            this.dgv_Owner.ContextMenuStrip = this.CMS_delete;
            this.dgv_Owner.Location = new System.Drawing.Point(31, 79);
            this.dgv_Owner.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_Owner.Name = "dgv_Owner";
            this.dgv_Owner.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Owner.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(238)))));
            this.dgv_Owner.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Owner.RowTemplate.Height = 27;
            this.dgv_Owner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Owner.Size = new System.Drawing.Size(607, 162);
            this.dgv_Owner.TabIndex = 28;
            this.dgv_Owner.TabStop = false;
            this.dgv_Owner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Owner_CellContentClick);
            this.dgv_Owner.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Owner_CellMouseClick);
            // 
            // Vlage_name
            // 
            this.Vlage_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Vlage_name.DataPropertyName = "Village_name";
            this.Vlage_name.HeaderText = "小区名";
            this.Vlage_name.Name = "Vlage_name";
            this.Vlage_name.ReadOnly = true;
            this.Vlage_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Vlage_name.Width = 47;
            // 
            // building_name
            // 
            this.building_name.DataPropertyName = "Building_name";
            this.building_name.HeaderText = "楼栋名";
            this.building_name.Name = "building_name";
            this.building_name.ReadOnly = true;
            this.building_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // owner_name
            // 
            this.owner_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.owner_name.DataPropertyName = "owner_name";
            this.owner_name.HeaderText = "业主姓名";
            this.owner_name.Name = "owner_name";
            this.owner_name.ReadOnly = true;
            this.owner_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.owner_name.Width = 42;
            // 
            // col_sex
            // 
            this.col_sex.DataPropertyName = "sex";
            this.col_sex.HeaderText = "性别";
            this.col_sex.Name = "col_sex";
            this.col_sex.ReadOnly = true;
            // 
            // room_num
            // 
            this.room_num.DataPropertyName = "room_number";
            this.room_num.HeaderText = "房间号";
            this.room_num.Name = "room_num";
            this.room_num.ReadOnly = true;
            this.room_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_proportion
            // 
            this.col_proportion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_proportion.DataPropertyName = "proportion";
            this.col_proportion.HeaderText = "面积(m²)";
            this.col_proportion.Name = "col_proportion";
            this.col_proportion.ReadOnly = true;
            this.col_proportion.Width = 72;
            // 
            // owner_tel
            // 
            this.owner_tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.owner_tel.DataPropertyName = "owner_tel";
            this.owner_tel.HeaderText = "联系方式";
            this.owner_tel.Name = "owner_tel";
            this.owner_tel.ReadOnly = true;
            this.owner_tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.owner_tel.Width = 42;
            // 
            // owner_card
            // 
            this.owner_card.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.owner_card.DataPropertyName = "owner_card";
            this.owner_card.HeaderText = "身份证";
            this.owner_card.Name = "owner_card";
            this.owner_card.ReadOnly = true;
            this.owner_card.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.owner_card.Width = 42;
            // 
            // col_stay_time
            // 
            this.col_stay_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_stay_time.DataPropertyName = "stay_time";
            this.col_stay_time.HeaderText = "入住时间";
            this.col_stay_time.Name = "col_stay_time";
            this.col_stay_time.ReadOnly = true;
            this.col_stay_time.Width = 61;
            // 
            // owner_number
            // 
            this.owner_number.DataPropertyName = "owner_number";
            this.owner_number.HeaderText = "业主编号";
            this.owner_number.Name = "owner_number";
            this.owner_number.ReadOnly = true;
            this.owner_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.owner_number.Visible = false;
            // 
            // CMS_delete
            // 
            this.CMS_delete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.CMS_delete.Name = "contextMenuStrip1";
            this.CMS_delete.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // phone_tb
            // 
            this.phone_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone_tb.Location = new System.Drawing.Point(86, 62);
            this.phone_tb.Margin = new System.Windows.Forms.Padding(1);
            this.phone_tb.MaxLength = 11;
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(86, 23);
            this.phone_tb.TabIndex = 6;
            // 
            // shenfen_tb
            // 
            this.shenfen_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shenfen_tb.Location = new System.Drawing.Point(270, 62);
            this.shenfen_tb.Margin = new System.Windows.Forms.Padding(1);
            this.shenfen_tb.MaxLength = 18;
            this.shenfen_tb.Name = "shenfen_tb";
            this.shenfen_tb.Size = new System.Drawing.Size(140, 23);
            this.shenfen_tb.TabIndex = 7;
            // 
            // yename_tb
            // 
            this.yename_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yename_tb.Location = new System.Drawing.Point(470, 34);
            this.yename_tb.Margin = new System.Windows.Forms.Padding(1);
            this.yename_tb.Name = "yename_tb";
            this.yename_tb.Size = new System.Drawing.Size(70, 23);
            this.yename_tb.TabIndex = 4;
            // 
            // room_tb
            // 
            this.room_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.room_tb.Location = new System.Drawing.Point(322, 35);
            this.room_tb.Margin = new System.Windows.Forms.Padding(1);
            this.room_tb.Name = "room_tb";
            this.room_tb.Size = new System.Drawing.Size(71, 23);
            this.room_tb.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(26, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "联系方式：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.Location = new System.Drawing.Point(221, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "身份证：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(408, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "业主姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.Location = new System.Drawing.Point(272, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "房间号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(138, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "楼栋名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "小区名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F);
            this.label1.Location = new System.Drawing.Point(252, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "业主信息管理";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_sex);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.proportion_tb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ldname_cbb);
            this.panel1.Controls.Add(this.xqname_cbb);
            this.panel1.Controls.Add(this.phone_tb);
            this.panel1.Controls.Add(this.shenfen_tb);
            this.panel1.Controls.Add(this.yename_tb);
            this.panel1.Controls.Add(this.room_tb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 572);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbb_sex
            // 
            this.cbb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sex.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbb_sex.FormattingEnabled = true;
            this.cbb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbb_sex.Location = new System.Drawing.Point(593, 33);
            this.cbb_sex.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_sex.Name = "cbb_sex";
            this.cbb_sex.Size = new System.Drawing.Size(43, 25);
            this.cbb_sex.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label11.Location = new System.Drawing.Point(554, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "性别：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(590, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "(m²)";
            // 
            // proportion_tb
            // 
            this.proportion_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.proportion_tb.Location = new System.Drawing.Point(518, 62);
            this.proportion_tb.Margin = new System.Windows.Forms.Padding(1);
            this.proportion_tb.Name = "proportion_tb";
            this.proportion_tb.Size = new System.Drawing.Size(71, 23);
            this.proportion_tb.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label9.Location = new System.Drawing.Point(456, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "住房面积：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgv_Owner);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(-2, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(796, 358);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "业主信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_MX);
            this.groupBox3.Controls.Add(this.btn_xiu);
            this.groupBox3.Controls.Add(this.btn_Add);
            this.groupBox3.Location = new System.Drawing.Point(31, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(261, 51);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // btn_MX
            // 
            this.btn_MX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_MX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MX.ForeColor = System.Drawing.Color.White;
            this.btn_MX.Location = new System.Drawing.Point(163, 18);
            this.btn_MX.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MX.Name = "btn_MX";
            this.btn_MX.Size = new System.Drawing.Size(70, 25);
            this.btn_MX.TabIndex = 0;
            this.btn_MX.Text = "导出明细";
            this.btn_MX.UseVisualStyleBackColor = false;
            this.btn_MX.Click += new System.EventHandler(this.btn_MX_Click);
            // 
            // Owner_Management
            // 
            this.AcceptButton = this.btn_cha;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(912, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Owner_Management";
            this.Text = "Owner_Management";
            this.Load += new System.EventHandler(this.Owner_Management_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Owner)).EndInit();
            this.CMS_delete.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xiu;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_cha;
        private System.Windows.Forms.ComboBox ldname_cbb;
        private System.Windows.Forms.ComboBox xqname_cbb;
        private System.Windows.Forms.DataGridView dgv_Owner;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.TextBox shenfen_tb;
        private System.Windows.Forms.TextBox yename_tb;
        private System.Windows.Forms.TextBox room_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private 汤臣一品小区物业管理系统.WatermarkTextBox ownername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip CMS_delete;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button btn_MX;
        private System.Windows.Forms.TextBox proportion_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_sex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vlage_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn building_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_proportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_card;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stay_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_number;
    }
}