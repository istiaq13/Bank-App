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
    public partial class Form1 : Form
    {
        List<string> nameArray = new List<string>();
        List<string> branchArray = new List<string>();
        List<string> acctypeArray = new List<string>();
        List<double> balanceArray = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            crtAcc form= new crtAcc();
            form.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Connecting To The Developer.......");
            System.Diagnostics.Process.Start("https://www.facebook.com/istiaq.prodhan.16");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void betaLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            betaLabel.Location = new Point (betaLabel.Location.X+3, betaLabel.Location.Y);
            if(betaLabel.Location .X > this .Width) 
            {
              betaLabel.Location = new Point(0 - betaLabel.Width, - betaLabel.Location.Y);
                for(int i =0; i < betaLabel.Height; i++) 
                {
                    betaLabel.Location = new Point(0 - betaLabel.Width, -betaLabel.Location.Y);
                }
            }
        }
    }
}
