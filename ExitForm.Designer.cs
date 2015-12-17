namespace group8CodeProj
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.QuitYes = new System.Windows.Forms.Button();
            this.QuitNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuitYes
            // 
            this.QuitYes.BackColor = System.Drawing.Color.Transparent;
            this.QuitYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitYes.BackgroundImage")));
            this.QuitYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitYes.FlatAppearance.BorderSize = 0;
            this.QuitYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.QuitYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QuitYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitYes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.QuitYes.Location = new System.Drawing.Point(109, 89);
            this.QuitYes.Name = "QuitYes";
            this.QuitYes.Size = new System.Drawing.Size(112, 45);
            this.QuitYes.TabIndex = 0;
            this.QuitYes.Text = "Yes";
            this.QuitYes.UseVisualStyleBackColor = false;
            this.QuitYes.Click += new System.EventHandler(this.QuitYes_Click);
            // 
            // QuitNo
            // 
            this.QuitNo.BackColor = System.Drawing.Color.Transparent;
            this.QuitNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitNo.BackgroundImage")));
            this.QuitNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitNo.FlatAppearance.BorderSize = 0;
            this.QuitNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.QuitNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QuitNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.QuitNo.Location = new System.Drawing.Point(109, 158);
            this.QuitNo.Name = "QuitNo";
            this.QuitNo.Size = new System.Drawing.Size(112, 45);
            this.QuitNo.TabIndex = 1;
            this.QuitNo.Text = "No";
            this.QuitNo.UseVisualStyleBackColor = false;
            this.QuitNo.Click += new System.EventHandler(this.QuitNo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure you wish to quit?";
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(339, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitNo);
            this.Controls.Add(this.QuitYes);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ExitForm";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuitYes;
        private System.Windows.Forms.Button QuitNo;
        private System.Windows.Forms.Label label1;
    }
}