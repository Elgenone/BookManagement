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
    public partial class addBook : Form
    {
        // var for SqlCon
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<string> list = new List<string>();

        public int state;
        public addBook()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form cat = new catagory();
            bunifuTransition1.ShowSync(cat);
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
           
        }

        //get catagories from table cat and but it in bCatagory combo
        private void AddBook_Activated(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=F:\FCIH\code\C#\Book_Mangement\Book_Mangement\DbBook.mdf;
                Integrated Security=True"
                );
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select catagory from cat";
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(Convert.ToString(rd[0]));
                }
                for (int i = 0; i < list.LongCount(); i++)
                {
                    bcatagoy.Items.Add(list[i]);
                }

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
        }

        //add the info of the book in table book
        private void Add_Click(object sender, EventArgs e)
        {
            if (bName.Text != "" && bAuthor.Text != "" && bPrice.Text != "" && bcatagoy.Text != "")
            {
                if (state == 0)
                {
                    //Add new book
                    //save image as binary in memory
                    MemoryStream ms = new MemoryStream();
                    bCover.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _bCover = ms.ToArray();

                    //sql command
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=F:\FCIH\code\C#\Book_Mangement\Book_Mangement\DbBook.mdf;
                Integrated Security=True"
                    );
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into book (title,auther,price,catagory,date,rate,cover) " +
                        "values (@ti,@au,@pr,@cat,@da,@ra,@co)";
                    cmd.Parameters.AddWithValue("@ti", bName.Text);
                    cmd.Parameters.AddWithValue("@au", bAuthor.Text);
                    cmd.Parameters.AddWithValue("@pr", int.Parse(bPrice.Text));
                    cmd.Parameters.AddWithValue("@cat", bcatagoy.Text);
                    cmd.Parameters.AddWithValue("@da", bDate.Value);
                    cmd.Parameters.AddWithValue("@ra", bRate.Value);
                    cmd.Parameters.AddWithValue("@co", _bCover);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    Form dAdd = new DialogAdd();
                    dAdd.Show();
                    Close();
                }
                else
                {
                    // Edite book
                    //save image as binary in memory
                    MemoryStream ms = new MemoryStream();
                    bCover.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _bCover = ms.ToArray();

                    //sql command
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;
                                            AttachDbFilename=F:\FCIH\code\C#\Book_Mangement\Book_Mangement\DbBook.mdf;
                                            Integrated Security=True"
                                                );
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update  book set title = @ti,auther = @au,price = @pr,catagory = @cat,date = @da,rate = @ra,cover = @co where id=@id ";
                    cmd.Parameters.AddWithValue("@ti", bName.Text);
                    cmd.Parameters.AddWithValue("@au", bAuthor.Text);
                    cmd.Parameters.AddWithValue("@pr", int.Parse(bPrice.Text));
                    cmd.Parameters.AddWithValue("@cat", bcatagoy.Text);
                    cmd.Parameters.AddWithValue("@da", bDate.Value);
                    cmd.Parameters.AddWithValue("@ra", bRate.Value);
                    cmd.Parameters.AddWithValue("@co", _bCover);
                    cmd.Parameters.AddWithValue("@id", state);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.Parameters.Clear();

                    Form dEdite = new DialogEdit();
                    dEdite.Show();
                    Close();

                }

            }
            else
            {
                MessageBox.Show("ادخل بيانات الكتاب اولا", "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void AddPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open dialog to chose the image if click ok button 
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if(result == DialogResult.OK)
            {
                bCover.Image = Image.FromFile(dia.FileName);
            }
        }
    }
}
