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
    public partial class tDataProcessor : Form
    {
        tSiteIdInformationForm3 f3 = new tSiteIdInformationForm3();
        tTrbInformationForm4 f4 = new tTrbInformationForm4();

        public tDataProcessor()
        {
            InitializeComponent();
        }

       

        private void tSaveSiteIdButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"..\..\Resources\SiteID.txt", true);
            string[] id = tSiteIdTextBox.Lines.ToArray();
            for (int t = 0; t < id.Length; t++)
            {
                sw.WriteLine(id[t]);
            }
            sw.Close();
        }

        private void tSearchSiteIdButton_Click(object sender, EventArgs e)
        {
            var path = @"..\..\Resources\SiteID.txt";
            string toSearch = tSiteIdTextBox.Text;
            using (StreamReader sr = new StreamReader(path))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == toSearch)
                    {


                        f3.fo3 = tSiteIdTextBox.Text;
                        f3.Show();
                       
                    }

                
                    
                } 
            }
            
        }

        

     

        private void tSearchTrbButton_Click(object sender, EventArgs e)
        {
         string toSearch = tEnterTrbTextBox.Text;
            string path = @"..\..\Resources\TrbNumber.txt";
            using (StreamReader sr1 = new StreamReader(path))
            {
                String line;
              while ((line = sr1.ReadLine()) != null)
                {
                    if (line == toSearch)
                    {
                        f4.fo4 = tEnterTrbTextBox.Text;
                        f4.Show();
                       
                    }
              
                }
            }
            
        }
        private void tSaveTrbButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"..\..\Resources\TrbNumber.txt", true);
            string[] trb = tEnterTrbTextBox.Lines.ToArray();
            for (int t = 0; t < trb.Length; t++)
            {
                sw.WriteLine(trb[t]);
            }
            sw.Close();
        }

        private void tDataProcessor_Load(object sender, EventArgs e)
        {
        
        }

        private void tSiteIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tClearButtom_Click(object sender, EventArgs e)
        {
            tSiteIdTextBox.Clear();
            tEnterTrbTextBox.Clear();
        }

        private void tEnterTrbTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tCloseButton_Click(object sender, EventArgs e)
        {

            DialogResult resoult2 = MessageBox.Show("If you close the program all data will be lost" + 
                " Are you sure you want to close!", "WARNING!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resoult2 == DialogResult.OK)
            {
                DialogResult resoult1 = MessageBox.Show("Are you really sure about what  you are doing!", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resoult1 == DialogResult.Yes)
                {

                    Application.Exit();
                }
            }

                  
        }
    }
}
