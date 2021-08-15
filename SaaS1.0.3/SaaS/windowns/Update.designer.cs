namespace SaaS
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.bt_esc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_wuyei = new System.Windows.Forms.ComboBox();
            this.tb_wuyei = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_electric = new System.Windows.Forms.TextBox();
            this.roomnum_cb = new System.Windows.Forms.ComboBox();
            this.tb_water = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_water = new System.Windows.Forms.ComboBox();
            this.cb_electric = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_esc
            // 
            this.bt_esc.BackColor = System.Drawing.Color.White;
            this.bt_esc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_esc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_esc.ForeColor = System.Drawing.Color.Black;
            this.bt_esc.Location = new System.Drawing.Point(224, 315);
            this.bt_esc.Margin = new System.Windows.Forms.Padding(2);
            this.bt_esc.Name = "bt_esc";
            this.bt_esc.Size = new System.Drawing.Size(73, 26);
            this.bt_esc.TabIndex = 52;
            this.bt_esc.Text = "取消";
            this.bt_esc.UseVisualStyleBackColor = false;
            this.bt_esc.Click += new System.EventHandler(this.bt_esc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_wuyei);
            this.groupBox1.Controls.Add(this.tb_wuyei);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_electric);
            this.groupBox1.Controls.Add(this.roomnum_cb);
            this.groupBox1.Controls.Add(this.tb_water);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_water);
            this.groupBox1.Controls.Add(this.cb_electric);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(38, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 258);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "缴费";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_wuyei
            // 
            this.cb_wuyei.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_wuyei.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_wuyei.FormattingEnabled = true;
            this.cb_wuyei.Items.AddRange(new object[] {
            "已缴费",
            "未缴费"});
            this.cb_wuyei.Location = new System.Drawing.Point(217, 203);
            this.cb_wuyei.Margin = new System.Windows.Forms.Padding(2);
            this.cb_wuyei.Name = "cb_wuyei";
            this.cb_wuyei.Size = new System.Drawing.Size(64, 25);
            this.cb_wuyei.TabIndex = 40;
            // 
            // tb_wuyei
            // 
            this.tb_wuyei.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_wuyei.Location = new System.Drawing.Point(76, 203);
            this.tb_wuyei.Margin = new System.Windows.Forms.Padding(2);
            this.tb_wuyei.Name = "tb_wuyei";
            this.tb_wuyei.Size = new System.Drawing.Size(77, 23);
            this.tb_wuyei.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "房间号:";
            // 
            // tb_electric
            // 
            this.tb_electric.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_electric.Location = new System.Drawing.Point(76, 150);
            this.tb_electric.Margin = new System.Windows.Forms.Padding(2);
            this.tb_electric.Name = "tb_electric";
            this.tb_electric.Size = new System.Drawing.Size(77, 23);
            this.tb_electric.TabIndex = 46;
            // 
            // roomnum_cb
            // 
            this.roomnum_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomnum_cb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roomnum_cb.FormattingEnabled = true;
            this.roomnum_cb.Location = new System.Drawing.Point(76, 46);
            this.roomnum_cb.Margin = new System.Windows.Forms.Padding(2);
            this.roomnum_cb.MaxDropDownItems = 20;
            this.roomnum_cb.Name = "roomnum_cb";
            this.roomnum_cb.Size = new System.Drawing.Size(70, 25);
            this.roomnum_cb.TabIndex = 34;
            // 
            // tb_water
            // 
            this.tb_water.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_water.Location = new System.Drawing.Point(76, 99);
            this.tb_water.Margin = new System.Windows.Forms.Padding(2);
            this.tb_water.Name = "tb_water";
            this.tb_water.Size = new System.Drawing.Size(77, 23);
            this.tb_water.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(158, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "是否缴费:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(4, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "物业管理费:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(158, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "是否缴费:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(38, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "电费:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(158, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "是否缴费:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(38, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "水费:";
            // 
            // cb_water
            // 
            this.cb_water.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_water.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_water.FormattingEnabled = true;
            this.cb_water.Items.AddRange(new object[] {
            "已缴费",
            "未缴费"});
            this.cb_water.Location = new System.Drawing.Point(217, 97);
            this.cb_water.Margin = new System.Windows.Forms.Padding(2);
            this.cb_water.Name = "cb_water";
            this.cb_water.Size = new System.Drawing.Size(64, 25);
            this.cb_water.TabIndex = 38;
            // 
            // cb_electric
            // 
            this.cb_electric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_electric.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_electric.FormattingEnabled = true;
            this.cb_electric.Items.AddRange(new object[] {
            "已缴费",
            "未缴费"});
            this.cb_electric.Location = new System.Drawing.Point(217, 150);
            this.cb_electric.Margin = new System.Windows.Forms.Padding(2);
            this.cb_electric.Name = "cb_electric";
            this.cb_electric.Size = new System.Drawing.Size(64, 25);
            this.cb_electric.TabIndex = 39;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(72, 315);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(73, 26);
            this.btn_update.TabIndex = 50;
            this.btn_update.Text = "缴费";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(368, 374);
            this.Controls.Add(this.bt_esc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Update_FormClosed);
            this.Load += new System.EventHandler(this.Update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_esc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_wuyei;
        private System.Windows.Forms.TextBox tb_wuyei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_electric;
        private System.Windows.Forms.ComboBox roomnum_cb;
        private System.Windows.Forms.TextBox tb_water;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_water;
        private System.Windows.Forms.ComboBox cb_electric;
        private System.Windows.Forms.Button btn_update;
    }
}