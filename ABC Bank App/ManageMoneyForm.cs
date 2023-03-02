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
    public partial class ManageMoneyForm : Form
    {
        public static double depositMoney,withdrawMoney;
        public ManageMoneyForm()
        {
            InitializeComponent();
        }

        private void ManageMoneyForm_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.BackColor = Color.Gray;
            button4.Enabled = false;
            button4.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("              Warning!\n You Will Be Logged Out.");
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            infoForm form = new infoForm();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text==" ")
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (textBox1.Text=="")
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            else if (textBox1.Text == "0")
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            else
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button3.BackColor = Color.CornflowerBlue;
                button4.BackColor = Color.CornflowerBlue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            withdrawMoney = Convert.ToDouble(textBox1.Text);

            if(withdrawMoney<= crtAcc.IniDeposite)
            {
                crtAcc.IniDeposite = (crtAcc.IniDeposite) - withdrawMoney;
                MessageBox.Show("Withdraw Successful!");
            }
            else
            {
                MessageBox.Show("Insufficient Balance!");
            }

            
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            infoForm form = new infoForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            depositMoney = Convert.ToDouble(textBox1.Text);
            crtAcc.IniDeposite = depositMoney+(crtAcc.IniDeposite);
            MessageBox.Show("       I Appreciate Your Sacrifice!");
            textBox1.Clear();
            textBox1.Focus();
            
        }
    }
}
