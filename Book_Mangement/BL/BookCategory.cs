using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Book_Mangement.BL
{
    class BookCategory
    {
        DAL.Dal Dal = new DAL.Dal();
        public DataTable ReadCategories()
        {
            SqlParameter[] pr = null;
            return Dal.Read("ReadCategories", pr);
        }
    }
}
