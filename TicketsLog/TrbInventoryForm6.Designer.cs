namespace TicketsLog
{
    partial class tTrbInventoryForm6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tTrbInventoryForm6));
            this.tShowAllTrbInventoryTexBox = new System.Windows.Forms.TextBox();
            this.tAllTrbLabel = new System.Windows.Forms.Label();
            this.tCloseTrbInventoryButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tShowAllTrbInventoryTexBox
            // 
            this.tShowAllTrbInventoryTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tShowAllTrbInventoryTexBox.Location = new System.Drawing.Point(12, 25);
            this.tShowAllTrbInventoryTexBox.Multiline = true;
            this.tShowAllTrbInventoryTexBox.Name = "tShowAllTrbInventoryTexBox";
            this.tShowAllTrbInventoryTexBox.Size = new System.Drawing.Size(390, 566);
            this.tShowAllTrbInventoryTexBox.TabIndex = 2;
            this.tShowAllTrbInventoryTexBox.TextChanged += new System.EventHandler(this.tShowAllTrbInventoryTexBox_TextChanged);
            // 
            // tAllTrbLabel
            // 
            this.tAllTrbLabel.AutoSize = true;
            this.tAllTrbLabel.Location = new System.Drawing.Point(158, 9);
            this.tAllTrbLabel.Name = "tAllTrbLabel";
            this.tAllTrbLabel.Size = new System.Drawing.Size(71, 13);
            this.tAllTrbLabel.TabIndex = 3;
            this.tAllTrbLabel.Text = "All your TRBs";
            // 
            // tCloseTrbInventoryButtom
            // 
            this.tCloseTrbInventoryButtom.Location = new System.Drawing.Point(161, 597);
            this.tCloseTrbInventoryButtom.Name = "tCloseTrbInventoryButtom";
            this.tCloseTrbInventoryButtom.Size = new System.Drawing.Size(44, 23);
            this.tCloseTrbInventoryButtom.TabIndex = 4;
            this.tCloseTrbInventoryButtom.Text = "Close";
            this.tCloseTrbInventoryButtom.UseVisualStyleBackColor = true;
            this.tCloseTrbInventoryButtom.Click += new System.EventHandler(this.tCloseTrbInventoryButtom_Click);
            // 
            // tTrbInventoryForm6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 644);
            this.ControlBox = false;
            this.Controls.Add(this.tCloseTrbInventoryButtom);
            this.Controls.Add(this.tAllTrbLabel);
            this.Controls.Add(this.tShowAllTrbInventoryTexBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tTrbInventoryForm6";
            this.Text = "TRB Inventory ";
            this.Load += new System.EventHandler(this.tTrbInventoryForm6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tShowAllTrbInventoryTexBox;
        private System.Windows.Forms.Label tAllTrbLabel;
        private System.Windows.Forms.Button tCloseTrbInventoryButtom;
    }
}