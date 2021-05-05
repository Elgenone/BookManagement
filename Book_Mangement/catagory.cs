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


namespace Book_Mangement
{
    public partial class catagory : Form
    {
        // var for SqlCon
        SqlConnection con = new SqlConnection();
        SqlCommand cmd= new SqlCommand();
        public catagory()
        {
            InitializeComponent();
        }

        private void EitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (cat.Text != "")
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=|DataDirectory|\DbBook.mdf;
                Integrated Security=True"
                );
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into cat (catagory) values (@cat)";
                cmd.Parameters.AddWithValue("@cat", cat.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                Form dAdd = new DialogAdd();
                dAdd.Show();
                Close();
            }
            else
            {
                MessageBox.Show("ادخل الصنف اولا", "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           
        }
    }
}
