using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static SaaS.Login;

namespace SaaS.windowns
{
    public partial class Mian : Form
    {
        public Mian()
        {
            InitializeComponent();
        }
        #region 拖动
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
                case 0xA3:
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("是否退出系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("欢迎您的下次使用！再见！", "提示", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
        bool MoveFlag;
        int xPos;
        int yPos;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveFlag)
            {
                //panel1.Left += Convert.ToInt16(e.X - xPos);//设置x坐标.
                //panel1.Top += Convert.ToInt16(e.Y - yPos);//设置y坐标.
                this.Left += Convert.ToInt16(e.X - xPos);//设置x坐标.
                this.Top += Convert.ToInt16(e.Y - yPos);//设置y坐标.
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFlag = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFlag = true;//已经按下.
            xPos = e.X;//当前x坐标.
            yPos = e.Y;//当前y坐标.
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示StopCar窗体
            Charge charge = new Charge();
            AddTabPage("收费管理", charge);
            invit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //panel8.Visible = true;
            if (panel8.Visible == true)
            {
                panel8.Visible = false;
            }
            else
            {
                panel8.Visible = true;
            }
            invit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出本次登录？", "退出登录", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Hide();//隐藏上一个界面
                Login Lg = new Login();
                Lg.ShowDialog();//模式化窗体
                this.Dispose();//释放资源
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Up_owner_management_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示owner_Management窗体
            Owner_Management owner_Management = new Owner_Management();
            AddTabPage("业主信息管理", owner_Management);

            invit();
            owner_management.BackColor = Color.FromArgb(230, 230, 250);
        }
        public void invit()
        {
           //设置背景颜色
            toer.BackColor = Color.FromArgb(243, 243, 241);
            owner_management.BackColor = Color.FromArgb(243, 243, 241);
            panel2.BackColor = Color.FromArgb(243, 243, 241);
            panel3.BackColor = Color.FromArgb(243, 243, 241);
            panel4.BackColor = Color.FromArgb(243, 243, 241);
            panel5.BackColor = Color.FromArgb(243, 243, 241);
            panel6.BackColor = Color.FromArgb(243, 243, 241);
            panel7.BackColor = Color.FromArgb(243, 243, 241);
        }

        /// <summary>
        /// 向操作区域内部添加选项卡页,并在选项卡页中展示窗体
        /// </summary>
        /// <param name="TabName">标签文本</param>
        /// <param name="from">需要显示的窗体</param>
        private void AddTabPage(string TabName, Form form)
        {
            //根据标签文本，判断该选项卡页是否已经存在，防止重复
            if (TabPgeIsExist(TabName)) return;
            //选项卡页不存在，需要动态创建
            //创建选项卡页，并设置标签文本
            TabPage page = new TabPage(TabName);
            //将窗体form，添加到选项卡页中
            //注意：在TabPage中添加窗体，需要设置窗体以下两个属性
            form.TopLevel = false;  //设置为非顶级控件，否则运行报错
            form.Visible = true;    //设置为可见，否则窗体内容不显示
            page.Controls.Add(form);//将窗体添加到TabPage中
            //将TabPage对象添加到TabControl中
            this.One_form.TabPages.Add(page);
            //添加后，选中该选项卡页
            this.One_form.SelectedTab = page;
        }

