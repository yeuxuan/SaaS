using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static 汤臣一品小区物业管理系统.Main.ControlAccessibleObject;

namespace SaaS
{
    public partial class Staff_Management : Form
    {
        public Staff_Management()
        {
            InitializeComponent();
        }
        //定义全局
        DataSet ds = new DataSet();
        string id;
        DateTime Time;

        /// <summary>
        /// 是否为日期型字符串
        /// </summary>
        /// <param name="StrSource">日期字符串(2008-05-08)</param>
        /// <returns></returns>
        public static bool IsDate(string StrSource)
        {
            return Regex.IsMatch(StrSource, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$");
        }
        private void Staff_Management_Load(object sender, EventArgs e)
        {

            //查询信息SQL语句
            string SelectSql = "select * from post_info_table";
            ds = DBHELP.GetDataSet(SelectSql);
            dgv_dividion.DataSource = ds.Tables[0];

            //查询信息SQL语句
            string selectSql = "select * from staff_info_table";
            ds = DBHELP.GetDataSet(selectSql);
            staff_dgv.DataSource = ds.Tables[0];
            //查询职位表，并遍历所有的部门
            string SQL = "select * from post_info_table";
            DataTable dt = DBHELP.GetDataTable(SQL);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.cbb_section.Items.Add(dt.Rows[i][1]);
            }
            //查询职位表，并遍历所有的岗位
            string SqL = "select * from post_info_table";
            DataTable dt_1 = DBHELP.GetDataTable(SqL);
            for (int i = 0; i < dt_1.Rows.Count; i++)
            {
                this.cbb_post.Items.Add(dt.Rows[i][2]);
            }
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectSql = string.Format("select * from staff_info_table where name like '%{0}%' or staffinfo_id like '%{0}%'", InFo_tb.Text);
                ds = DBHELP.GetDataSet(SelectSql);
                staff_dgv.DataSource = ds.Tables[0];
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("未找到与关键字‘ "+ InFo_tb.Text+" ’;相匹配的员工信息！","查询");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请联系管理员！");
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //声明变量存储文本框信息
            string job_num = job_num_tb.Text;
            string staffname = tb_staffname.Text;
            string sex = cbb_sex.Text;
            string age = tb_age.Text;
            string section = cbb_section.Text;
            string post = cbb_post.Text;
            string FID = tb_ID.Text;
            string brithday = tb_brithday.Text;
            string address = tb_address.Text;
            string Salary = tb_Salary.Text;
            string Phone = tb_Phone.Text;
            if (job_num == "" || staffname == "" || sex == "" || age == "" || section == "" || post == "" || FID == "" || brithday == "" || address == "" || Salary == "" || Phone == "")
            {
                MessageBox.Show("所有员工信息不允许为空！", "添加");
                return;
            }
            else
            {
                string is_ID = @"^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$";
                Regex reg = new Regex(is_ID);
                if (!reg.IsMatch(tb_ID.Text))
                {
                    MessageBox.Show("请输入正确的身份证！", "添加");
                    tb_ID.Text = ""; //如果身份证不正确则输入框变成空
                    return;
                }
                if (IsDate(tb_brithday.Text) != true)
                {
                    MessageBox.Show("请填写正确的生日！", "添加");
                    tb_brithday.Text = ""; //如果生日格式不正确则输入框变成空
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
                if (!(dReg.IsMatch(tb_Phone.Text) || tReg.IsMatch(tb_Phone.Text) || yReg.IsMatch(tb_Phone.Text)))
                {
                    MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                    tb_Phone.Text = ""; //如果手机号码格式不正确则输入框变成空
                    return;
                }
                //添加信息
                string insertSql = string.Format("insert staff_info_table(staffinfo_id,name,sex,age,bu,section,ID_number,birthday,address,Salary,Phone) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", job_num, staffname, sex, age, section, post, FID, brithday, address, Salary, Phone);
                //判断数据库是否受影响
                if (DBHELP.ExecuteNonQuery(insertSql))
                {
                    MessageBox.Show("成功添加员工信息", "添加");
                    //添加成功后清空文本框
                    job_num = "";
                    staffname = "";
                    sex = "";
                    age = "";
                    post = "";
                    FID = "";
                    brithday = "";
                    address = "";
                    Salary = "";
                    Phone = "";
                    //添加成功后刷新列表
                    string selectSql = string.Format("select * from staff_info_table");
                    DataTable dt = DBHELP.GetDataTable(selectSql);
                    staff_dgv.DataSource = dt;
                }
            }
        }

        private void staff_dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.job_num_tb.Text = staff_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.tb_staffname.Text = staff_dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.cbb_sex.Text = staff_dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.tb_age.Text = staff_dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.cbb_section.Text = staff_dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.cbb_post.Text = staff_dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.tb_ID.Text = staff_dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.tb_brithday.Text = staff_dgv.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.tb_address.Text = staff_dgv.Rows[e.RowIndex].Cells[8].Value.ToString();
                this.tb_Salary.Text = staff_dgv.Rows[e.RowIndex].Cells[9].Value.ToString();
                this.tb_Phone.Text = staff_dgv.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确位置");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //声明变量存储结果
            bool result = true;
            if (staff_dgv.SelectedRows.Count > 0)
            {
                for (int i = 0; i < staff_dgv.SelectedRows.Count; i++)
                {
                    //获取工号
                    id = staff_dgv.SelectedRows[i].Cells[0].Value.ToString();
                    string delSql = string.Format("delete staff_info_table where staffinfo_id='{0}'", id);
                    result = DBHELP.ExecuteNonQuery(delSql);
                }
                if (result == true)
                {
                    MessageBox.Show("删除成功", "删除");
                    //清空文本框并刷新列表
                    job_num_tb.Text = "";
                    tb_staffname.Text = "";
                    cbb_sex.Text = "";
                    tb_age.Text = "";
                    cbb_section.Text = "";
                    cbb_post.Text = "";
                    tb_ID.Text = "";
                    tb_brithday.Text = "";
                    tb_address.Text = "";
                    tb_Salary.Text = "";
                    tb_Phone.Text = "";
                    //Sql语句
                    string selectSql = string.Format("select * from staff_info_table");
                    DataTable dt = DBHELP.GetDataTable(selectSql);
                    staff_dgv.DataSource = dt;//绑定数据源
                    return;
                }
            }
        }

