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
            Application.Exit();
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
            
            try 
            {
                BL.Book read = new BL.Book();
                DataTable dt = new DataTable();
                dt = read.ReadBooks();
                bookdata.DataSource = dt;
                bookdata.Columns[5].Visible= false;
                bookdata.Columns[6].Visible = false;
               // bookdata.Columns[7].Visible = false;
                bookdata.Columns[0].Visible = false;

                //set header columns title
                bookdata.Columns[0].HeaderText = "التسلسل";
                bookdata.Columns[1].HeaderText = "العنوان";
                bookdata.Columns[2].HeaderText = "المؤلف";
                bookdata.Columns[3].HeaderText = "السعر";
                bookdata.Columns[4].HeaderText = "الصنف";
                bookdata.Columns[7].HeaderText = "التقيم";

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "خطا",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
           
           
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
            try
            {
                book.state = Convert.ToInt32(bookdata.CurrentRow.Cells[0].Value);
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
                    cmd.Parameters.AddWithValue("@idImage", book.state);
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
            catch
            {
                MessageBox.Show("اختر كتاب اولا", "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           
         

        }

        //delete book
        private void DeleteB_Click(object sender, EventArgs e)
        {
            BL.Book delete = new BL.Book();
             delete.DeleteBook(Convert.ToInt32( bookdata.CurrentRow.Cells[0].Value));
            Form dDelet = new DialogDelete();
            dDelet.Show();
            cmd.Parameters.Clear();

        }

        //get book deteles
        private void detelesB_Click(object sender, EventArgs e)
        {
            
            try
            {
                Deteles book = new Deteles();

                //con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;
                //AttachDbFilename=F:\FCIH\code\C#\Book_Mangement\Book_Mangement\DbBook.mdf;
                //Integrated Security=True"
                //);
                //con.Open();
                //cmd.Connection = con;
                //cmd.CommandText = "select title,auther,price,catagory,date,rate from book where id=@id";
                //cmd.Parameters.AddWithValue("@id", bookdata.CurrentRow.Cells[0].Value);
                //var rd = cmd.ExecuteReader();
                //while (rd.Read())
                //{
                //    list.Add(Convert.ToString(rd[0]));
                //    list.Add(Convert.ToString(rd[1]));
                //    list.Add(Convert.ToString(rd[2]));
                //    list.Add(Convert.ToString(rd[3]));
                //    list.Add(Convert.ToString(rd[4]));
                //    list.Add(Convert.ToString(rd[5]));

                //}
                book.bName.Text =Convert.ToString(bookdata.CurrentRow.Cells[1].Value);
                book.bAuthor.Text = Convert.ToString(bookdata.CurrentRow.Cells[2].Value);
                book.bPrice.Text = Convert.ToString(bookdata.CurrentRow.Cells[3].Value);
                book.bCatagory.Text = Convert.ToString(bookdata.CurrentRow.Cells[4].Value);
                book.bDate.Value = Convert.ToDateTime(bookdata.CurrentRow.Cells[5].Value);
                book.bRate.Value = Convert.ToInt32(bookdata.CurrentRow.Cells[7].Value);
                //list.Clear();
                //con.Close();
                // read image from DB
                //con.Open();
                //cmd.CommandText = "select cover from book where id=@idImage";
                //cmd.Parameters.AddWithValue("@idImage", bookdata.CurrentRow.Cells[0].Value);
                byte[] img = (byte[])bookdata.CurrentRow.Cells[6].Value;
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                book.bCover.Image = Image.FromStream(ma);
                bunifuTransition1.ShowSync(book);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("اختر كتاب اولا", "خطا",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
           
        }

        private void Search_OnTextChange(object sender, EventArgs e)
        {
            BL.Book book = new BL.Book();
            DataTable dt = new DataTable();
            dt = book.Search(search.text);
            bookdata.DataSource = dt;
            bookdata.Columns[5].Visible = false;
            bookdata.Columns[6].Visible = false;
            // bookdata.Columns[7].Visible = false;
            bookdata.Columns[0].Visible = false;

            //set header columns title
            bookdata.Columns[0].HeaderText = "التسلسل";
            bookdata.Columns[1].HeaderText = "العنوان";
            bookdata.Columns[2].HeaderText = "المؤلف";
            bookdata.Columns[3].HeaderText = "السعر";
            bookdata.Columns[4].HeaderText = "الصنف";
            bookdata.Columns[7].HeaderText = "التقيم";
        }
    }
}
