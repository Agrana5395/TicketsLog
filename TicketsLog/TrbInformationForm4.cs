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
    public partial class tTrbInformationForm4 : Form
    {
        tTrbInventoryForm6 f6 = new tTrbInventoryForm6();
        public string fo4
        {
            get { return tShowTrbInformationTextBox.Text; }
            set { tShowTrbInformationTextBox.Text = value; }

        }
        public tTrbInformationForm4()
        {
            InitializeComponent();
        }

        private void tShowAllTrbIdButton_Click(object sender, EventArgs e)
        {
            var allTrbId = File.ReadAllText(@"..\..\Resources\TrbNumber.txt");
            f6.fo6 = allTrbId;
            f6.Show();
        }

        private void tTrbInformationForm4_Load(object sender, EventArgs e)
        {

        }

        private void tCloseTrbButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
