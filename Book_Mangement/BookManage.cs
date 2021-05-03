using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Book_Mangement
{
    public partial class BookManage : Form
    {
        // var for move form without bar
        bool move;
        int movez;
        int movey;
        // var for SqlCon
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<string> list = new List<string>();

        public BookManage()
        {
            InitializeComponent();
        }

        //header buttons
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BigScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            
        }

        private void SmallScreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // move form from the header

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            movez = e.X;
            movey = e.Y;
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - movez, MousePosition.Y - movey);
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        // show data from table book
        private void BookManage_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            con.ConnectionString =( @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=F:\FCIH\code\C#\Book_Mangement\Book_Mangement\DbBook.mdf;
            Integrated Security=True"
            );
            var sql = "SELECT ID ,title as العنوان,Auther as المؤلف,price as السعر,catagory FROM Book";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            bookdata.DataSource = dt;
            //set header columns title
            bookdata.Columns[0].HeaderText = "التسلسل";
            bookdata.Columns[1].HeaderText = "العنوان";
            bookdata.Columns[2].HeaderText = "المؤلف";
            bookdata.Columns[3].HeaderText = "السعر";
            bookdata.Columns[4].HeaderText = "الصنف";
           
        }

        //add book
        private void addB_Click(object sender, EventArgs e)
        {
            addBook book = new addBook();
           // book.MdiParent = this;
            book.add.ButtonText = "اضافه الكتاب";
            book.state = 0;
            //book.Show();
            bunifuTransition1.ShowSync(book);
        }

        //edite the book
        private void EditeB_Click(object sender, EventArgs e)
        {
            addBook book = new addBook();
            book.add.ButtonText = "تعديل الكتاب";
            book.state = Convert.ToInt32( bookdata.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(book);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=F:\FCIH\code\C#\Book_Mangement\Book_Mangement\DbBook.mdf;
                Integrated Security=True"
                );
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select title,auther,price,catagory,date,rate from book where id=@id";
                cmd.Parameters.AddWithValue("@id", book.state);
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(Convert.ToString(rd[0]));
                    list.Add(Convert.ToString(rd[1]));
                    list.Add(Convert.ToString(rd[2]));
                    list.Add(Convert.ToString(rd[3]));
                    list.Add(Convert.ToString(rd[4]));
                    list.Add(Convert.ToString(rd[5]));

                }
                book.bName.Text = list[0];
                book.bAuthor.Text = list[1];
                book.bPrice.Text = list[2];
                book.bcatagoy.Text = list[3];
                book.bDate.Value = Convert.ToDateTime(list[4]);
                book.bRate.Value = Convert.ToInt32(list[5]);
                list.Clear();
                con.Close();
                // read image from DB
                con.Open();
                cmd.CommandText = "select cover from book where id=@idImage";
                cmd.Parameters.AddWithValue("@idImage",book.state);
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img,0,img.Length);
                book.bCover.Image = Image.FromStream(ma);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();

        }

        //delete book
        private void DeleteB_Click(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=F:\FCIH\code\C#\Book_Mangement\Book_Mangement\DbBook.mdf;
                Integrated Security=True"
                );
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "delete from book where id=@id";
            cmd.Parameters.AddWithValue("@id", bookdata.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            Form dDelet = new DialogDelete();
            dDelet.Show();
            cmd.Parameters.Clear();

        }

        //get book deteles
        private void detelesB_Click(object sender, EventArgs e)
        {
            Deteles book = new Deteles();
            bunifuTransition1.ShowSync(book);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=F:\FCIH\code\C#\Book_Mangement\Book_Mangement\DbBook.mdf;
                Integrated Security=True"
                );
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select title,auther,price,catagory,date,rate from book where id=@id";
                cmd.CommandText = "select title,auther,price,catagory,date,rate from book where id=@id1";
                cmd.Parameters.AddWithValue("@id", bookdata.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@id1", bookdata.CurrentRow.Cells[0].Value);
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(Convert.ToString(rd[0]));
                    list.Add(Convert.ToString(rd[1]));
                    list.Add(Convert.ToString(rd[2]));
                    list.Add(Convert.ToString(rd[3]));
                    list.Add(Convert.ToString(rd[4]));
                    list.Add(Convert.ToString(rd[5]));

                }
                book.bName.Text = list[0];
                book.bAuthor.Text = list[1];
                book.bPrice.Text = list[2];
                book.bCatagory.Text = list[3];
                book.bDate.Value = Convert.ToDateTime(list[4]);
                book.bRate.Value = Convert.ToInt32(list[5]);
                list.Clear();
                con.Close();
                // read image from DB
                con.Open();
                cmd.CommandText = "select cover from book where id=@idImage";
                cmd.Parameters.AddWithValue("@idImage", bookdata.CurrentRow.Cells[0].Value);
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                book.bCover.Image = Image.FromStream(ma);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }
    }
}
