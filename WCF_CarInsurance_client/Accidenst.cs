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
    public partial class Accidenst : Form
    {
        WCF_CarInsurance_client.WCF_CarInsurance.Service1Client client = new WCF_CarInsurance_client.WCF_CarInsurance.Service1Client("BasicHttpBinding_IService1");

        public Accidenst()
        {
            InitializeComponent();


            DataSet dsread = client.ReadHistoryOfAccidents(simpleinformation.identity);
            try
            {
                simpleinformation.ID = dsread.Tables[0].Rows[0][0].ToString();
                dataGridView1.DataSource = dsread.Tables[0];
                simpleinformation.error = 0;
            }
            catch
            {
                MessageBox.Show("Not found this client", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                simpleinformation.error = 1;
            }
        }
    }
}
