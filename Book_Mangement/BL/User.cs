using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Book_Mangement
{
    class User
    {
        DAL.Dal Dal = new DAL.Dal();
        public DataTable dt(string name,string pass)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("name", name);
            pr[1] = new SqlParameter("pass", pass);
            return Dal.Read("Login", pr);
        }

     
    }
}
