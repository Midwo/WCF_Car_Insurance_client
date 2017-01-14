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
    }
}