        /// <summary>
        /// 判断选项卡页是否已经存在
        /// </summary>
        /// <param name="TabName">判断的依据：标签文本</param>
        /// <returns>是否存在</returns>
        private bool TabPgeIsExist(string TabName)
        {
            //先假设该选项卡不存在
            bool isExist = false;
            //遍历所有的选项卡页，验证假设是否成立
            foreach (TabPage page in this.One_form.TabPages)
            {
                if (page.Text == TabName)
                {
                    //假设不成立，更改结果
                    isExist = true;
                    //选项卡页已经存在，直接选中该选项卡
                    this.One_form.SelectedTab = page;
                    break;
                }
            }
            //返回最终结果
            return isExist;
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           
        
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Mian_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            label2.Text = "管理员：" + Login.user;
            if (File.Exists("D:/yz.txt"))
            {
                StreamReader reader = new StreamReader("D:/yz.txt");
                string yz = reader.ReadToEnd();
                int yz1 = Convert.ToInt32(yz);
                reader.Close();
                reader.Dispose();
                if (yz1 == 1)
                {
                    toolStripStatusLabel1.Text = "欢迎使用Sass管理系统,亲爱的管理员：" + Login.user;
                }


                if (yz1 == 2)
                {
                    fanhui.Visible = true;
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "欢迎使用Sass管理系统！";
            }

            //Sql语句
            string selectSql = string.Format("select * from property_table");
            ds = DBHELP.GetDataSet(selectSql);
            //取消自动生成列
            tower_list.AutoGenerateColumns = false;
            tower_list.DataSource = ds.Tables[0];//绑定数据源
                                                 // ming_pl.Text = info.num;
            /*由上至下窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_VER_POSITIVE);
            //invit();
            toer.BackColor = Color.FromArgb(230, 230, 250);
            //双缓冲

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void fanhui_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void watermarkTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void watermarkTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Real_txt_Click(object sender, EventArgs e)
        {
            //回到首页
            this.One_form.SelectedIndex = 0;
            invit();
            toer.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void InFo_group_Enter(object sender, EventArgs e)
        {

        }

        private void toer_Paint(object sender, PaintEventArgs e)
        {
            ////回到首页
            //this.One_form.SelectedIndex = 0;
            //invit();
            //toer.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void owner_management_Paint(object sender, PaintEventArgs e)
        {
            ////在操作区域内部添加选项卡页，显示owner_Management窗体
            //Owner_Management owner_Management = new Owner_Management();
            //AddTabPage("业主信息管理", owner_Management);

            //invit();
            //owner_management.BackColor = Color.FromArgb(230, 230, 250);
        }
        //定义全局数据集对象
      //  DataSet ds = new DataSet();
        int id;
        DataSet ds = new DataSet();
        public void shuaxin()
        {
            //刷新页面
            //Sql语句
            string selectSql = string.Format("select * from property_table");
            ds = DBHELP.GetDataSet(selectSql);
            //取消自动生成列
            tower_list.AutoGenerateColumns = false;
            tower_list.DataSource = ds.Tables[0];//绑定数据源
        }
        private void btn_alter_Click(object sender, EventArgs e)
        {
            //非空判断
            if (Name_text.Text == "" || Building_txt.Text == "" || level_txt.Text == "")
            {
                MessageBox.Show("修改内容不能为空！", "楼盘修改", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    //更新信息SQL语句
                    string SQL = string.Format("update property_table set village_name='{0}',building_number='{1}',tier_number='{2}',totality={3} where house_id='{4}'", Name_text.Text, Building_txt.Text, level_txt.Text, hushu_tb.Text.Trim(), id);
                    //判断数据库是否受影响
                    if (DBHELP.ExecuteNonQuery(SQL))
                    {
                        //查询入住数量
                        string shu = string.Format("select totality,yezhnum from property_table where village_name='{0}' and building_number='{1}'", Name_text.Text, Building_txt.Text);
                        ds = DBHELP.GetDataSet(shu);
                        int one = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                        int two = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
                        int cha = one - two;
                        string updateSQL = string.Format("update property_table set idle = '{0}' where village_name = '{1}' and building_number = '{2}'", cha, Name_text.Text, Building_txt.Text);
                        if (DBHELP.ExecuteNonQuery(updateSQL))
                        {
                            MessageBox.Show("修改成功", "楼盘修改", MessageBoxButtons.OK);//弹框提示
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请联系管理员，" + ex.Message);
                }
                finally
                {
                    shuaxin();
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示building_Add窗体
            Building_add building_Add = new Building_add();
            AddTabPage("添加楼盘", building_Add);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //回到首页
            this.One_form.SelectedIndex = 0;
            invit();
            toer.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示owner_Management窗体
            Owner_Management owner_Management = new Owner_Management();
            AddTabPage("业主信息管理", owner_Management);

            invit();
            owner_management.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string nameid = tower_list.SelectedRows[0].Cells["col_num"].Value.ToString();
            //声明变量接收文本框信息
            string Name = Name_text.Text;
            string Two = Building_txt.Text;
            string list = level_txt.Text;
            //非空验证
            if (Name == "" || Two == "" || list == "")
            {
                MessageBox.Show("请选择需要删除的楼盘！", "提示");//弹框提示
                return;
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("是否要将您选中的楼盘删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string sql = string.Format("delete from property_table where house_id={0}", nameid);
                        if (DBHELP.ExecuteNonQuery(sql))
                        {
                            MessageBox.Show("删除成功", "删除");//弹框提示
                            //删除成功后清空文本框
                            Name_text.Text = "";
                            Building_txt.Text = "";
                            level_txt.Text = "";
                        }
                    }
                }
                finally
                {
                    shuaxin();
                }
            }
        }

        private void btn_MX_Click(object sender, EventArgs e)
        {

            if (tower_list.Rows.Count <= 0)
            {
                MessageBox.Show("该表中没有需要导出的数据！", "提示");
                return;
            }
            string fileName = "楼盘信息表";
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
                                                                                                                                  //写入标题             
            for (int i = 0; i < tower_list.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = tower_list.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < tower_list.Rows.Count; r++)
            {
                for (int i = 0; i < tower_list.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = tower_list.Rows[r].Cells[i].Value;
                }
                Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            MessageBox.Show(fileName + "资料保存成功", "提示", MessageBoxButtons.OK);
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)//异常处理
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁   
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            //查询楼盘信息Sql语句
            string selectSql = string.Format("select * from property_table where village_name like '%{0}%' and  building_number like '%{1}%'", watermarkTextBox1.Text.Trim().ToString(), watermarkTextBox2.Text.Trim());
            DataTable dt = DBHELP.GetDataTable(selectSql);
            //取消自动生成列
            tower_list.AutoGenerateColumns = false;
            tower_list.DataSource = dt;
            //如果未查询到信息弹出提示
            if (tower_list.Rows.Count <= 0)
            {
                MessageBox.Show("未能找到相关信息,请核对您输入的信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//弹框提示
                return;
            }
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                string nameid = tower_list.SelectedRows[0].Cells["col_num"].Value.ToString();
                // MessageBox.Show(name);
                DialogResult dr = MessageBox.Show("是否要将您选中的楼盘删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = string.Format("delete from property_table where house_id={0}", nameid);
                    if (DBHELP.ExecuteNonQuery(sql))
                    {
                        MessageBox.Show("删除成功", "删除");//弹框提示
                                                      //删除成功后清空文本框
                        Name_text.Text = "";
                        Building_txt.Text = "";
                        level_txt.Text = "";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                shuaxin();
            }

        }

        private void Name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

            //在操作区域内部添加选项卡页，显示StopCar窗体
            StopCar stopCar = new StopCar();
            AddTabPage("车辆管理", stopCar);
            invit();
            panel2.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StopCar stopCar = new StopCar();
            AddTabPage("车辆管理", stopCar);
            invit();
            panel2.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示Complain窗体
            Complain complain = new Complain();
            AddTabPage("客服管理", complain);
            invit();
            panel4.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示repairs窗体
            Repairs repairs = new Repairs();
            AddTabPage("报修管理", repairs);
            invit();
            panel3.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示user_Control窗体
            Staff_Management staff_Management = new Staff_Management();
            AddTabPage("员工管理", staff_Management);
            invit();
            panel5.BackColor = Color.FromArgb(230, 230, 250);
        }
        private void One_form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //获取当前选中的Tab标签
            TabPage selectedPage = this.One_form.SelectedTab;
            //首页标签不允许移除
            if (selectedPage.Text == "首页") return;
            //移除选中的标签
            this.One_form.TabPages.Remove(selectedPage);
        }
        private void label8_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示user_Control窗体
            User_Control user_Control = new User_Control();
            AddTabPage("用户管理", user_Control);
            invit();
            panel6.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示Staff_Management窗体
            Truck_space truck_Space = new Truck_space();
            AddTabPage("车位管理", truck_Space);
            invit();
            panel7.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void tower_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //将选中单元格中信息提出
                id = int.Parse(this.tower_list.Rows[e.RowIndex].Cells["col_num"].Value.ToString());
                this.Name_text.Text = tower_list.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Building_txt.Text = tower_list.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.level_txt.Text = tower_list.Rows[e.RowIndex].Cells[2].Value.ToString();
                hushu_tb.Text = tower_list.Rows[e.RowIndex].Cells[3].Value.ToString();
                konghu_tb.Text = tower_list.Rows[e.RowIndex].Cells[5].Value.ToString();
                //当鼠标选中表中数据时，文本框变为可编辑状态
                Name_text.ReadOnly = false;
                Building_txt.ReadOnly = false;
                level_txt.ReadOnly = false;
                hushu_tb.ReadOnly = false;
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确位置！", "提示");
                return;
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            //判断控件的可见方式
            if (panel8.Visible == true)
            {
                panel8.Visible = false;
            }
            else
            {
                panel8.Visible = true;
            }
            //弹框提示关于程序
            MessageBox.Show("系统名称：SaSS小区物业管理系统\n团队名称：先锋团队\n团队负责人：刘强\n系统版本号：V 1.1.0\n发布日期：2020-06-10\n联系邮箱：487735913@qq.com\n所有权：先锋团队所有成员", "关于");
        }

        private void About_Us_Click(object sender, EventArgs e)
        {
            //pfsz pfsz = new pfsz();
            //pfsz.ShowDialog();
            Random random = new Random();
            int rd = random.Next(6);
            if (rd == 0)
            {
                //   SaaS.windowns.Mian mian = new Mian();
                //   mian.BackColor = Color.Red;
                panel1.BackColor = Color.Red;
                btn_Add.BackColor = Color.Red;
                btn_Delete.BackColor = Color.Red;
                btn_MX.BackColor = Color.Red;
                btn_Query.BackColor = Color.Red;
                fanhui.BackColor = Color.Red;
                btn_alter.BackColor = Color.Red;
                ///


            }
            else if (rd == 1)
            {
                panel1.BackColor = Color.AliceBlue;
                btn_Add.BackColor = Color.AliceBlue;
                btn_Delete.BackColor = Color.AliceBlue;
                btn_MX.BackColor = Color.AliceBlue;
                btn_Query.BackColor = Color.AliceBlue;
                fanhui.BackColor = Color.AliceBlue;
                btn_alter.BackColor = Color.AliceBlue;
            }
            else if (rd == 2)
            {
                panel1.BackColor = Color.BurlyWood;
                btn_Add.BackColor = Color.BurlyWood;
                btn_Delete.BackColor = Color.BurlyWood;
                btn_MX.BackColor = Color.BurlyWood;
                btn_Query.BackColor = Color.BurlyWood;
                fanhui.BackColor = Color.BurlyWood;
                btn_alter.BackColor = Color.BurlyWood;
            }
            else if (rd == 3)
            {
                panel1.BackColor = Color.CadetBlue;
                btn_Add.BackColor = Color.CadetBlue;
                btn_Delete.BackColor = Color.CadetBlue;
                btn_MX.BackColor = Color.CadetBlue;
                btn_Query.BackColor = Color.CadetBlue;
                fanhui.BackColor = Color.CadetBlue;
                btn_alter.BackColor = Color.CadetBlue;
            }
            else if (rd == 4)
            {
                panel1.BackColor = Color.Yellow;
                btn_Add.BackColor = Color.Yellow;
                btn_Delete.BackColor = Color.Yellow;
                btn_MX.BackColor = Color.Yellow;
                btn_Query.BackColor = Color.Yellow;
                fanhui.BackColor = Color.Yellow;
                btn_alter.BackColor = Color.Yellow;
            }
            else if (rd == 5)
            {
                panel1.BackColor = Color.Fuchsia;
                btn_Add.BackColor = Color.Fuchsia;
                btn_Delete.BackColor = Color.Fuchsia;
                btn_MX.BackColor = Color.Fuchsia;
                btn_Query.BackColor = Color.Fuchsia;
                fanhui.BackColor = Color.Fuchsia;
                btn_alter.BackColor = Color.Fuchsia;
            }
        }

        private void 打开系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mian mian = new Mian();
            mian.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Mian mian = new Mian();
            mian.ShowDialog();
        }
    }
}
