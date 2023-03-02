using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Bank_App
{
    public partial class crtAcc : Form
    {
        List<string> nameArray = new List<string>();
        List<string> branchArray = new List<string>();
        List<string> acctypeArray = new List<string>();
        List<double> balanceArray = new List<double>();
        List<double> numberArray = new List<double>();

        public static string name, branch, acc_type; 
            public static double IniDeposite, pNumber;
        public crtAcc()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PNtextBox.Focus();

            name = NametextBox.Text ;
            branch = BranchcomboBox.Text ;
            acc_type = AccTypecomboBox.Text;
            IniDeposite = Convert.ToDouble(IniBalancetextBox.Text);
            pNumber = Convert.ToDouble(PNtextBox.Text);


            nameArray.Add(name);
            branchArray.Add(branch);
            acctypeArray.Add(acc_type);
            balanceArray.Add(IniDeposite);
            numberArray.Add(pNumber);

            MessageBox.Show("            Congratulations!\nAccount Created Successfully.");


            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Make Sure You Have A Stable Internet Connection");
            System.Diagnostics.Process.Start("https://storage.googleapis.com/simg-memechat/9B1E9MUaWnD8olMBJILmsJmCyl5SfZ2695876.jpg");
        }

        private void BranchcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void AccTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PNtextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void crtAcc_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = Color.Gray;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                button1.Enabled = true;
                button1.BackColor = Color.CornflowerBlue;
                button1.Cursor = Cursors.Hand;
            }
            else
            { 
                button1.Enabled = false;
                button1.BackColor = Color.Gray;
                button1.Cursor = Cursors.No;

            }

        }
    }
}
