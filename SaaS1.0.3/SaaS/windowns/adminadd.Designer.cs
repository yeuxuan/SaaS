
namespace SaaS.windowns
{
    partial class adminadd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pwd_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tell_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xaio = new System.Windows.Forms.Button();
            this.btn_infoadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pwd_text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tell_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_num);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(27, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(301, 241);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加信息";
            // 
            // Pwd_text
            // 
            this.Pwd_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pwd_text.Location = new System.Drawing.Point(125, 107);
            this.Pwd_text.Name = "Pwd_text";
            this.Pwd_text.Size = new System.Drawing.Size(139, 23);
            this.Pwd_text.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(66, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "密码：";
            // 
            // tell_text
            // 
            this.tell_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tell_text.Location = new System.Drawing.Point(125, 172);
            this.tell_text.MaxLength = 11;
            this.tell_text.Name = "tell_text";
            this.tell_text.Size = new System.Drawing.Size(137, 23);
            this.tell_text.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(42, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "联系电话：";
            // 
            // text_num
            // 
            this.text_num.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_num.Location = new System.Drawing.Point(125, 38);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(139, 23);
            this.text_num.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "账号：";
            // 
            // btn_xaio
            // 
            this.btn_xaio.BackColor = System.Drawing.Color.Transparent;
            this.btn_xaio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xaio.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_xaio.ForeColor = System.Drawing.Color.Black;
            this.btn_xaio.Location = new System.Drawing.Point(212, 328);
            this.btn_xaio.Name = "btn_xaio";
            this.btn_xaio.Size = new System.Drawing.Size(87, 31);
            this.btn_xaio.TabIndex = 41;
            this.btn_xaio.Text = "取消";
            this.btn_xaio.UseVisualStyleBackColor = false;
            this.btn_xaio.Click += new System.EventHandler(this.btn_xaio_Click);
            // 
            // btn_infoadd
            // 
            this.btn_infoadd.BackColor = System.Drawing.Color.Red;
            this.btn_infoadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_infoadd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_infoadd.ForeColor = System.Drawing.Color.White;
            this.btn_infoadd.Location = new System.Drawing.Point(52, 328);
            this.btn_infoadd.Name = "btn_infoadd";
            this.btn_infoadd.Size = new System.Drawing.Size(87, 31);
            this.btn_infoadd.TabIndex = 40;
            this.btn_infoadd.Text = "添加";
            this.btn_infoadd.UseVisualStyleBackColor = false;
            this.btn_infoadd.Click += new System.EventHandler(this.btn_infoadd_Click);
            // 
            // adminadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 386);
            this.Controls.Add(this.btn_xaio);
            this.Controls.Add(this.btn_infoadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminadd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "adminadd";
            this.Load += new System.EventHandler(this.adminadd_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pwd_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tell_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xaio;
        private System.Windows.Forms.Button btn_infoadd;
    }
}