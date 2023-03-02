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
    public partial class infoForm : Form
    {
        public infoForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void infoForm_Load(object sender, EventArgs e)
        {
            Namelabel.Text = crtAcc.name;
            BranchLabel.Text = crtAcc.branch;
            label11.Text = crtAcc.acc_type;
            label8.Text = crtAcc.IniDeposite.ToString();
            label7.Text = crtAcc.pNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("              Warning!\n You Will Be Logged Out.");
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageMoneyForm form = new ManageMoneyForm();
            form.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("              Warning!\n You Will Be Logged Out.");
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
