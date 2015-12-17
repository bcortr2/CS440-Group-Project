namespace group8CodeProj
{
    partial class IncomeHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeHelp));
            this.IncomeHelpLabel = new System.Windows.Forms.Label();
            this.IncomeHelpBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IncomeHelpLabel
            // 
            this.IncomeHelpLabel.AutoSize = true;
            this.IncomeHelpLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeHelpLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.IncomeHelpLabel.Location = new System.Drawing.Point(12, 26);
            this.IncomeHelpLabel.Name = "IncomeHelpLabel";
            this.IncomeHelpLabel.Size = new System.Drawing.Size(311, 69);
            this.IncomeHelpLabel.TabIndex = 0;
            this.IncomeHelpLabel.Text = "The Average Income search \r\noption will display the average \r\nincome of each neig" +
    "hborhood";
            // 
            // IncomeHelpBackButton
            // 
            this.IncomeHelpBackButton.BackColor = System.Drawing.Color.Transparent;
            this.IncomeHelpBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncomeHelpBackButton.BackgroundImage")));
            this.IncomeHelpBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IncomeHelpBackButton.FlatAppearance.BorderSize = 0;
            this.IncomeHelpBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.IncomeHelpBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IncomeHelpBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeHelpBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeHelpBackButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.IncomeHelpBackButton.Location = new System.Drawing.Point(97, 144);
            this.IncomeHelpBackButton.Name = "IncomeHelpBackButton";
            this.IncomeHelpBackButton.Size = new System.Drawing.Size(112, 45);
            this.IncomeHelpBackButton.TabIndex = 1;
            this.IncomeHelpBackButton.Text = "Ok, Thanks";
            this.IncomeHelpBackButton.UseVisualStyleBackColor = false;
            this.IncomeHelpBackButton.Click += new System.EventHandler(this.IncomeHelpBackButton_Click);
            // 
            // IncomeHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(323, 262);
            this.Controls.Add(this.IncomeHelpBackButton);
            this.Controls.Add(this.IncomeHelpLabel);
            this.Name = "IncomeHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IncomeHelpLabel;
        private System.Windows.Forms.Button IncomeHelpBackButton;
    }
}