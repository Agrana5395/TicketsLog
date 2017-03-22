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
    public partial class tSitesInventoryForm5 : Form
    {
        public string fo5
        {
            get { return tShowAllSitesInventoryTexBox.Text; }
            set { tShowAllSitesInventoryTexBox.Text = value; }

        }
        public tSitesInventoryForm5()
        {
            InitializeComponent();
        }

        private void tShowAllSitesInventoryTexBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tSitesInventoryForm5_Load(object sender, EventArgs e)
        {

        }

        private void tCloseSiteIdInventoryButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
