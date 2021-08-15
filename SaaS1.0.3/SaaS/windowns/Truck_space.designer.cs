namespace SaaS
{
    partial class Truck_space
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Truck_space));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.num_tb = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_car = new System.Windows.Forms.DataGridView();
            this.col_attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_carnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_shu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_type1 = new System.Windows.Forms.ComboBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.cun = new System.Windows.Forms.Label();
            this.cun2 = new System.Windows.Forms.Label();
            this.cun1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_car)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(264, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "私有车位总数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(491, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "租用车位总数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(35, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "公共车位总数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(273, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "车位数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(96, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "车位类型：";
            // 
            // cbb_type
            // 
            this.cbb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Items.AddRange(new object[] {
            "公共车位",
            "私有车位",
            "租用车位"});
            this.cbb_type.Location = new System.Drawing.Point(166, 31);
            this.cbb_type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(92, 28);
            this.cbb_type.TabIndex = 14;
            // 
            // num_tb
            // 
            this.num_tb.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_tb.Location = new System.Drawing.Point(341, 32);
            this.num_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(76, 25);
            this.num_tb.TabIndex = 13;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(462, 30);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 17);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "添加车位";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F);
            this.label1.Location = new System.Drawing.Point(272, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "车位管理";
            // 
            // dgv_car
            // 
            this.dgv_car.AllowUserToAddRows = false;
            this.dgv_car.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_car.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_car.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_car.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_car.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_attribute,
            this.col_owner,
            this.col_address,
            this.col_tell,
            this.col_carnum,
            this.col_type,
            this.col_tenancy,
            this.col_shu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_car.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_car.Location = new System.Drawing.Point(2, 42);
            this.dgv_car.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_car.Name = "dgv_car";
            this.dgv_car.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_car.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(238)))));
            this.dgv_car.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_car.RowTemplate.Height = 27;
            this.dgv_car.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_car.Size = new System.Drawing.Size(644, 159);
            this.dgv_car.TabIndex = 10;
            this.dgv_car.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_car_CellContentClick);
            this.dgv_car.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_car_CellMouseDoubleClick);
            // 
            // col_attribute
            // 
            this.col_attribute.DataPropertyName = "Type";
            this.col_attribute.HeaderText = "车位属性";
            this.col_attribute.Name = "col_attribute";
            this.col_attribute.ReadOnly = true;
            // 
            // col_owner
            // 
            this.col_owner.DataPropertyName = "Car_name";
            this.col_owner.HeaderText = "车主姓名";
            this.col_owner.Name = "col_owner";
            this.col_owner.ReadOnly = true;
            // 
            // col_address
            // 
            this.col_address.DataPropertyName = "Address";
            this.col_address.HeaderText = "住址";
            this.col_address.Name = "col_address";
            this.col_address.ReadOnly = true;
            // 
            // col_tell
            // 
            this.col_tell.DataPropertyName = "Tell";
            this.col_tell.HeaderText = "联系电话";
            this.col_tell.Name = "col_tell";
            this.col_tell.ReadOnly = true;
            // 
            // col_carnum
            // 
            this.col_carnum.DataPropertyName = "Car_num";
            this.col_carnum.HeaderText = "车牌号";
            this.col_carnum.Name = "col_carnum";
            this.col_carnum.ReadOnly = true;
            // 
            // col_type
            // 
            this.col_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_type.DataPropertyName = "Car_type";
            this.col_type.HeaderText = "车辆类型";
            this.col_type.Name = "col_type";
            this.col_type.ReadOnly = true;
            this.col_type.Width = 81;
            // 
            // col_tenancy
            // 
            this.col_tenancy.DataPropertyName = "tenancy_term";
            this.col_tenancy.HeaderText = "租期(年)";
            this.col_tenancy.Name = "col_tenancy";
            this.col_tenancy.ReadOnly = true;
            // 
            // col_shu
            // 
            this.col_shu.DataPropertyName = "ID";
            this.col_shu.HeaderText = "序号";
            this.col_shu.Name = "col_shu";
            this.col_shu.ReadOnly = true;
            this.col_shu.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(290, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "请选择车位类型：";
            // 
            // cbb_type1
            // 
            this.cbb_type1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type1.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbb_type1.FormattingEnabled = true;
            this.cbb_type1.Items.AddRange(new object[] {
            "公共车位",
            "私有车位",
            "租用车位",
            "全部"});
            this.cbb_type1.Location = new System.Drawing.Point(404, 14);
            this.cbb_type1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_type1.Name = "cbb_type1";
            this.cbb_type1.Size = new System.Drawing.Size(92, 28);
            this.cbb_type1.TabIndex = 21;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.Location = new System.Drawing.Point(519, 14);
            this.btn_select.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(64, 17);
            this.btn_select.TabIndex = 22;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // cun
            // 
            this.cun.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cun.Location = new System.Drawing.Point(117, 204);
            this.cun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cun.Name = "cun";
            this.cun.Size = new System.Drawing.Size(20, 12);
            this.cun.TabIndex = 23;
            // 
            // cun2
            // 
            this.cun2.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cun2.Location = new System.Drawing.Point(572, 204);
            this.cun2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cun2.Name = "cun2";
            this.cun2.Size = new System.Drawing.Size(20, 12);
            this.cun2.TabIndex = 24;
            // 
            // cun1
            // 
            this.cun1.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cun1.Location = new System.Drawing.Point(345, 204);
            this.cun1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cun1.Name = "cun1";
            this.cun1.Size = new System.Drawing.Size(20, 12);
            this.cun1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cun1);
            this.groupBox1.Controls.Add(this.cun2);
            this.groupBox1.Controls.Add(this.cun);
            this.groupBox1.Controls.Add(this.btn_select);
            this.groupBox1.Controls.Add(this.cbb_type1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgv_car);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(-1, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(679, 246);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "车位信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(78, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 17);
            this.button1.TabIndex = 26;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Truck_space
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Truck_space";
            this.Text = "车位管理";
            this.Load += new System.EventHandler(this.Truck_space_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_car)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_type;
        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_car;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_type1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label cun;
        private System.Windows.Forms.Label cun2;
        private System.Windows.Forms.Label cun1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tell;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_carnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenancy;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_shu;
    }
}