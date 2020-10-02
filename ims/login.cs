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
namespace ims
{
    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Parvathi-PC\source\destop\chinni\ims\inventory.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from registration where username='"+textBox1.Text+"' and password ='"+textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count.ToString() == "1")
            {
                this.Hide();

                MDIParent1 mdi = new MDIParent1();
                mdi.Show();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
