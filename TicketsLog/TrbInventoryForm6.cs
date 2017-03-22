using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
    public partial class tTrbInventoryForm6 : Form
    {
        public string fo6
        {
            get { return tShowAllTrbInventoryTexBox.Text; }
            set { tShowAllTrbInventoryTexBox.Text = value; }
        }

        public tTrbInventoryForm6()
        {
            InitializeComponent();
        }

        private void tTrbInventoryForm6_Load(object sender, EventArgs e)
        {

        }

        private void tShowAllTrbInventoryTexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCloseTrbInventoryButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
