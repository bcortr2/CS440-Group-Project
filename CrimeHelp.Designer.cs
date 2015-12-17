namespace group8CodeProj
{
    partial class CrimeHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrimeHelp));
            this.CrimeHelpLabel = new System.Windows.Forms.Label();
            this.CrimeHelpBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrimeHelpLabel
            // 
            this.CrimeHelpLabel.AutoSize = true;
            this.CrimeHelpLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrimeHelpLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.CrimeHelpLabel.Location = new System.Drawing.Point(12, 30);
            this.CrimeHelpLabel.Name = "CrimeHelpLabel";
            this.CrimeHelpLabel.Size = new System.Drawing.Size(297, 69);
            this.CrimeHelpLabel.TabIndex = 0;
            this.CrimeHelpLabel.Text = "The Crime search button \r\nwill display the recent crimes \r\non a given street";
            // 
            // CrimeHelpBackButton
            // 
            this.CrimeHelpBackButton.BackColor = System.Drawing.Color.Transparent;
            this.CrimeHelpBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CrimeHelpBackButton.BackgroundImage")));
            this.CrimeHelpBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CrimeHelpBackButton.FlatAppearance.BorderSize = 0;
            this.CrimeHelpBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.CrimeHelpBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CrimeHelpBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrimeHelpBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrimeHelpBackButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CrimeHelpBackButton.Location = new System.Drawing.Point(100, 138);
            this.CrimeHelpBackButton.Name = "CrimeHelpBackButton";
            this.CrimeHelpBackButton.Size = new System.Drawing.Size(112, 45);
            this.CrimeHelpBackButton.TabIndex = 1;
            this.CrimeHelpBackButton.Text = "Ok, Thanks";
            this.CrimeHelpBackButton.UseVisualStyleBackColor = false;
            this.CrimeHelpBackButton.Click += new System.EventHandler(this.CrimeHelpBackButton_Click);
            // 
            // CrimeHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(324, 225);
            this.Controls.Add(this.CrimeHelpBackButton);
            this.Controls.Add(this.CrimeHelpLabel);
            this.Name = "CrimeHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CrimeHelpLabel;
        private System.Windows.Forms.Button CrimeHelpBackButton;
    }
}