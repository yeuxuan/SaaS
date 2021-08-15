
namespace SaaS.windowns
{
    partial class pfsz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_infoadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Location = new System.Drawing.Point(-34, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 40);
            this.panel1.TabIndex = 1;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minimize.Image = global::SaaS.Properties.Resources.关闭___副本;
            this.minimize.Location = new System.Drawing.Point(323, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(53, 40);
            this.minimize.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Image = global::SaaS.Properties.Resources.关闭___副本;
            this.label1.Location = new System.Drawing.Point(294, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 40);
            this.label1.TabIndex = 32;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_infoadd);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(272, 191);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "皮肤设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "皮肤选择：";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "红色",
            "蓝色",
            "黑色",
            "橙色",
            "青色",
            "紫色"});
            this.comboBox1.Location = new System.Drawing.Point(111, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_infoadd
            // 
            this.btn_infoadd.BackColor = System.Drawing.Color.Red;
            this.btn_infoadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_infoadd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_infoadd.ForeColor = System.Drawing.Color.White;
            this.btn_infoadd.Location = new System.Drawing.Point(89, 121);
            this.btn_infoadd.Name = "btn_infoadd";
            this.btn_infoadd.Size = new System.Drawing.Size(87, 31);
            this.btn_infoadd.TabIndex = 42;
            this.btn_infoadd.Text = "设置";
            this.btn_infoadd.UseVisualStyleBackColor = false;
            this.btn_infoadd.Click += new System.EventHandler(this.btn_infoadd_Click);
            // 
            // pfsz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 246);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pfsz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pfsz";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_infoadd;
    }
}