        private void btn_alter_Click(object sender, EventArgs e)
        {
            string id = staff_dgv.SelectedRows[0].Cells[0].Value.ToString();
            if (id == "" || tb_staffname.Text == "" || cbb_sex.Text == "" || tb_age.Text == "" || cbb_section.Text == "" || cbb_post.Text == "" || tb_ID.Text == "" || tb_brithday.Text == "" || tb_address.Text == "" || tb_Salary.Text == "" || tb_Phone.Text == "")
            {
                MessageBox.Show("请选择您需要修改信息的员工!", "修改");
                return;
            }
            Time = DateTime.Parse(this.staff_dgv.SelectedRows[0].Cells[11].Value.ToString());
            //判断用户修改的身份证格式是否正确
            string is_ID = @"^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$";
            Regex reg = new Regex(is_ID);
            if (!reg.IsMatch(tb_ID.Text))
            {
                MessageBox.Show("请输入正确的身份证！", "添加");
                tb_ID.Text = ""; //如果身份证不正确则输入框变成空
                return;
            }
            if (IsDate(tb_brithday.Text) != true)//判断用户修改的生日格式是否正确
            {
                MessageBox.Show("请填写正确的生日！", "添加");
                tb_brithday.Text = ""; //如果生日格式不正确则输入框变成空
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
            if (!(dReg.IsMatch(tb_Phone.Text) || tReg.IsMatch(tb_Phone.Text) || yReg.IsMatch(tb_Phone.Text)))
            {
                MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                tb_Phone.Text = ""; //如果手机号码格式不正确则输入框变成空
                return;
            }
            //修改员工信息SQL语句
            string alterSql = string.Format("update staff_info_table set name='{0}',sex='{1}',age='{2}',bu='{3}',section='{4}',ID_number='{5}',birthday='{6}',address='{7}',Salary='{8}',Phone='{9}',Time='{10}' where staffinfo_id='{11}'", tb_staffname.Text, cbb_sex.Text, tb_age.Text, cbb_section.Text, cbb_post.Text, tb_ID.Text, tb_brithday.Text, tb_address.Text, tb_Salary.Text, tb_Phone.Text, Time, id);
            //判断修改是否成功
            if (DBHELP.ExecuteNonQuery(alterSql))
            {
                MessageBox.Show("成功修改工号：" + id + " 员工的信息", "修改");
                //成功修改员工信息后清空文本框
                job_num_tb.Text = "";
                tb_staffname.Text = "";
                cbb_sex.Text = "";
                tb_age.Text = "";
                cbb_section.Text = "";
                cbb_post.Text = "";
                tb_ID.Text = "";
                tb_brithday.Text = "";
                tb_address.Text = "";
                tb_Salary.Text = "";
                tb_Phone.Text = "";
                //成功修改员工信息后刷新列表
                string selectSql = string.Format("select * from staff_info_table");
                DataTable dt = DBHELP.GetDataTable(selectSql);
                staff_dgv.DataSource = dt;//绑定数据源
                return;
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            //Division_Management division_Management = new Division_Management();
            //division_Management.Show();
        }

        private void dgv_dividion_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 将表中的信息显示在文本框中
            try
            {
                textBox1.Text = dgv_dividion.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dgv_dividion.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("请点击正确位置");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staff_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show("请选择您需要修改信息的员工!", "修改");
                return;
            }
            else
            {
                string sql = string.Format("insert into post_info_table(duty,department) values ('{0}','{1}')",textBox1.Text,textBox2.Text);

                if (DBHELP.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }

        private void btn_gai_Click(object sender, EventArgs e)
        {

        }

        private void dgv_dividion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tp_division_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sr = watermarkTextBox1.Text.Trim();
            string sql = string.Format("select * from post_info_table where duty like '{0}%%' or department like '{1}%%'",sr,sr);
            DataSet dt = DBHELP.GetDataSet(sql);
            this.dgv_dividion.DataSource = dt.Tables[0];
            //DataView gridView = ds.Tables[1].DefaultView;
            //gridView.RowFilter = string.Format("duty like '{0}%%' or department like '{1}%%'",sr,sr);
            //dgv_dividion.DataSource = gridView;


        }
    }
}
