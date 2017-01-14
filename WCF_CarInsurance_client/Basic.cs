using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_CarInsurance_client.WCF_CarInsurance;

namespace WCF_CarInsurance_client
{
    public partial class Basic : Form
    {
        WCF_CarInsurance_client.WCF_CarInsurance.Service1Client client = new WCF_CarInsurance_client.WCF_CarInsurance.Service1Client("BasicHttpBinding_IService1");
        public Basic()
        {
            InitializeComponent();
           

            DataSet dsread = client.ReadBasicInformation(simpleinformation.identity);
            try
            {
                simpleinformation.ID = dsread.Tables[0].Rows[0][0].ToString();
                textBox1.Text = dsread.Tables[0].Rows[0][1].ToString();
                textBox2.Text = dsread.Tables[0].Rows[0][2].ToString();
                textBox3.Text = dsread.Tables[0].Rows[0][3].ToString();
                textBox4.Text = dsread.Tables[0].Rows[0][4].ToString();
                textBox5.Text = dsread.Tables[0].Rows[0][5].ToString();
                textBox6.Text = dsread.Tables[0].Rows[0][6].ToString();
                DateTime x = Convert.ToDateTime(dsread.Tables[0].Rows[0][7].ToString());
                textBox7.Text = x.ToShortDateString();
                simpleinformation.error = 0;
            }
            catch
            {
                MessageBox.Show("Not found this client", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                simpleinformation.error = 1;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void Basic_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            try
            {
                MessageBox.Show(client.UpdateBasicInformation(Convert.ToInt32(simpleinformation.ID), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, float.Parse(textBox5.Text), textBox6.Text, DateTime.Parse(textBox7.Text)), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
