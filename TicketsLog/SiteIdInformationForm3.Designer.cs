namespace TicketsLog
{
    partial class tSiteIdInformationForm3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tSiteIdInformationForm3));
            this.tShowAllSiteIdButton = new System.Windows.Forms.Button();
            this.tSiteIdInformationLable = new System.Windows.Forms.Label();
            this.tShowSiteIdTextBox = new System.Windows.Forms.TextBox();
            this.tCloseSiteIdButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tShowAllSiteIdButton
            // 
            this.tShowAllSiteIdButton.Location = new System.Drawing.Point(93, 136);
            this.tShowAllSiteIdButton.Name = "tShowAllSiteIdButton";
            this.tShowAllSiteIdButton.Size = new System.Drawing.Size(75, 23);
            this.tShowAllSiteIdButton.TabIndex = 0;
            this.tShowAllSiteIdButton.Text = "Show All";
            this.tShowAllSiteIdButton.UseVisualStyleBackColor = true;
            this.tShowAllSiteIdButton.Click += new System.EventHandler(this.tShowAllSiteIdButton_Click);
            // 
            // tSiteIdInformationLable
            // 
            this.tSiteIdInformationLable.AutoSize = true;
            this.tSiteIdInformationLable.Location = new System.Drawing.Point(59, 9);
            this.tSiteIdInformationLable.Name = "tSiteIdInformationLable";
            this.tSiteIdInformationLable.Size = new System.Drawing.Size(152, 13);
            this.tSiteIdInformationLable.TabIndex = 1;
            this.tSiteIdInformationLable.Text = "This is your Site ID information ";
            // 
            // tShowSiteIdTextBox
            // 
            this.tShowSiteIdTextBox.Location = new System.Drawing.Point(12, 25);
            this.tShowSiteIdTextBox.Multiline = true;
            this.tShowSiteIdTextBox.Name = "tShowSiteIdTextBox";
            this.tShowSiteIdTextBox.Size = new System.Drawing.Size(260, 105);
            this.tShowSiteIdTextBox.TabIndex = 2;
            // 
            // tCloseSiteIdButtom
            // 
            this.tCloseSiteIdButtom.Location = new System.Drawing.Point(109, 165);
            this.tCloseSiteIdButtom.Name = "tCloseSiteIdButtom";
            this.tCloseSiteIdButtom.Size = new System.Drawing.Size(44, 23);
            this.tCloseSiteIdButtom.TabIndex = 6;
            this.tCloseSiteIdButtom.Text = "Close";
            this.tCloseSiteIdButtom.UseVisualStyleBackColor = true;
            this.tCloseSiteIdButtom.Click += new System.EventHandler(this.tCloseSiteIdButtom_Click_1);
            // 
            // tSiteIdInformationForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.ControlBox = false;
            this.Controls.Add(this.tCloseSiteIdButtom);
            this.Controls.Add(this.tShowSiteIdTextBox);
            this.Controls.Add(this.tSiteIdInformationLable);
            this.Controls.Add(this.tShowAllSiteIdButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tSiteIdInformationForm3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Site Information";
            this.Load += new System.EventHandler(this.tSiteIdInformationForm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tShowAllSiteIdButton;
        private System.Windows.Forms.Label tSiteIdInformationLable;
        private System.Windows.Forms.TextBox tShowSiteIdTextBox;
        private System.Windows.Forms.Button tCloseSiteIdButtom;
    }
}