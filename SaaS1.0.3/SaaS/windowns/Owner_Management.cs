using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SaaS
{
    public partial class Owner_Management : Form
    {
        public Owner_Management()
        {
            InitializeComponent();
        }
        //定义全局
        DataSet ds = new DataSet();
        //判断添加信息是否正确的方法
        private bool Faa()
        {
            if (xqname_cbb.Text == "" || ldname_cbb.Text == "")
            {
                MessageBox.Show("请选择所购房小区和所购房楼栋");
                return false;
            }
            //判断房间号是否为空
            if (this.room_tb.Text.ToString().Trim() == "")
            {
                MessageBox.Show("房间号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                return false;
            }
            //判断手机号码是否为空以及输入的手机号码长度和手机号码格式
            if (this.phone_tb.Text.ToString().Trim() == "" || this.phone_tb.Text.ToString().Trim().Length != 11)
            {
                MessageBox.Show("手机号不能为空且长度必须为11位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                return false;
            }
            else
            {
                //电信手机号码正则        
                string dianxin = @"^1[3578][01379]\d{8}$";
                Regex dReg = new Regex(dianxin);//实例化对象
                                                //联通手机号正则        
                string liantong = @"^1[34578][01256]\d{8}$";
                Regex tReg = new Regex(liantong);//实例化对象
                                                 //移动手机号正则        
                string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
                Regex yReg = new Regex(yidong);//实例化对象
                                               //判断输入的手机号码格式是否正确
                if (!(dReg.IsMatch(phone_tb.Text) || tReg.IsMatch(phone_tb.Text) || yReg.IsMatch(phone_tb.Text)))
                {
                    MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                    phone_tb.Text = ""; //如果手机号码格式不正确则输入框变成空
                    return false;
                }
            }
            //判断身份证号是否为空以及格式是否正确
            if (this.shenfen_tb.Text.ToString().Trim() == "")
            {
                MessageBox.Show("身份证号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                return false;
            }
            else
            {
                string is_ID = @"^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$";
                Regex reg = new Regex(is_ID);
                if (!reg.IsMatch(shenfen_tb.Text))
                {
                    MessageBox.Show("请输入正确的身份证！", "添加", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    shenfen_tb.Text = ""; //如果身份证不正确则输入框变成空
                    return false;
                }
            }

            return true;
        }
        //窗体加载事件
        private void Owner_Management_Load(object sender, EventArgs e)
        {
            string sql = "select * from owner_info_table";
            ds = DBHELP.GetDataSet(sql);
            dgv_Owner.AutoGenerateColumns = false;//取消自动生成列
            dgv_Owner.DataSource = ds.Tables[0];//绑定数据源
            //查询楼盘表
            string Sql = "select distinct village_name from property_table";
            DataTable dt = DBHELP.GetDataTable(Sql);
            //遍历输出小区名
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.xqname_cbb.Items.Add(dt.Rows[i][0]);
            }
            //查询楼盘表
            string SQl = "select  distinct building_number from property_table";
            DataTable db = DBHELP.GetDataTable(SQl);
            //遍历输出楼栋名
            for (int i = 0; i < db.Rows.Count; i++)
            {
                this.ldname_cbb.Items.Add(db.Rows[i][0]);
            }
        }
        //查询业主信息查询按钮点击事件
        private void btn_cha_Click(object sender, EventArgs e)
        {
            string sqlstr = string.Format("select * from owner_info_table where owner_name like '%{0}%' or room_number like '{0}%'", ownername.Text);
            ds = DBHELP.GetDataSet(sqlstr);
            dgv_Owner.AutoGenerateColumns = false;//取消自动生成列
            dgv_Owner.DataSource = ds.Tables[0];//绑定数据源
        }
        //修改信息按钮点击事件
        private void btn_xiu_Click(object sender, EventArgs e)
        {
            if (yename_tb.Text == "" && phone_tb.Text == "" && shenfen_tb.Text == "")
            {
                MessageBox.Show("修改的信息不能全为空！");
                return;
            }
            //获取选中行的业主编号
            string id = dgv_Owner.SelectedRows[0].Cells["owner_number"].Value.ToString();
            string xq = dgv_Owner.SelectedRows[0].Cells["Vlage_name"].Value.ToString();
            string ld = dgv_Owner.SelectedRows[0].Cells["building_name"].Value.ToString();
            string room = dgv_Owner.SelectedRows[0].Cells["room_num"].Value.ToString();
            if (xqname_cbb.Text != xq)
            {
                MessageBox.Show("小区信息无法修改！", "提示");
                return;
            }
            if (ldname_cbb.Text != ld)
            {
                MessageBox.Show("楼栋信息无法修改！", "提示");
                return;
            }
            if (room_tb.Text != room)
            {
                MessageBox.Show("房间号信息无法修改！", "提示");
                return;
            }
            //电信手机号码正则        
            string dianxin = @"^1[3578][01379]\d{8}$";
            Regex dReg = new Regex(dianxin);//实例化对象
                                            //联通手机号正则        
            string liantong = @"^1[34578][01256]\d{8}$";
            Regex tReg = new Regex(liantong);//实例化对象
                                             //移动手机号正则        
            string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
            Regex yReg = new Regex(yidong);//实例化对象
                                           //判断输入的手机号码格式是否正确
            if (!(dReg.IsMatch(phone_tb.Text) || tReg.IsMatch(phone_tb.Text) || yReg.IsMatch(phone_tb.Text)))
            {
                MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                phone_tb.Text = ""; //如果手机号码格式不正确则输入框变成空
                return;
            }
            string is_ID = @"^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$";
            Regex reg = new Regex(is_ID);
            if (!reg.IsMatch(shenfen_tb.Text))
            {
                MessageBox.Show("请输入正确的身份证！", "添加", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                shenfen_tb.Text = ""; //如果身份证不正确则输入框变成空
                return;
            }
            //修改业主信息SQL语句
            string updateSql = string.Format("update owner_info_table set room_number='{0}',      owner_name='{1}',owner_tel='{2}',owner_card='{3}',Village_name='{4}',Building_name='{5}' where owner_number='{6}'", room_tb.Text, yename_tb.Text, phone_tb.Text, shenfen_tb.Text, xqname_cbb.Text, ldname_cbb.Text, id);
            //判断信息是否修改成功
            if (DBHELP.ExecuteNonQuery(updateSql))
            {
                MessageBox.Show("成功修改业主 " + yename_tb.Text + " 的信息！", "修改", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //修改成功后清空文本框
                xqname_cbb.Text = "";
                ldname_cbb.Text = "";
                room_tb.Text = "";
                yename_tb.Text = "";
                phone_tb.Text = "";
                shenfen_tb.Text = "";
                //修改成功后刷新列表
                string sql = "select * from owner_info_table";
                ds = DBHELP.GetDataSet(sql);
                dgv_Owner.AutoGenerateColumns = false;//取消自动生成列
                dgv_Owner.DataSource = ds.Tables[0];//绑定数据源
            }
        }
        //添加业主信息的按钮点击事件
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                //判断方法的结果是否正确
                if (Faa() == false)
                {
                    return;
                }
                //添加业主信息SQL语句
                string str = string.Format("insert into owner_info_table values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',getdate())", room_tb.Text, yename_tb.Text, cbb_sex.Text, phone_tb.Text, shenfen_tb.Text, xqname_cbb.Text, ldname_cbb.Text, proportion_tb.Text);
                //添加水费表中的房间号SQL语句
                string waterSQL = string.Format("insert watercost_table( room_number) values('{0}')", room_tb.Text);
                //添加物业管理费表中的房间号SQL语句
                string propertyfeeSQL = string.Format("insert  propertyfee_table( room_number) values('{0}')", room_tb.Text);
                //添加电费表中的房间号SQL语句
                string electricSQL = string.Format("insert electric_cost_table( room_number) values('{0}')", room_tb.Text);
                //查询入住数量
                string num = string.Format("select COUNT(Building_name)  人数 from owner_info_table where Village_name='{0}' and Building_name='{1}'", xqname_cbb.Text, ldname_cbb.Text);
                ds = DBHELP.GetDataSet(num);
                int number = int.Parse(ds.Tables[0].Rows[0]["人数"].ToString());
                //更新入住人数
                string upSql = string.Format("update property_table set yezhnum='{0}' where village_name='{1}' and building_number='{2}'", number + 1, xqname_cbb.Text, ldname_cbb.Text);
                //判断信息是否添加成功
                if (DBHELP.ExecuteNonQuery(str) && DBHELP.ExecuteNonQuery(waterSQL) && DBHELP.ExecuteNonQuery(propertyfeeSQL) && DBHELP.ExecuteNonQuery(electricSQL) && DBHELP.ExecuteNonQuery(upSql))
                {
                    //查询入住数量
                    string shu = string.Format("select totality,yezhnum from property_table where village_name='{0}' and building_number='{1}'", xqname_cbb.Text, ldname_cbb.Text);
                    ds = DBHELP.GetDataSet(shu);
                    int one = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    int two = int.Parse(ds.Tables[0].Rows[0][1].ToString());
                    int cha = one - two;
                    string updateSQL = string.Format("update property_table set idle = '{0}' where village_name = '{1}' and building_number = '{2}'", cha, xqname_cbb.Text, ldname_cbb.Text);
                    if (DBHELP.ExecuteNonQuery(updateSQL))
                    {
                        MessageBox.Show("添加成功,恭喜成为本小区的一员！", "提示");
                        //添加成功后清空文本框
                        xqname_cbb.Text = "";
                        ldname_cbb.Text = "";
                        room_tb.Text = "";
                        yename_tb.Text = "";
                        phone_tb.Text = "";
                        shenfen_tb.Text = "";
                        //添加成功后刷新列表
                        string sql = "select * from owner_info_table";
                        ds = DBHELP.GetDataSet(sql);
                        dgv_Owner.AutoGenerateColumns = false;//取消自动生成列
                        dgv_Owner.DataSource = ds.Tables[0];//绑定数据源
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("该房间已经卖出，不可重复添加！");
            }
        }

        private void dgv_Owner_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //将表中的信息填充到文本框中
            try
            {
                xqname_cbb.Text = dgv_Owner.Rows[e.RowIndex].Cells[0].Value.ToString();
                ldname_cbb.Text = dgv_Owner.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbb_sex.Text = dgv_Owner.Rows[e.RowIndex].Cells[3].Value.ToString();
                room_tb.Text = dgv_Owner.Rows[e.RowIndex].Cells[4].Value.ToString();
                yename_tb.Text = dgv_Owner.Rows[e.RowIndex].Cells[2].Value.ToString();
                phone_tb.Text = dgv_Owner.Rows[e.RowIndex].Cells[6].Value.ToString();
                shenfen_tb.Text = dgv_Owner.Rows[e.RowIndex].Cells[7].Value.ToString();
                proportion_tb.Text = dgv_Owner.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                //异常处理
                MessageBox.Show("请点击正确位置！", "错误");
            }
        }
        //右键删除业主信息按钮点击事件
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //获取ID
                string ID = dgv_Owner.SelectedRows[0].Cells["owner_number"].Value.ToString();
                string shuliangjian = string.Format("select Village_name,Building_name from owner_info_table where owner_number='{0}'", ID);
                ds = DBHELP.GetDataSet(shuliangjian);
                string mingzi = ds.Tables[0].Rows[0]["Village_name"].ToString();
                string loudong = ds.Tables[0].Rows[0]["Building_name"].ToString();

                if (ID == "")
                {
                    MessageBox.Show("请选择需要修改的业主！", "提示");
                    return;
                }
                //获取业主的房间号
                string room = dgv_Owner.SelectedRows[0].Cells["room_num"].Value.ToString();
                DialogResult result = MessageBox.Show("是否将业主：" + yename_tb.Text + " 所有信息删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                //判断用户选择的是“是”OR“否”
                if (result == DialogResult.Yes)
                {  //删除对应水费表、电费表、物业管理费表的信息
                    string waterdelSql = string.Format("delete from watercost_table where room_number='{0}'", room);
                    string electricdelSql = string.Format("delete from electric_cost_table where room_number='{0}'", room);
                    string propertyfeedelSql = string.Format("delete from propertyfee_table where room_number='{0}'", room); string num = string.Format("select COUNT(Building_name)  人数 from owner_info_table where Village_name='{0}' and Building_name='{1}'", xqname_cbb.Text, ldname_cbb.Text);
                    ds = DBHELP.GetDataSet(num);
                    int number = int.Parse(ds.Tables[0].Rows[0]["人数"].ToString());
                    string jia = string.Format("select idle from property_table where village_name='{0}' and building_number='{1}'", mingzi, loudong);
                    ds = DBHELP.GetDataSet(jia);
                    int kong = int.Parse(ds.Tables[0].Rows[0]["idle"].ToString());
                    //更新入住人数
                    string upSql = string.Format("update property_table set yezhnum='{0}' where village_name='{1}' and building_number='{2}'", number - 1, xqname_cbb.Text, ldname_cbb.Text);

                    string shao = string.Format("update property_table set idle='{0}' where village_name='{1}' and building_number='{2}'", kong + 1, mingzi, loudong);

                    if (DBHELP.ExecuteNonQuery(electricdelSql) && DBHELP.ExecuteNonQuery(propertyfeedelSql) && DBHELP.ExecuteNonQuery(waterdelSql) && DBHELP.ExecuteNonQuery(upSql) && DBHELP.ExecuteNonQuery(shao))
                    {
                        //删除业主信息SQL语句
                        string delSql = string.Format("delete from owner_info_table where owner_number='{0}'", ID);
                        if (DBHELP.ExecuteNonQuery(delSql))
                        {
                            MessageBox.Show("成功删除业主：" + yename_tb.Text + " 所有信息！", "提示");
                            //删除成功后清空文本框
                            xqname_cbb.Text = "";
                            ldname_cbb.Text = "";
                            room_tb.Text = "";
                            yename_tb.Text = "";
                            phone_tb.Text = "";
                            shenfen_tb.Text = "";
                            proportion_tb.Text = "";
                            //删除成功后刷新列表
                            string sql = "select * from owner_info_table";
                            ds = DBHELP.GetDataSet(sql);
                            dgv_Owner.AutoGenerateColumns = false;//取消自动生成列
                            dgv_Owner.DataSource = ds.Tables[0];//绑定数据源
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("删除失败，请确认是否有业主信息！", "提示");
            }
        }
        //导出Execl明细按钮点击事件
        private void btn_MX_Click(object sender, EventArgs e)
        {
            if (dgv_Owner.Rows.Count <= 1)
            {
                MessageBox.Show("该表中没有需要导出的数据！", "提示");
                return;
            }
            string fileName = "小区业主信息表";
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
            Microsoft.Office.Interop.Excel.Workbook workbook =
                        workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet =
                        (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
                                                                                         //写入标题             
            for (int i = 0; i < dgv_Owner.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = dgv_Owner.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < dgv_Owner.Rows.Count; r++)
            {
                for (int i = 0; i < dgv_Owner.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dgv_Owner.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Owner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
