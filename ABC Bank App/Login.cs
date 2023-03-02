using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ABC_Bank_App
{
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection abc = new SqlConnection(cs);
           // string query = " select * from login_tbl where username = @user and ";



           /*if(crtAcc.pNumber==(Convert.ToInt32(textBox1.Text)))
            {
                this.Hide();
                infoForm abc = new infoForm();
                abc.Show();
            }
           else
            {
                MessageBox.Show("Not Found");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            crtAcc form= new crtAcc();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
