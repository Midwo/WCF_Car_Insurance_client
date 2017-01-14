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
    public partial class NewAccount : Form
    {

        WCF_CarInsurance_client.WCF_CarInsurance.Service1Client client = new WCF_CarInsurance_client.WCF_CarInsurance.Service1Client();
        public NewAccount()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            WCF_CarInsurance_client.WCF_CarInsurance.BasicInformation request = new WCF_CarInsurance.BasicInformation();

            try
            {

                request.Name_surname = textBox1.Text;
                request.Personal_identity_number = textBox2.Text;
                request.Identity_card_number = textBox4.Text;
                request.Address = textBox3.Text;
                request.Discounts = float.Parse(comboBox1.SelectedItem.ToString());
                request.Phone_number = textBox5.Text;
                request.Birthday = monthCalendar1.SelectionStart;

               var response = client.SaveBasicInformation(request);
               
                MessageBox.Show(response.Info, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
