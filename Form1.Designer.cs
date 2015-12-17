namespace group8CodeProj
{
    partial class TopTenHelpFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopTenHelpFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.TopTenHelpBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "By checking one of the checkboxes under the \"Top Ten Search\" button, \r\nyou can se" +
    "arch for the top ten neighborhoods by highest average income \r\nor the top ten di" +
    "stricts by largest amount of TIF grants";
            // 
            // TopTenHelpBackBtn
            // 
            this.TopTenHelpBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.TopTenHelpBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopTenHelpBackBtn.BackgroundImage")));
            this.TopTenHelpBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopTenHelpBackBtn.FlatAppearance.BorderSize = 0;
            this.TopTenHelpBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.TopTenHelpBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TopTenHelpBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopTenHelpBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTenHelpBackBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TopTenHelpBackBtn.Location = new System.Drawing.Point(319, 152);
            this.TopTenHelpBackBtn.Name = "TopTenHelpBackBtn";
            this.TopTenHelpBackBtn.Size = new System.Drawing.Size(112, 45);
            this.TopTenHelpBackBtn.TabIndex = 1;
            this.TopTenHelpBackBtn.Text = "Ok, Thanks";
            this.TopTenHelpBackBtn.UseVisualStyleBackColor = false;
            this.TopTenHelpBackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TopTenHelpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(745, 219);
            this.Controls.Add(this.TopTenHelpBackBtn);
            this.Controls.Add(this.label1);
            this.Name = "TopTenHelpFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TopTenHelpBackBtn;
    }
}