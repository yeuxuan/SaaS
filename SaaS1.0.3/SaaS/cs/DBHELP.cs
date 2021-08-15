using System.Data;
using System.Data.SqlClient;

namespace SaaS
{
    class DBHELP
    {
        //服务器连接字符
        public static string Connstring = "server=.;database=SaaS management system;Integrated Security=true;";
        //连接状态
        public static SqlConnection Conn = null;

        //连接
        public static void InitConnection()
        {
            if (Conn == null)
            {
                //是否连接
                Conn = new SqlConnection(Connstring);
            }
            if (Conn.State == ConnectionState.Closed)
            {
                //连接关闭
                Conn.Open();
            }
            if (Conn.State == ConnectionState.Broken)
            {
                //连接中断
                Conn.Close();
                Conn.Open();
            }

        }

        //读写
        public static SqlDataReader GetDataReader(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);//没有命令关闭
        }
        //增加，添加，修改
        public static bool ExecuteNonQuery(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            return result > 0;

        }

        //聚合函数
        public static object ExecuteScalay(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            object result = cmd.ExecuteScalar();
            Conn.Close();
            return result;
        }

        //数据库读写
        public static DataSet SqlDataAdapterDap(string sqlstr)
        {

            InitConnection();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            SqlDataAdapter dap = new SqlDataAdapter(sqlstr, Conn);
            dap.Fill(ds);
            //DataTable dt = ds.Tables[0];
            Conn.Close();
            //Conn.Dispose();
            return ds;
        }


        //获得数据表集
        public static DataSet GetDataSet(string strSQL)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(strSQL, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }


        public static DataTable DataTable(string sqlstr)
        {
            InitConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sqlstr, Conn);
            dap.Fill(dt);
            Conn.Close();
            return dt;



        }


        //查询，获取DataTable
        public static DataTable GetDataTable(string sqlStr)
        {
            InitConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sqlStr, Conn);
            dap.Fill(dt);
            Conn.Close();
            return dt;
        }

    }
}
