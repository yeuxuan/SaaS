namespace SaaS
{
    partial class StopCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopCar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_jz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_shishou = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_refer = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_stopcar = new System.Windows.Forms.DataGridView();
            this.Colvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colcarnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_arrivetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_leavetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.离开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_carnum = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_vageName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_money = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stopcar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_money);
            this.panel1.Controls.Add(this.btn_jz);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_shishou);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgv_stopcar);
            this.panel1.Controls.Add(this.tb_carnum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbb_vageName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 502);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_jz
            // 
            this.btn_jz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_jz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jz.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_jz.ForeColor = System.Drawing.Color.White;
            this.btn_jz.Location = new System.Drawing.Point(370, 73);
            this.btn_jz.Margin = new System.Windows.Forms.Padding(2);
            this.btn_jz.Name = "btn_jz";
            this.btn_jz.Size = new System.Drawing.Size(55, 15);
            this.btn_jz.TabIndex = 22;
            this.btn_jz.Text = "结账";
            this.btn_jz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_jz.UseVisualStyleBackColor = false;
            this.btn_jz.Click += new System.EventHandler(this.btn_jz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(191, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "实收金额：";
            // 
            // tb_shishou
            // 
            this.tb_shishou.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_shishou.Location = new System.Drawing.Point(258, 75);
            this.tb_shishou.Margin = new System.Windows.Forms.Padding(2);
            this.tb_shishou.Name = "tb_shishou";
            this.tb_shishou.Size = new System.Drawing.Size(88, 23);
            this.tb_shishou.TabIndex = 20;
            this.tb_shishou.WatermarkText = "输入金额";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_refer);
            this.groupBox1.Controls.Add(this.btn_select);
            this.groupBox1.Location = new System.Drawing.Point(438, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(195, 41);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // tb_refer
            // 
            this.tb_refer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_refer.Location = new System.Drawing.Point(16, 18);
            this.tb_refer.Margin = new System.Windows.Forms.Padding(2);
            this.tb_refer.Name = "tb_refer";
            this.tb_refer.Size = new System.Drawing.Size(108, 23);
            this.tb_refer.TabIndex = 17;
            this.tb_refer.WatermarkText = "请输入车牌号";
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.Location = new System.Drawing.Point(137, 18);
            this.btn_select.Margin = new System.Windows.Forms.Padding(2);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(46, 15);
            this.btn_select.TabIndex = 16;
            this.btn_select.Text = "查询";
            this.btn_select.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(370, 38);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 15);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "进入";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(20, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "应收金额：";
            // 
            // dgv_stopcar
            // 
            this.dgv_stopcar.AllowUserToAddRows = false;
            this.dgv_stopcar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stopcar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stopcar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stopcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stopcar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colvname,
            this.Colcarnum,
            this.Col_arrivetime,
            this.Col_leavetime,
            this.Col_money,
            this.col_state});
            this.dgv_stopcar.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stopcar.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_stopcar.Location = new System.Drawing.Point(4, 100);
            this.dgv_stopcar.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_stopcar.Name = "dgv_stopcar";
            this.dgv_stopcar.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stopcar.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_stopcar.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 11F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(238)))));
            this.dgv_stopcar.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_stopcar.RowTemplate.Height = 27;
            this.dgv_stopcar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stopcar.Size = new System.Drawing.Size(638, 177);
            this.dgv_stopcar.TabIndex = 10;
            this.dgv_stopcar.TabStop = false;
            this.dgv_stopcar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_stopcar_CellMouseClick);
            // 
            // Colvname
            // 
            this.Colvname.DataPropertyName = "village_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Colvname.DefaultCellStyle = dataGridViewCellStyle2;
            this.Colvname.HeaderText = "小区名";
            this.Colvname.MinimumWidth = 6;
            this.Colvname.Name = "Colvname";
            this.Colvname.ReadOnly = true;
            this.Colvname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Colcarnum
            // 
            this.Colcarnum.DataPropertyName = "car_number";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Colcarnum.DefaultCellStyle = dataGridViewCellStyle3;
            this.Colcarnum.HeaderText = "车牌号";
            this.Colcarnum.MinimumWidth = 6;
            this.Colcarnum.Name = "Colcarnum";
            this.Colcarnum.ReadOnly = true;
            this.Colcarnum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_arrivetime
            // 
            this.Col_arrivetime.DataPropertyName = "arrive_time";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_arrivetime.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col_arrivetime.HeaderText = "进入时间";
            this.Col_arrivetime.MinimumWidth = 6;
            this.Col_arrivetime.Name = "Col_arrivetime";
            this.Col_arrivetime.ReadOnly = true;
            this.Col_arrivetime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_leavetime
            // 
            this.Col_leavetime.DataPropertyName = "leave_time";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_leavetime.DefaultCellStyle = dataGridViewCellStyle5;
            this.Col_leavetime.HeaderText = "离开时间";
            this.Col_leavetime.MinimumWidth = 6;
            this.Col_leavetime.Name = "Col_leavetime";
            this.Col_leavetime.ReadOnly = true;
            this.Col_leavetime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_money
            // 
            this.Col_money.DataPropertyName = "charge_amont";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_money.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col_money.HeaderText = "金额(元)";
            this.Col_money.MinimumWidth = 6;
            this.Col_money.Name = "Col_money";
            this.Col_money.ReadOnly = true;
            this.Col_money.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_state
            // 
            this.col_state.DataPropertyName = "state";
            this.col_state.HeaderText = "缴费状态";
            this.col_state.MinimumWidth = 6;
            this.col_state.Name = "col_state";
            this.col_state.ReadOnly = true;
            this.col_state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.离开ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 离开ToolStripMenuItem
            // 
            this.离开ToolStripMenuItem.Name = "离开ToolStripMenuItem";
            this.离开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.离开ToolStripMenuItem.Text = "离开";
            this.离开ToolStripMenuItem.Click += new System.EventHandler(this.离开ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // tb_carnum
            // 
            this.tb_carnum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_carnum.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_carnum.Location = new System.Drawing.Point(256, 39);
            this.tb_carnum.Margin = new System.Windows.Forms.Padding(2);
            this.tb_carnum.Name = "tb_carnum";
            this.tb_carnum.Size = new System.Drawing.Size(90, 23);
            this.tb_carnum.TabIndex = 9;
            this.tb_carnum.WatermarkText = "请输入车牌号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(202, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "车牌号：";
            // 
            // cbb_vageName
            // 
            this.cbb_vageName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_vageName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbb_vageName.FormattingEnabled = true;
            this.cbb_vageName.Location = new System.Drawing.Point(85, 39);
            this.cbb_vageName.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_vageName.Name = "cbb_vageName";
            this.cbb_vageName.Size = new System.Drawing.Size(90, 25);
            this.cbb_vageName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 16.2F);
            this.label2.Location = new System.Drawing.Point(259, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "来访车辆管理";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "小区名：";
            // 
            // tb_money
            // 
            this.tb_money.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_money.Location = new System.Drawing.Point(86, 75);
            this.tb_money.Margin = new System.Windows.Forms.Padding(2);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(89, 23);
            this.tb_money.TabIndex = 23;
            this.tb_money.WatermarkText = "输入金额";
            // 
            // StopCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StopCar";
            this.Text = "StopCar";
            this.Load += new System.EventHandler(this.StopCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stopcar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_jz;
        private System.Windows.Forms.Label label5;
        private 汤臣一品小区物业管理系统.WatermarkTextBox tb_shishou;
        private System.Windows.Forms.GroupBox groupBox1;
        private 汤臣一品小区物业管理系统.WatermarkTextBox tb_refer;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_stopcar;
        private 汤臣一品小区物业管理系统.WatermarkTextBox tb_carnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_vageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 离开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colcarnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_arrivetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_leavetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_money;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_state;
        private 汤臣一品小区物业管理系统.WatermarkTextBox tb_money;
    }
}