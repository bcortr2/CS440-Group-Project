namespace group8CodeProj
{
    partial class TIFHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TIFHelp));
            this.label1 = new System.Windows.Forms.Label();
            this.TIFHelpBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "This search option shows the \r\nTIF (Tax Increment Financing) \r\ngrants for a given" +
    " neighborhood";
            // 
            // TIFHelpBackButton
            // 
            this.TIFHelpBackButton.BackColor = System.Drawing.Color.Transparent;
            this.TIFHelpBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TIFHelpBackButton.BackgroundImage")));
            this.TIFHelpBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TIFHelpBackButton.FlatAppearance.BorderSize = 0;
            this.TIFHelpBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.TIFHelpBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TIFHelpBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TIFHelpBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIFHelpBackButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TIFHelpBackButton.Location = new System.Drawing.Point(120, 132);
            this.TIFHelpBackButton.Name = "TIFHelpBackButton";
            this.TIFHelpBackButton.Size = new System.Drawing.Size(112, 45);
            this.TIFHelpBackButton.TabIndex = 1;
            this.TIFHelpBackButton.Text = "Ok, Thanks";
            this.TIFHelpBackButton.UseVisualStyleBackColor = false;
            this.TIFHelpBackButton.Click += new System.EventHandler(this.TIFHelpBackButton_Click);
            // 
            // TIFHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(370, 212);
            this.Controls.Add(this.TIFHelpBackButton);
            this.Controls.Add(this.label1);
            this.Name = "TIFHelp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TIFHelpBackButton;
    }
}