namespace TicketsLog
{
    partial class tTrbInformationForm4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tTrbInformationForm4));
            this.tTrbInformationLabel = new System.Windows.Forms.Label();
            this.tShowTrbInformationTextBox = new System.Windows.Forms.TextBox();
            this.tShowAllTrbIdButton = new System.Windows.Forms.Button();
            this.tCloseTrbButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tTrbInformationLabel
            // 
            this.tTrbInformationLabel.AutoSize = true;
            this.tTrbInformationLabel.Location = new System.Drawing.Point(53, 9);
            this.tTrbInformationLabel.Name = "tTrbInformationLabel";
            this.tTrbInformationLabel.Size = new System.Drawing.Size(150, 13);
            this.tTrbInformationLabel.TabIndex = 1;
            this.tTrbInformationLabel.Text = "This is your TRB# Information ";
            // 
            // tShowTrbInformationTextBox
            // 
            this.tShowTrbInformationTextBox.Location = new System.Drawing.Point(12, 25);
            this.tShowTrbInformationTextBox.Multiline = true;
            this.tShowTrbInformationTextBox.Name = "tShowTrbInformationTextBox";
            this.tShowTrbInformationTextBox.Size = new System.Drawing.Size(260, 109);
            this.tShowTrbInformationTextBox.TabIndex = 3;
            // 
            // tShowAllTrbIdButton
            // 
            this.tShowAllTrbIdButton.Location = new System.Drawing.Point(93, 140);
            this.tShowAllTrbIdButton.Name = "tShowAllTrbIdButton";
            this.tShowAllTrbIdButton.Size = new System.Drawing.Size(75, 23);
            this.tShowAllTrbIdButton.TabIndex = 4;
            this.tShowAllTrbIdButton.Text = "Show All ";
            this.tShowAllTrbIdButton.UseVisualStyleBackColor = true;
            this.tShowAllTrbIdButton.Click += new System.EventHandler(this.tShowAllTrbIdButton_Click);
            // 
            // tCloseTrbButtom
            // 
            this.tCloseTrbButtom.Location = new System.Drawing.Point(106, 169);
            this.tCloseTrbButtom.Name = "tCloseTrbButtom";
            this.tCloseTrbButtom.Size = new System.Drawing.Size(44, 23);
            this.tCloseTrbButtom.TabIndex = 5;
            this.tCloseTrbButtom.Text = "Close";
            this.tCloseTrbButtom.UseVisualStyleBackColor = true;
            this.tCloseTrbButtom.Click += new System.EventHandler(this.tCloseTrbButtom_Click);
            // 
            // tTrbInformationForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.ControlBox = false;
            this.Controls.Add(this.tCloseTrbButtom);
            this.Controls.Add(this.tShowAllTrbIdButton);
            this.Controls.Add(this.tShowTrbInformationTextBox);
            this.Controls.Add(this.tTrbInformationLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tTrbInformationForm4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TRB# Information";
            this.Load += new System.EventHandler(this.tTrbInformationForm4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tTrbInformationLabel;
        private System.Windows.Forms.TextBox tShowTrbInformationTextBox;
        private System.Windows.Forms.Button tShowAllTrbIdButton;
        private System.Windows.Forms.Button tCloseTrbButtom;
    }
}