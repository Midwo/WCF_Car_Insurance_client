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
    public partial class New_Accidents : Form
    {

        WCF_CarInsurance_client.WCF_CarInsurance.Service1Client client = new WCF_CarInsurance.Service1Client();
        public New_Accidents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WCF_CarInsurance_client.WCF_CarInsurance.HistoryOfAccidents request = new WCF_CarInsurance.HistoryOfAccidents();
            try
            {
                request.CarName = textBox1.Text;
                request.PersonalIdentityNumber = textBox2.Text;
                request.Vin = textBox4.Text;
                request.Penalty = float.Parse(textBox3.Text);
                request.DescriptionOfTheDamage = textBox6.Text;
                request.Date = monthCalendar1.SelectionStart;

                var response = client.SaveAccidents(request);

                MessageBox.Show(response.Info, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
