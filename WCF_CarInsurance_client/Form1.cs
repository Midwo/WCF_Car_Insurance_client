using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCF_CarInsurance_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Basic m = new Basic();
            if (simpleinformation.error == 1)
            {

            }
            else
            {
                m.Show();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please write identity number in textbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                simpleinformation.identity = textBox1.Text;
                textBox1.Clear();
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                label7.Text = "Remember identity: " + simpleinformation.identity + "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Insurance m = new Insurance();
            if (simpleinformation.error == 1)
            {

            }
            else
            {
                m.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
                    
            Accidenst m = new Accidenst();
            if (simpleinformation.error == 1)
            {

            }
            else
            {
                m.Show();
            }
        }

        private void allAccidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accidenst m = new Accidenst();
            if (simpleinformation.error == 1)
            {

            }
            else
            {
                m.Show();
            }
        }

        private void allInsuranceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insurance m = new Insurance();
            if (simpleinformation.error == 1)
            {

            }
            else
            {
                m.Show();
            }

        }

        private void basicInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basic m = new Basic();
            if (simpleinformation.error == 1)
            {

            }
            else
            {
                m.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewInsurance m = new NewInsurance();
            m.Show();
        }

        private void newInsuranceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInsurance m = new NewInsurance();
            m.Show();
        }
    }
}

