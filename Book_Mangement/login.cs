using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Mangement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User login = new User();
            DataTable dt = new DataTable();
            dt = login.dt(name.Text, pass.Text);
            if (dt.Rows.Count > 0)
            {
                BookManage bm = new BookManage();
                bm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ادخل الاسم و كلمه السر الصحيحه", "خطا فى التسجيل",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //AcceptButton =(System.Windows.Forms.IButtonControl) btnLogin;
        }
    }
}
