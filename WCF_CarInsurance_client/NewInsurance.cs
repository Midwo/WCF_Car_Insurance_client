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
    public partial class NewInsurance : Form
    {
        WCF_CarInsurance_client.WCF_CarInsurance.Service1Client client = new WCF_CarInsurance_client.WCF_CarInsurance.Service1Client("BasicHttpBinding_IService1");

        public NewInsurance()
        {
            InitializeComponent();
            comboBox1.SelectedIndex =2;
            comboBox2.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WCF_CarInsurance_client.WCF_CarInsurance.PurchaseHistory request = new WCF_CarInsurance.PurchaseHistory();
                if (checkBox1.Checked)
                {
                    request.Active = true;
                                    }
                else
                {
                    request.Active = false;
                }


                request.Begindate = monthCalendar1.SelectionStart;
                request.Enddate = monthCalendar2.SelectionStart;
                request.Price = float.Parse(comboBox3.SelectedItem.ToString());
                request.Nameinsurer = comboBox2.SelectedItem.ToString();
                request.Descriptionpackage = comboBox1.SelectedItem.ToString();
                request.Descriptioncar = textBox1.Text;
                request.Vin = textBox3.Text;
                request.Savedate = DateTime.Now;
                request.Personal_identity_number = textBox2.Text;

                var hmm = client.SavePurchaseHistory(request);
                MessageBox.Show(hmm.Info.ToString(),"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                simpleinformation.identity = textBox2.Text;
                Form1.ActiveForm.Refresh();

            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
             
            }
            
        }
    }
}
