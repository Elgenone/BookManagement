using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Book_Mangement.BL
{
    class Book
    {
        DAL.Dal Dal = new DAL.Dal();
        //get books
        public DataTable ReadBooks()
        {
            SqlParameter[] pr = null;
            return Dal.Read("ReadBooks", pr);
        }

        //get books
        public DataTable Search(string search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("search", search);
            return Dal.Read("BookSearch", pr);
        }
        //delete book
        public void DeleteBook(int id)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("id", id);

            Dal.open();
            Dal.Excute("DeleteBook", pr);
            Dal.close();
        }
        //insert(add) book
        public void AddBook(string title,string author,float price,string catagory,DateTime date, int rate , byte[] cover)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("title", title);
            pr[1] = new SqlParameter("author", author);
            pr[2] = new SqlParameter("price", price);
            pr[3] = new SqlParameter("catagory", catagory);
            pr[4] = new SqlParameter("date", date);
            pr[5] = new SqlParameter("rate", rate);
            pr[6] = new SqlParameter("cover", cover);


            Dal.open();
            Dal.Excute("AddBook", pr);
            Dal.close();
        }
        //insert(add) book
        public void EditeBook(string title, string author, float price, string catagory, DateTime date, int rate, byte[] cover,int id)
        {
            SqlParameter[] pr = new SqlParameter[8];
            pr[0] = new SqlParameter("title", title);
            pr[1] = new SqlParameter("author", author);
            pr[2] = new SqlParameter("price", price);
            pr[3] = new SqlParameter("catagory", catagory);
            pr[4] = new SqlParameter("date", date);
            pr[5] = new SqlParameter("rate", rate);
            pr[6] = new SqlParameter("cover", cover);
            pr[7] = new SqlParameter("id", id);


            Dal.open();
            Dal.Excute("EditeBook", pr);
            Dal.close();
        }
    }
}
