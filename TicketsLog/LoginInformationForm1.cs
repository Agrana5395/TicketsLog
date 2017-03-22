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
    public partial class tLoginForm1 : Form
    {
        
        public tLoginForm1()
        {
            InitializeComponent();
        }

        private void tEnterButtom_Click(object sender, EventArgs e)
        {
            if ( (tUserNameTextBox.Text == "Teacher") & (tPasswordTextBox.Text == "Password"))
            {
                
                tDataProcessor fData = new tDataProcessor();
                this.Show();
                fData.ShowDialog();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password");
            }
        }

        private void tLoginForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
