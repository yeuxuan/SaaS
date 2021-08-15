using System;
using System.Data;
using System.Windows.Forms;

namespace SaaS
{
    public partial class function : Form
    {

        int index = 0;
        DataSet ds = new DataSet();
        public function()
        {
            InitializeComponent();
        }

        private void function_Load(object sender, EventArgs e)
        {
            ConnDate();
            ShowProduct();
            //SqlDataAdapterDap(ds);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void ConnDate()
        {

            string sql = "select id,name,birthday from Table_1";
            ds = DBHELP.SqlDataAdapterDap(sql);
            // DataTable dt = ss.Tables[0];

            //    DBHELP.SqlDataAdapterDap(ds);
            //  string ConnString = "server=localhost;database=tst;uid=sa;pwd=123456;";
            //SqlConnection conn = new SqlConnection(ConnString);
            //SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            //MessageBox.Show(dap.Fill(ds).ToString());
            // dap.Fill(ds);
            //conn.Close();
            //conn.Dispose();
        }


        private void ShowProduct()
        {
            DataTable dt = ds.Tables[0];
            textBox1.Text = Convert.ToString(dt.Rows[index]["name"]);
            textBox2.Text = Convert.ToString(dt.Rows[index]["birthday"]);
            if (index == 0)
            {
                button1.Enabled = false;
            }
            else if (index == dt.Rows.Count - 1)
            {
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            //DataTable dtProduct = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            ShowProduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            ShowProduct();
        }
    }
}
