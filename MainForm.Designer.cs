namespace group8CodeProj
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Search = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Search.Location = new System.Drawing.Point(12, 27);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(134, 47);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Settings.Location = new System.Drawing.Point(170, 27);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(134, 47);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Exit.Location = new System.Drawing.Point(321, 27);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(134, 47);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.TitleLabel.Location = new System.Drawing.Point(89, 497);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(273, 25);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Neighborhood Informant";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(467, 551);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Search);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label TitleLabel;
    }
}

