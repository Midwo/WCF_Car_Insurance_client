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
        public Basic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WCF_CarInsurance_client.WCF_CarInsurance.Service1Client client = new WCF_CarInsurance_client.WCF_CarInsurance.Service1Client("BasicHttpBinding_IService1");

            DataSet dsread = client.ReadBasicInformation(catchuser.identity);
            try
            {
                label1.Text = dsread.Tables[0].Rows[0][0].ToString();
                label2.Text = dsread.Tables[0].Rows[0][1].ToString();
                label3.Text = dsread.Tables[0].Rows[0][2].ToString();
                label4.Text = dsread.Tables[0].Rows[0][3].ToString();
                label5.Text = dsread.Tables[0].Rows[0][4].ToString();
                label6.Text = dsread.Tables[0].Rows[0][5].ToString();
                label7.Text = dsread.Tables[0].Rows[0][6].ToString();
                label8.Text = dsread.Tables[0].Rows[0][7].ToString();
            }
            catch
            {
                MessageBox.Show("nie ma takiego klienta");
            }
        }
    }
}
