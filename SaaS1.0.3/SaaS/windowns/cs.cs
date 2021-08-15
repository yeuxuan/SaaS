using System;
using System.Data;
using System.Windows.Forms;

namespace SaaS.windowns
{
    public partial class Cs : Form
    {
        DataSet ds = new DataSet();
        public Cs()
        {
            InitializeComponent();
        }

        private void Cs_Load(object sender, EventArgs e)
        {
            show();
        }
        private void show()
        {

            string sql = "select id,name,birthday from Table_1";
            ds = DBHELP.SqlDataAdapterDap(sql);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
            ds.Dispose();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            DataView dv = new DataView(ds.Tables[0]);
            //DataView dv = ds.Tables[0].DefaultView;
            // dv.RowFilter = string.Format("name like '%{0}%' ",key);
            dv.Sort = string.Format("id desc");
            this.dataGridView1.DataSource = dv;
        }
    }
}
