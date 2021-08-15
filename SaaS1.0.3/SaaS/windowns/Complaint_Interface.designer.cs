namespace SaaS
{
    partial class Complaint_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complaint_Interface));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.evaluate_cbb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jieg_tb = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hao_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.neirong_tb = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.cpname_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.complain_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_abolish = new System.Windows.Forms.Button();
            this.btn_evaluate = new System.Windows.Forms.Button();
            this.coping = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.coping.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.evaluate_cbb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.jieg_tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hao_tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.neirong_tb);
            this.groupBox1.Controls.Add(this.cpname_tb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.complain_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(22, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(464, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "受理信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // evaluate_cbb
            // 
            this.evaluate_cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.evaluate_cbb.FormattingEnabled = true;
            this.evaluate_cbb.Items.AddRange(new object[] {
            "非常满意",
            "较满意",
            "满意",
            "一般",
            "不满意",
            "非常不满意"});
            this.evaluate_cbb.Location = new System.Drawing.Point(340, 34);
            this.evaluate_cbb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evaluate_cbb.Name = "evaluate_cbb";
            this.evaluate_cbb.Size = new System.Drawing.Size(92, 25);
            this.evaluate_cbb.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(283, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "满意度：";
            // 
            // jieg_tb
            // 
            this.jieg_tb.ImeMode = System.Windows.Forms.ImeMode.On;
            this.jieg_tb.Location = new System.Drawing.Point(96, 240);
            this.jieg_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jieg_tb.Multiline = true;
            this.jieg_tb.Name = "jieg_tb";
            this.jieg_tb.ReadOnly = true;
            this.jieg_tb.Size = new System.Drawing.Size(341, 65);
            this.jieg_tb.TabIndex = 17;
            this.jieg_tb.WatermarkText = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "处理结果：";
            // 
            // hao_tb
            // 
            this.hao_tb.ImeMode = System.Windows.Forms.ImeMode.On;
            this.hao_tb.Location = new System.Drawing.Point(96, 34);
            this.hao_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hao_tb.MaxLength = 11;
            this.hao_tb.Name = "hao_tb";
            this.hao_tb.ReadOnly = true;
            this.hao_tb.Size = new System.Drawing.Size(169, 23);
            this.hao_tb.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "受理编号：";
            // 
            // neirong_tb
            // 
            this.neirong_tb.ImeMode = System.Windows.Forms.ImeMode.On;
            this.neirong_tb.Location = new System.Drawing.Point(96, 147);
            this.neirong_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.neirong_tb.Multiline = true;
            this.neirong_tb.Name = "neirong_tb";
            this.neirong_tb.ReadOnly = true;
            this.neirong_tb.Size = new System.Drawing.Size(337, 60);
            this.neirong_tb.TabIndex = 13;
            this.neirong_tb.WatermarkText = null;
            // 
            // cpname_tb
            // 
            this.cpname_tb.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cpname_tb.Location = new System.Drawing.Point(340, 98);
            this.cpname_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpname_tb.Name = "cpname_tb";
            this.cpname_tb.ReadOnly = true;
            this.cpname_tb.Size = new System.Drawing.Size(92, 23);
            this.cpname_tb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(283, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "来访人：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "内容：";
            // 
            // complain_date
            // 
            this.complain_date.Location = new System.Drawing.Point(96, 98);
            this.complain_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.complain_date.Name = "complain_date";
            this.complain_date.Size = new System.Drawing.Size(127, 23);
            this.complain_date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期：";
            // 
            // btn_abolish
            // 
            this.btn_abolish.BackColor = System.Drawing.Color.Silver;
            this.btn_abolish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_abolish.FlatAppearance.BorderSize = 0;
            this.btn_abolish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abolish.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_abolish.ForeColor = System.Drawing.Color.White;
            this.btn_abolish.Location = new System.Drawing.Point(316, 400);
            this.btn_abolish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_abolish.Name = "btn_abolish";
            this.btn_abolish.Size = new System.Drawing.Size(75, 28);
            this.btn_abolish.TabIndex = 2;
            this.btn_abolish.Text = "返回";
            this.btn_abolish.UseVisualStyleBackColor = false;
            this.btn_abolish.Click += new System.EventHandler(this.btn_abolish_Click);
            // 
            // btn_evaluate
            // 
            this.btn_evaluate.BackColor = System.Drawing.Color.Red;
            this.btn_evaluate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_evaluate.FlatAppearance.BorderSize = 0;
            this.btn_evaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_evaluate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_evaluate.ForeColor = System.Drawing.Color.White;
            this.btn_evaluate.Location = new System.Drawing.Point(116, 400);
            this.btn_evaluate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_evaluate.Name = "btn_evaluate";
            this.btn_evaluate.Size = new System.Drawing.Size(75, 28);
            this.btn_evaluate.TabIndex = 3;
            this.btn_evaluate.Text = "评价";
            this.btn_evaluate.UseVisualStyleBackColor = false;
            this.btn_evaluate.Click += new System.EventHandler(this.btn_evaluate_Click);
            // 
            // coping
            // 
            this.coping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coping.BackColor = System.Drawing.Color.OrangeRed;
            this.coping.Controls.Add(this.label8);
            this.coping.Location = new System.Drawing.Point(-2, -1);
            this.coping.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coping.Name = "coping";
            this.coping.Size = new System.Drawing.Size(510, 27);
            this.coping.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "受理详情与评价";
            // 
            // Complaint_Interface
            // 
            this.AcceptButton = this.btn_abolish;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(507, 445);
            this.Controls.Add(this.coping);
            this.Controls.Add(this.btn_evaluate);
            this.Controls.Add(this.btn_abolish);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Complaint_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complaint_Interface";
            this.Load += new System.EventHandler(this.Complaint_Interface_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.coping.ResumeLayout(false);
            this.coping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_abolish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker complain_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cpname_tb;
        private 汤臣一品小区物业管理系统.WatermarkTextBox neirong_tb;
        private System.Windows.Forms.TextBox hao_tb;
        private System.Windows.Forms.Label label3;
        private 汤臣一品小区物业管理系统.WatermarkTextBox jieg_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox evaluate_cbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_evaluate;
        private System.Windows.Forms.Panel coping;
        private System.Windows.Forms.Label label8;
    }
}