namespace TicketsLog
{
    partial class tSitesInventoryForm5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tSitesInventoryForm5));
            this.tAllSitesLabel1 = new System.Windows.Forms.Label();
            this.tShowAllSitesInventoryTexBox = new System.Windows.Forms.TextBox();
            this.tCloseSiteIdInventoryButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tAllSitesLabel1
            // 
            this.tAllSitesLabel1.AutoSize = true;
            this.tAllSitesLabel1.Location = new System.Drawing.Point(168, 9);
            this.tAllSitesLabel1.Name = "tAllSitesLabel1";
            this.tAllSitesLabel1.Size = new System.Drawing.Size(72, 13);
            this.tAllSitesLabel1.TabIndex = 0;
            this.tAllSitesLabel1.Text = "All Your Sites ";
            // 
            // tShowAllSitesInventoryTexBox
            // 
            this.tShowAllSitesInventoryTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tShowAllSitesInventoryTexBox.Location = new System.Drawing.Point(12, 25);
            this.tShowAllSitesInventoryTexBox.Multiline = true;
            this.tShowAllSitesInventoryTexBox.Name = "tShowAllSitesInventoryTexBox";
            this.tShowAllSitesInventoryTexBox.Size = new System.Drawing.Size(390, 574);
            this.tShowAllSitesInventoryTexBox.TabIndex = 1;
            this.tShowAllSitesInventoryTexBox.TextChanged += new System.EventHandler(this.tShowAllSitesInventoryTexBox_TextChanged);
            // 
            // tCloseSiteIdInventoryButtom
            // 
            this.tCloseSiteIdInventoryButtom.Location = new System.Drawing.Point(162, 605);
            this.tCloseSiteIdInventoryButtom.Name = "tCloseSiteIdInventoryButtom";
            this.tCloseSiteIdInventoryButtom.Size = new System.Drawing.Size(44, 23);
            this.tCloseSiteIdInventoryButtom.TabIndex = 4;
            this.tCloseSiteIdInventoryButtom.Text = "Close";
            this.tCloseSiteIdInventoryButtom.UseVisualStyleBackColor = true;
            this.tCloseSiteIdInventoryButtom.Click += new System.EventHandler(this.tCloseSiteIdInventoryButtom_Click);
            // 
            // tSitesInventoryForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 644);
            this.ControlBox = false;
            this.Controls.Add(this.tCloseSiteIdInventoryButtom);
            this.Controls.Add(this.tShowAllSitesInventoryTexBox);
            this.Controls.Add(this.tAllSitesLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tSitesInventoryForm5";
            this.Text = "Sites ID Inventory ";
            this.Load += new System.EventHandler(this.tSitesInventoryForm5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tAllSitesLabel1;
        private System.Windows.Forms.TextBox tShowAllSitesInventoryTexBox;
        private System.Windows.Forms.Button tCloseSiteIdInventoryButtom;
    }
}