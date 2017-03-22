namespace TicketsLog
{
    partial class tLoginForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tLoginForm1));
            this.tEnterButtom = new System.Windows.Forms.Button();
            this.tUserNameTextBox = new System.Windows.Forms.TextBox();
            this.tPasswordTextBox = new System.Windows.Forms.TextBox();
            this.TPictureBox1 = new System.Windows.Forms.PictureBox();
            this.tUserLabel = new System.Windows.Forms.Label();
            this.tPasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tEnterButtom
            // 
            this.tEnterButtom.Location = new System.Drawing.Point(244, 140);
            this.tEnterButtom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tEnterButtom.Name = "tEnterButtom";
            this.tEnterButtom.Size = new System.Drawing.Size(88, 29);
            this.tEnterButtom.TabIndex = 0;
            this.tEnterButtom.Text = "Enter!";
            this.tEnterButtom.UseVisualStyleBackColor = true;
            this.tEnterButtom.Click += new System.EventHandler(this.tEnterButtom_Click);
            // 
            // tUserNameTextBox
            // 
            this.tUserNameTextBox.Location = new System.Drawing.Point(5, 73);
            this.tUserNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tUserNameTextBox.Name = "tUserNameTextBox";
            this.tUserNameTextBox.Size = new System.Drawing.Size(131, 22);
            this.tUserNameTextBox.TabIndex = 1;
            // 
            // tPasswordTextBox
            // 
            this.tPasswordTextBox.Location = new System.Drawing.Point(5, 140);
            this.tPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tPasswordTextBox.Name = "tPasswordTextBox";
            this.tPasswordTextBox.Size = new System.Drawing.Size(186, 22);
            this.tPasswordTextBox.TabIndex = 2;
            this.tPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // TPictureBox1
            // 
            this.TPictureBox1.Image = global::TicketsLog.Properties.Resources.CharterBusinessLogo;
            this.TPictureBox1.Location = new System.Drawing.Point(144, 3);
            this.TPictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TPictureBox1.Name = "TPictureBox1";
            this.TPictureBox1.Size = new System.Drawing.Size(245, 131);
            this.TPictureBox1.TabIndex = 3;
            this.TPictureBox1.TabStop = false;
            // 
            // tUserLabel
            // 
            this.tUserLabel.AutoSize = true;
            this.tUserLabel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUserLabel.Location = new System.Drawing.Point(39, 54);
            this.tUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tUserLabel.Name = "tUserLabel";
            this.tUserLabel.Size = new System.Drawing.Size(64, 16);
            this.tUserLabel.TabIndex = 4;
            this.tUserLabel.Text = "User Name";
            // 
            // tPasswordLabel
            // 
            this.tPasswordLabel.AutoSize = true;
            this.tPasswordLabel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPasswordLabel.Location = new System.Drawing.Point(46, 118);
            this.tPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tPasswordLabel.Name = "tPasswordLabel";
            this.tPasswordLabel.Size = new System.Drawing.Size(56, 16);
            this.tPasswordLabel.TabIndex = 5;
            this.tPasswordLabel.Text = "Password";
            // 
            // tLoginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 180);
            this.Controls.Add(this.tPasswordLabel);
            this.Controls.Add(this.tUserLabel);
            this.Controls.Add(this.TPictureBox1);
            this.Controls.Add(this.tPasswordTextBox);
            this.Controls.Add(this.tUserNameTextBox);
            this.Controls.Add(this.tEnterButtom);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "tLoginForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login!";
            this.Load += new System.EventHandler(this.tLoginForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tEnterButtom;
        private System.Windows.Forms.TextBox tUserNameTextBox;
        private System.Windows.Forms.TextBox tPasswordTextBox;
        private System.Windows.Forms.PictureBox TPictureBox1;
        private System.Windows.Forms.Label tUserLabel;
        private System.Windows.Forms.Label tPasswordLabel;
    }
}

