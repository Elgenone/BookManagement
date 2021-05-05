using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Book_Mangement.DAL
{
    class Dal
    {
        SqlConnection con;
        // cnsteractor
       public Dal()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DbBook.mdf;Integrated Security=True");
        }

        //open connection
        public void open()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        //close connection
        public void close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        //read date
        public DataTable Read(string str, SqlParameter[] pr)
        {

            SqlCommand sc = new SqlCommand();
            sc.Connection = con;
            sc.CommandType = CommandType.StoredProcedure;
            sc.CommandText = str;
            if (pr != null)
                sc.Parameters.AddRange(pr);

            SqlDataAdapter da = new SqlDataAdapter(sc);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //insert,update,delete date
        public void Excute(string str, SqlParameter[] pr)
        {

            SqlCommand sc = new SqlCommand();
            sc.Connection = con;
            sc.CommandType = CommandType.StoredProcedure;
            sc.CommandText = str;
            if (pr != null)
                sc.Parameters.AddRange(pr);

            _ = sc.ExecuteNonQuery();
           
        }
    }
}
