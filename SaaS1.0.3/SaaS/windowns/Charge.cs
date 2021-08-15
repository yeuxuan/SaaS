using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaaS
{
    public partial class Charge : Form
    {
        public Charge()
        {
            InitializeComponent();
        }
        //定义全局
      //  bool a = true;
      //  bool b = true;
      //  bool c = true;
        //表中列的是否可见
        private bool Result()
        {
            this.dgv_info.Columns[1].Visible = true;
            this.dgv_info.Columns[2].Visible = true;
            this.dgv_info.Columns[3].Visible = true;
            this.dgv_info.Columns[4].Visible = true;
            this.dgv_info.Columns[5].Visible = true;
            this.dgv_info.Columns[6].Visible = true;
            this.dgv_info.Columns[7].Visible = true;
            this.dgv_info.Columns[8].Visible = true;
            this.dgv_info.Columns[9].Visible = true;
            return true;
        }

        //窗体加载事件
        private void Charge_Load(object sender, EventArgs e)
        {
            //查询水费表 电费表 物业管理费表SQL语句 
            string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
            DataSet dt = new DataSet();
            dt = DBHELP.GetDataSet(selectsql);
            //取消自动生成列
            dgv_info.AutoGenerateColumns = false;
            //绑定数据源
            dgv_info.DataSource = dt.Tables[0];
        }
        //查询按钮点击事件
        private void btn_select_Click(object sender, EventArgs e)
        {
            //如果查询下拉框选中的是水费，则只查询水费表的信息
            if (cb_type.Text == "水费")
            {
                if (Result())
                {
                    string selectsql = string.Format("select * from owner_info_table a   join watercost_table d on a.room_number=d.room_number");
                    DataSet dt = new DataSet();
                    dt = DBHELP.GetDataSet(selectsql);
                    dgv_info.AutoGenerateColumns = false;//取消自动生成列
                    dgv_info.DataSource = dt.Tables[0];//绑定数据源
                    this.dgv_info.Columns[5].Visible = false;
                    this.dgv_info.Columns[6].Visible = false;
                    this.dgv_info.Columns[7].Visible = false;
                    this.dgv_info.Columns[8].Visible = false;
                    this.dgv_info.Columns[9].Visible = false;
                    this.dgv_info.Columns[10].Visible = false;
                }
            }
            //如果查询下拉框选中的是电费，则只查询电费表的信息
            else if (cb_type.Text == "电费")
            {
                if (Result())
                {
                    string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number");
                    DataSet dt = new DataSet();
                    dt = DBHELP.GetDataSet(selectsql);
                    dgv_info.AutoGenerateColumns = false;//取消自动生成列
                    dgv_info.DataSource = dt.Tables[0];//绑定数据源
                    this.dgv_info.Columns[2].Visible = false;
                    this.dgv_info.Columns[3].Visible = false;
                    this.dgv_info.Columns[4].Visible = false;
                    this.dgv_info.Columns[8].Visible = false;
                    this.dgv_info.Columns[9].Visible = false;
                    this.dgv_info.Columns[10].Visible = false;
                }
            }

            if (cb_type.Text == "物业管理费")//如果查询下拉框选中的是物业管理费，则只查询物业管理费表的信息
            {
                if (Result())
                {
                    string selectsql = string.Format("select * from owner_info_table a  join  propertyfee_table c on a.room_number=c.room_number");
                    DataSet dt = new DataSet();
                    dt = DBHELP.GetDataSet(selectsql);
                    dgv_info.AutoGenerateColumns = false;//取消自动生成列
                    dgv_info.DataSource = dt.Tables[0];//绑定数据源
                    this.dgv_info.Columns[2].Visible = false;
                    this.dgv_info.Columns[3].Visible = false;
                    this.dgv_info.Columns[4].Visible = false;
                    this.dgv_info.Columns[5].Visible = false;
                    this.dgv_info.Columns[6].Visible = false;
                    this.dgv_info.Columns[7].Visible = false;
                }
            }
            if (cb_type.Text == "全部")//如果查询下拉框选中的是全部，则查询物业管理费表、水费表、电费表三表的信息
            {
                if (Result())
                {
                    string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
                    DataSet dt = new DataSet();
                    dt = DBHELP.GetDataSet(selectsql);
                    dgv_info.AutoGenerateColumns = false;//取消自动生成列
                    dgv_info.DataSource = dt.Tables[0];//绑定数据源
                }
            }
        }

        //private void btn_add_Click(object sender, EventArgs e)
        //{
        //    Charge_Add addinfo = new Charge_Add();
        //    addinfo.ShowDialog();
        //    string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
        //    DataSet dt = new DataSet();
        //    dt = DBHELP.GetDataSet(selectsql);
        //    dgv_info.AutoGenerateColumns = false;
        //    dgv_info.DataSource = dt.Tables[0];
        //}

        //private void btn_update_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string state1 = dgv_info.SelectedRows[0].Cells[2].Value.ToString();
        //        string state2 = dgv_info.SelectedRows[0].Cells[5].Value.ToString();
        //        string state3 = dgv_info.SelectedRows[0].Cells[8].Value.ToString();
        //        if (state1 == "未缴费" && state2 == "未缴费" && state3 == "未缴费")
        //        {
        //            string sqlupdate1 = string.Format("update watercost_table set    payment_status1='{0}',time1=getdate() where room_number='{1}'", cb_water.Text, roomnum_cb.Text);
        //            a = DBHELP.ExecuteNonQuery(sqlupdate1);
        //            string sqlupdate2 = string.Format("update electric_cost_table set payment_status2='{0}',time2=getdate() where room_number='{1}'", cb_electric.Text, roomnum_cb.Text);
        //            b = DBHELP.ExecuteNonQuery(sqlupdate2);
        //            string sqlupdate3 = string.Format("update propertyfee_table set payment_status3='{0}',time3=getdate() where room_number='{1}'", cb_wuyei.Text, roomnum_cb.Text);
        //            c = DBHELP.ExecuteNonQuery(sqlupdate3);
        //            if (a && b && c)
        //            {
        //                MessageBox.Show("结算成功!", "提示");
        //                string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
        //                DataSet dt = new DataSet();
        //                dt = DBHELP.GetDataSet(selectsql);
        //                dgv_info.AutoGenerateColumns = false;
        //                dgv_info.DataSource = dt.Tables[0];
        //                return;
        //            }
        //            else
        //            {
        //                MessageBox.Show("结算失败!", "提示");
        //            }

        //        }
        //        else if (state1 == "未缴费" && state2 == "未缴费" && state3 == "已缴费")
        //        {
        //            string sqlupdate1 = string.Format("update watercost_table set    payment_status1='{0}',time1=getdate() where room_number='{1}'", cb_water.Text, roomnum_cb.Text);
        //            a = DBHELP.ExecuteNonQuery(sqlupdate1);
        //            string sqlupdate2 = string.Format("update electric_cost_table set payment_status2='{0}',time2=getdate() where room_number='{1}'", cb_electric.Text, roomnum_cb.Text);
        //            b = DBHELP.ExecuteNonQuery(sqlupdate2);
        //            if (a && b && c)
        //            {
        //                MessageBox.Show("修改成功!", "提示");
        //                string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
        //                DataSet dt = new DataSet();
        //                dt = DBHELP.GetDataSet(selectsql);
        //                dgv_info.AutoGenerateColumns = false;
        //                dgv_info.DataSource = dt.Tables[0];
        //                return;
        //            }
        //            else
        //            {
        //                MessageBox.Show("结算失败!", "提示");
        //            }

        //        }
        //        else if (state1 == "未缴费" && state2 == "已缴费" && state3 == "未缴费")
        //        {
        //            string sqlupdate1 = string.Format("update watercost_table set    payment_status1='{0}',time1=getdate() where room_number='{1}'", cb_water.Text, roomnum_cb.Text);
        //            a = DBHELP.ExecuteNonQuery(sqlupdate1);
        //            string sqlupdate3 = string.Format("update propertyfee_table set payment_status3='{0}',time3=getdate() where room_number='{1}'", cb_wuyei.Text, roomnum_cb.Text);
        //            c = DBHELP.ExecuteNonQuery(sqlupdate3);
        //            c = DBHELP.ExecuteNonQuery(sqlupdate3);
        //            if (a && b && c)
        //            {
        //                MessageBox.Show("结算成功!", "提示");
        //                string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
        //                DataSet dt = new DataSet();
        //                dt = DBHELP.GetDataSet(selectsql);
        //                dgv_info.AutoGenerateColumns = false;
        //                dgv_info.DataSource = dt.Tables[0];
        //                return;
        //            }
        //            else
        //            {
        //                MessageBox.Show("结算失败!", "提示");
        //                return;
        //            }
        //        }
        //        else if (state1 == "已缴费" && state2 == "未缴费" && state3 == "未缴费")
        //        {
        //            string sqlupdate2 = string.Format("update electric_cost_table set payment_status2='{0}',time2=getdate() where room_number='{1}'", cb_electric.Text, roomnum_cb.Text);
        //            b = DBHELP.ExecuteNonQuery(sqlupdate2);
        //            string sqlupdate3 = string.Format("update propertyfee_table set payment_status3='{0}',time3=getdate() where room_number='{1}'", cb_wuyei.Text, roomnum_cb.Text);
        //            c = DBHELP.ExecuteNonQuery(sqlupdate3);
        //            if (a && b && c)
        //            {
        //                MessageBox.Show("结算成功!", "结算");
        //                string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
        //                DataSet dt = new DataSet();
        //                dt = DBHELP.GetDataSet(selectsql);
        //                dgv_info.AutoGenerateColumns = false;//取消自动生成列
        //                dgv_info.DataSource = dt.Tables[0];//绑定数据源
        //                return;
        //            }
        //            else
        //            {
        //                MessageBox.Show("结算失败!", "提示");
        //                return;
        //            }
        //        }
        //        else if (state1 == "已缴费" && state2 == "已缴费" && state3 == "未缴费")
        //        {
        //            string sqlupdate3 = string.Format("update propertyfee_table set payment_status3='{0}',time3=getdate() where room_number='{1}'", cb_wuyei.Text, roomnum_cb.Text);
        //            c = DBHELP.ExecuteNonQuery(sqlupdate3);
        //            if (a && b && c)
        //            {
        //                MessageBox.Show("修改成功!", "提示");
        //                string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
        //                DataSet dt = new DataSet();
        //                dt = DBHELP.GetDataSet(selectsql);
        //                dgv_info.AutoGenerateColumns = false;
        //                dgv_info.DataSource = dt.Tables[0];
        //                return;
        //            }
        //            else
        //            {
        //                MessageBox.Show("结算失败!", "提示");
        //                return;
        //            }
        //        }
        //        else if (state1 == "未缴费" && state2 == "已缴费" && state3 == "已缴费")
        //        {
        //            string sqlupdate1 = string.Format("update watercost_table set    payment_status1='{0}',time1=getdate() where room_number='{1}'", cb_water.Text, roomnum_cb.Text);
        //            a = DBHELP.ExecuteNonQuery(sqlupdate1);

        //            if (a && b && c)
        //            {
        //                MessageBox.Show("结算成功!", "提示");
        //                string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
        //                DataSet dt = new DataSet();
        //                dt = DBHELP.GetDataSet(selectsql);
        //                dgv_info.AutoGenerateColumns = false;
        //                dgv_info.DataSource = dt.Tables[0];
        //                return;
        //            }
        //            else
        //            {
        //                MessageBox.Show("结算失败!", "提示");
        //                return;
        //            }

        //        }
        //        else if (state1 == "已缴费" && state2 == "未缴费" && state3 == "已缴费")
        //        {

        //            string sqlupdate2 = string.Format("update electric_cost_table set payment_status2='{0}',time2=getdate() where room_number='{1}'", cb_electric.Text, roomnum_cb.Text);
        //            b = DBHELP.ExecuteNonQuery(sqlupdate2);

        //            if (a && b && c)
        //            {
        //                MessageBox.Show("结算成功!", "提示");
        //                string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
        //                DataSet dt = new DataSet();
        //                dt = DBHELP.GetDataSet(selectsql);
        //                dgv_info.AutoGenerateColumns = false;
        //                dgv_info.DataSource = dt.Tables[0];
        //                return;
        //            }

        //        }
        //        else if (state1 == "已缴费" && state2 == "已缴费" && state3 == "已缴费")
        //        {
        //            MessageBox.Show("用户费用都已缴,无需结算！", "提示");
        //            return;
        //        }
        //        else
        //        {
        //            MessageBox.Show("请联系管理员！");
        //            return;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("未选择对相应的房间！","提示");
        //    }


        //}
        

        private void dgv_info_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //获取房间号存储在ID类中
            cs.ID.id = dgv_info.SelectedRows[0].Cells["Colroom_number"].Value.ToString();
            //if (ID.id == "")
            //{
            //    MessageBox.Show("请点击正确位置！");
            //    return;
            //}
            Update update = new Update();
            update.ShowDialog();//模式窗体
            string selectsql = string.Format("select * from owner_info_table a  join electric_cost_table b on a.room_number=b.room_number join propertyfee_table c on a.room_number=c.room_number join watercost_table d on a.room_number=d.room_number");
            DataSet dt = new DataSet();
            dt = DBHELP.GetDataSet(selectsql);
            dgv_info.AutoGenerateColumns = false;//取消自动生成列
            dgv_info.DataSource = dt.Tables[0];//绑定数据源
        }

        private void dgv_info_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                roomnum_cb.Text = dgv_info.SelectedRows[0].Cells[0].Value.ToString();
                cb_water.Text = dgv_info.SelectedRows[0].Cells[3].Value.ToString();
                cb_electric.Text = dgv_info.SelectedRows[0].Cells[6].Value.ToString();
                cb_wuyei.Text = dgv_info.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确位置！","提示");
                return;
            }
        }
        //导出明细按钮点击事件
        private void btn_MX_Click(object sender, EventArgs e)
        {
            string fileName = "业主缴费信息表";
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
            for (int i = 0; i < dgv_info.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = dgv_info.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < dgv_info.Rows.Count; r++)
            {
                for (int i = 0; i < dgv_info.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dgv_info.Rows[r].Cells[i].Value;
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

        private void dgv_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
