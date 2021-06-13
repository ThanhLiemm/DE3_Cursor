using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Do_An_So3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn;
        public static String connectionString = "Data Source=DESKTOP-GTSSSM9;Initial Catalog=CHUNGKHOAN;Integrated Security=True"; //chuổi này có thể được lấy bằng visual hoặc tự tạo nếu có nhiều server
        //hàm kết nối tới sever
        public static int connection()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.conn = new SqlConnection(Program.connectionString);
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("---> Lỗi kết nối cơ sỡ dữ liệu. <--- \n" + e.Message, string.Empty, MessageBoxButtons.OK);
                return 0;
            }
        }
        //hàm đọc dữ liệu ở đây nếu đọc thì ta dùng SqlDataReader
        public static SqlDataReader readData_Reader(String strCmd)
        {
            SqlDataReader myReader;
            //tạo đối tượng thực thi lệnh  SqlCommand
            SqlCommand sqlCmd = new SqlCommand(strCmd, Program.conn);
            //xác định kiểu cho sqlCmd
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandTimeout = 600; //tránh trường hợp bị đứng
            if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlCmd.ExecuteReader();
                return myReader;
            }
            catch (Exception e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }
        //hàm ghi
        public static void ExecSqlDataTable(String cmd)
        {
            //DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            //da.Fill(dt);
            conn.Close();
            //return dt;
        }
        public static void ExecSP_KHOPLENH_LO(String ma,String ngay,String loaigd,String soluongmb,String giamb)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_KHOPLENH_LO";
            //dien parameter
            cmd.Parameters.Add("macp", ma);
            cmd.Parameters.Add("Ngay", ngay);
            cmd.Parameters.Add("LoaiGD",loaigd);
            cmd.Parameters.Add("soluongMB",soluongmb);
            cmd.Parameters.Add("giadatMB",giamb);
            cmd.Connection = conn;
            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
           
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm1());
        }
    }
}
