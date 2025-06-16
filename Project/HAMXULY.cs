using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    class HAMXULY
    {
        public static SqlConnection conn;
        public static void Connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=MACBOOK-PRO\SQLEXPRESS;Initial Catalog=QLCK;Integrated Security=True";
            conn.Open();    
        }   
        public static void Disconnected()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null; 
            }
        }
        public static Boolean TruyVan(string query, DataTable dt)
        {
            
            Boolean kq = false;
            SqlDataAdapter da;

            try
            {
                da= new SqlDataAdapter(query,conn);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    kq = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(query);
                MessageBox.Show(ex.Message);

            }



            return kq;
        }
        public static void RunSql(string query){
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã thực hiện thành công");

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            cmd.Dispose();
            
        }
        

    }
}
