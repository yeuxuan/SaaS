using 汤臣一品小区物业管理系统;

namespace SaaS
{
    partial class Building_add
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Building_add));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hu_tb1 = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.CNum1 = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.DName1 = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.Q_Name1 = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.louPan = new System.Windows.Forms.DataGridView();
            this.QName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CengNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.Label();
            this.lb_litll = new System.Windows.Forms.Label();
            this.lb_Npame = new System.Windows.Forms.Label();
            this.lb_Dname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.louPan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hu_tb1);
            this.panel1.Controls.Add(this.CNum1);
            this.panel1.Controls.Add(this.DName1);
            this.panel1.Controls.Add(this.Q_Name1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.louPan);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.lb_litll);
            this.panel1.Controls.Add(this.lb_Npame);
            this.panel1.Controls.Add(this.lb_Dname);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 467);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hu_tb1
            // 
            this.hu_tb1.Location = new System.Drawing.Point(552, 30);
            this.hu_tb1.Name = "hu_tb1";
            this.hu_tb1.Size = new System.Drawing.Size(90, 21);
            this.hu_tb1.TabIndex = 12;
            this.hu_tb1.WatermarkText = "请输入总用户数";
            // 
            // CNum1
            // 
            this.CNum1.Location = new System.Drawing.Point(387, 30);
            this.CNum1.Name = "CNum1";
            this.CNum1.Size = new System.Drawing.Size(104, 21);
            this.CNum1.TabIndex = 11;
            this.CNum1.WatermarkText = "请输入楼层数";
            // 
            // DName1
            // 
            this.DName1.Location = new System.Drawing.Point(222, 31);
            this.DName1.Name = "DName1";
            this.DName1.Size = new System.Drawing.Size(104, 21);
            this.DName1.TabIndex = 10;
            this.DName1.WatermarkText = "请输入楼栋名";
            // 
            // Q_Name1
            // 
            this.Q_Name1.Location = new System.Drawing.Point(61, 30);
            this.Q_Name1.Name = "Q_Name1";
            this.Q_Name1.Size = new System.Drawing.Size(100, 21);
            this.Q_Name1.TabIndex = 9;
            this.Q_Name1.WatermarkText = "请输入小区名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(497, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "总户数：";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Silver;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(549, 64);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(61, 18);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(425, 64);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(61, 18);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // louPan
            // 
            this.louPan.AllowUserToAddRows = false;
            this.louPan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.louPan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.louPan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.louPan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QName,
            this.Doname,
            this.CengNum,
            this.col_sum1});
            this.louPan.Location = new System.Drawing.Point(4, 93);
            this.louPan.Margin = new System.Windows.Forms.Padding(2);
            this.louPan.Name = "louPan";
            this.louPan.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(238)))));
            this.louPan.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.louPan.RowTemplate.Height = 27;
            this.louPan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.louPan.Size = new System.Drawing.Size(640, 184);
            this.louPan.TabIndex = 7;
            // 
            // QName
            // 
            this.QName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QName.DataPropertyName = "village_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QName.DefaultCellStyle = dataGridViewCellStyle2;
            this.QName.HeaderText = "小区名";
            this.QName.Name = "QName";
            this.QName.ReadOnly = true;
            this.QName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Doname
            // 
            this.Doname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Doname.DataPropertyName = "building_number";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Doname.DefaultCellStyle = dataGridViewCellStyle3;
            this.Doname.HeaderText = "楼栋名";
            this.Doname.Name = "Doname";
            this.Doname.ReadOnly = true;
            this.Doname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CengNum
            // 
            this.CengNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CengNum.DataPropertyName = "tier_number";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CengNum.DefaultCellStyle = dataGridViewCellStyle4;
            this.CengNum.HeaderText = "楼层数";
            this.CengNum.Name = "CengNum";
            this.CengNum.ReadOnly = true;
            this.CengNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_sum1
            // 
            this.col_sum1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_sum1.DataPropertyName = "totality";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_sum1.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_sum1.HeaderText = "总户数";
            this.col_sum1.Name = "col_sum1";
            this.col_sum1.ReadOnly = true;
            this.col_sum1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.BackColor = System.Drawing.Color.Transparent;
            this.Type.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Type.Location = new System.Drawing.Point(270, 2);
            this.Type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(101, 30);
            this.Type.TabIndex = 0;
            this.Type.Text = "楼盘添加";
            // 
            // lb_litll
            // 
            this.lb_litll.AutoSize = true;
            this.lb_litll.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_litll.Location = new System.Drawing.Point(332, 33);
            this.lb_litll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_litll.Name = "lb_litll";
            this.lb_litll.Size = new System.Drawing.Size(65, 20);
            this.lb_litll.TabIndex = 0;
            this.lb_litll.Text = "楼层数：";
            // 
            // lb_Npame
            // 
            this.lb_Npame.AutoSize = true;
            this.lb_Npame.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Npame.Location = new System.Drawing.Point(4, 32);
            this.lb_Npame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Npame.Name = "lb_Npame";
            this.lb_Npame.Size = new System.Drawing.Size(65, 20);
            this.lb_Npame.TabIndex = 0;
            this.lb_Npame.Text = "小区名：";
            // 
            // lb_Dname
            // 
            this.lb_Dname.AutoSize = true;
            this.lb_Dname.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Dname.Location = new System.Drawing.Point(166, 33);
            this.lb_Dname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Dname.Name = "lb_Dname";
            this.lb_Dname.Size = new System.Drawing.Size(65, 20);
            this.lb_Dname.TabIndex = 0;
            this.lb_Dname.Text = "楼栋名：";
            // 
            // Building_add
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Building_add";
            this.Text = "楼盘添加";
            this.Load += new System.EventHandler(this.Building_add_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.louPan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView louPan;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label lb_litll;
        private System.Windows.Forms.Label lb_Npame;
        private System.Windows.Forms.Label lb_Dname;
        private 汤臣一品小区物业管理系统.WatermarkTextBox CNum;
        private 汤臣一品小区物业管理系统.WatermarkTextBox DName;
        private 汤臣一品小区物业管理系统.WatermarkTextBox Q_Name;
        private 汤臣一品小区物业管理系统.WatermarkTextBox hu_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CengNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sum1;
        private WatermarkTextBox Q_Name1;
        private WatermarkTextBox hu_tb1;
        private WatermarkTextBox CNum1;
        private WatermarkTextBox DName1;
    }
}