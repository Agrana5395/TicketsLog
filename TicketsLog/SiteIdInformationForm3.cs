using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


/**********************************************************************
 Name:               Alfredo Granado 
 Date:               06/06/2015
 Constributions:     MSDN
 Tacher:             Scott 
 School:             Sullivan 
 Project Name:       Tickets Logs 
 
 *********************************************************************/

namespace TicketsLog
{
    public partial class tSiteIdInformationForm3 : Form
        

    {
        tSitesInventoryForm5 f5 = new tSitesInventoryForm5();
        public string fo3
        {
            get { return tShowSiteIdTextBox.Text; }
            set { tShowSiteIdTextBox.Text = value;  }

        }
        public tSiteIdInformationForm3()
        {
            InitializeComponent();
        }

        private void tSiteIdInformationForm3_Load(object sender, EventArgs e)
        {
            
        }

        private void tShowAllSiteIdButton_Click(object sender, EventArgs e)
        {
            var allSiteId = File.ReadAllText(@"..\..\Resources\SiteID.txt");
            f5.Show();
            f5.fo5 = allSiteId;
           
        }

       
        private void tCloseSiteIdButtom_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
