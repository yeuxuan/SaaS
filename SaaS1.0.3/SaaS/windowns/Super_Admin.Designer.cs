
namespace SaaS.windowns
{
    partial class Super_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Super_Admin));
            this.coping = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.super_lb = new System.Windows.Forms.Label();
            this.shut = new System.Windows.Forms.Label();
            this.btn_seclt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_amend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_jin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.account_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.coping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coping
            // 
            this.coping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coping.BackColor = System.Drawing.Color.DodgerBlue;
            this.coping.Controls.Add(this.label3);
            this.coping.Controls.Add(this.pictureBox1);
            this.coping.Controls.Add(this.label1);
            this.coping.Controls.Add(this.minimize);
            this.coping.Controls.Add(this.super_lb);
            this.coping.Controls.Add(this.shut);
            this.coping.Location = new System.Drawing.Point(-21, 0);
            this.coping.Name = "coping";
            this.coping.Size = new System.Drawing.Size(828, 40);
            this.coping.TabIndex = 28;
            this.coping.Paint += new System.Windows.Forms.PaintEventHandler(this.coping_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "超级管理员";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SaaS.Properties.Resources.icon_用户11___副本;
            this.pictureBox1.Location = new System.Drawing.Point(33, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Image = global::SaaS.Properties.Resources._123456___副本;
            this.label1.Location = new System.Drawing.Point(731, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 40);
            this.label1.TabIndex = 31;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minimize.Image = global::SaaS.Properties.Resources.关闭___副本;
            this.minimize.Location = new System.Drawing.Point(774, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(53, 40);
            this.minimize.TabIndex = 30;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // super_lb
            // 
            this.super_lb.AutoSize = true;
            this.super_lb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.super_lb.ForeColor = System.Drawing.Color.White;
            this.super_lb.Location = new System.Drawing.Point(56, 12);
            this.super_lb.Name = "super_lb";
            this.super_lb.Size = new System.Drawing.Size(0, 17);
            this.super_lb.TabIndex = 29;
            // 
            // shut
            // 
            this.shut.BackColor = System.Drawing.Color.Transparent;
            this.shut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.shut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shut.Location = new System.Drawing.Point(790, 0);
            this.shut.Name = "shut";
            this.shut.Size = new System.Drawing.Size(48, 40);
            this.shut.TabIndex = 5;
            // 
            // btn_seclt
            // 
            this.btn_seclt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btn_seclt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seclt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_seclt.ForeColor = System.Drawing.Color.White;
            this.btn_seclt.Location = new System.Drawing.Point(257, 80);
            this.btn_seclt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_seclt.Name = "btn_seclt";
            this.btn_seclt.Size = new System.Drawing.Size(67, 26);
            this.btn_seclt.TabIndex = 45;
            this.btn_seclt.Text = "查询";
            this.btn_seclt.UseVisualStyleBackColor = false;
            this.btn_seclt.Click += new System.EventHandler(this.btn_seclt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(82, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "查询：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_amend
            // 
            this.btn_amend.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_amend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_amend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_amend.ForeColor = System.Drawing.Color.White;
            this.btn_amend.Location = new System.Drawing.Point(347, 78);
            this.btn_amend.Margin = new System.Windows.Forms.Padding(2);
            this.btn_amend.Name = "btn_amend";
            this.btn_amend.Size = new System.Drawing.Size(106, 30);
            this.btn_amend.TabIndex = 43;
            this.btn_amend.Text = "添加管理员";
            this.btn_amend.UseVisualStyleBackColor = false;
            this.btn_amend.Click += new System.EventHandler(this.btn_amend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 21);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btn_jin
            // 
            this.btn_jin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_jin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_jin.ForeColor = System.Drawing.Color.White;
            this.btn_jin.Location = new System.Drawing.Point(573, 80);
            this.btn_jin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_jin.Name = "btn_jin";
            this.btn_jin.Size = new System.Drawing.Size(106, 30);
            this.btn_jin.TabIndex = 47;
            this.btn_jin.Text = "进入管理界面";
            this.btn_jin.UseVisualStyleBackColor = false;
            this.btn_jin.Click += new System.EventHandler(this.btn_jin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.account_number,
            this.user_id,
            this.password,
            this.user_tel,
            this.User_Type});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(0, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 274);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // account_number
            // 
            this.account_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.account_number.DataPropertyName = "account_number";
            this.account_number.HeaderText = "账号";
            this.account_number.MinimumWidth = 6;
            this.account_number.Name = "account_number";
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "编号";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.Visible = false;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "密码";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            // 
            // user_tel
            // 
            this.user_tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_tel.DataPropertyName = "user_tel";
            this.user_tel.HeaderText = "联系方式";
            this.user_tel.MinimumWidth = 6;
            this.user_tel.Name = "user_tel";
            // 
            // User_Type
            // 
            this.User_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_Type.DataPropertyName = "User_Type";
            this.User_Type.HeaderText = "管理员类型";
            this.User_Type.MinimumWidth = 6;
            this.User_Type.Name = "User_Type";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加管理员ToolStripMenuItem,
            this.删除管理员ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 添加管理员ToolStripMenuItem
            // 
            this.添加管理员ToolStripMenuItem.Name = "添加管理员ToolStripMenuItem";
            this.添加管理员ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加管理员ToolStripMenuItem.Text = "添加管理员";
            this.添加管理员ToolStripMenuItem.Click += new System.EventHandler(this.添加管理员ToolStripMenuItem_Click);
            // 
            // 删除管理员ToolStripMenuItem
            // 
            this.删除管理员ToolStripMenuItem.Name = "删除管理员ToolStripMenuItem";
            this.删除管理员ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除管理员ToolStripMenuItem.Text = "删除管理员";
            this.删除管理员ToolStripMenuItem.Click += new System.EventHandler(this.删除管理员ToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(164, 17);
            this.toolStripStatusLabel1.Text = "欢迎您的登录，超级管理员！";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Super_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_jin);
            this.Controls.Add(this.btn_seclt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_amend);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.coping);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Super_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super_Admin";
            this.Load += new System.EventHandler(this.Super_Admin_Load);
            this.coping.ResumeLayout(false);
            this.coping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel coping;
        private System.Windows.Forms.Label super_lb;
        private System.Windows.Forms.Label shut;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_seclt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_amend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_jin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除管理员ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}