namespace group8CodeProj
{
    partial class NSearchHelpFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NSearchHelpFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.NSearchHelpBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Neighborhood Search button will allow you to search\r\nfor a specific neighborh" +
    "ood. Input the name of the \r\nneighborhood in the text box located below the butt" +
    "on.";
            // 
            // NSearchHelpBackBtn
            // 
            this.NSearchHelpBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.NSearchHelpBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NSearchHelpBackBtn.BackgroundImage")));
            this.NSearchHelpBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NSearchHelpBackBtn.FlatAppearance.BorderSize = 0;
            this.NSearchHelpBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.NSearchHelpBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NSearchHelpBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NSearchHelpBackBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NSearchHelpBackBtn.Location = new System.Drawing.Point(278, 169);
            this.NSearchHelpBackBtn.Name = "NSearchHelpBackBtn";
            this.NSearchHelpBackBtn.Size = new System.Drawing.Size(112, 45);
            this.NSearchHelpBackBtn.TabIndex = 1;
            this.NSearchHelpBackBtn.Text = "Ok, Thanks";
            this.NSearchHelpBackBtn.UseVisualStyleBackColor = false;
            this.NSearchHelpBackBtn.Click += new System.EventHandler(this.NSearchHelpBackBtn_Click);
            // 
            // NSearchHelpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(668, 287);
            this.Controls.Add(this.NSearchHelpBackBtn);
            this.Controls.Add(this.label1);
            this.Name = "NSearchHelpFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NSearchHelpBackBtn;
    }
}