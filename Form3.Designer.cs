namespace group8CodeProj
{
    partial class MapView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mapQuit = new System.Windows.Forms.Button();
            this.mapSearchTxt = new System.Windows.Forms.TextBox();
            this.mapSearch = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.splitContainer1.Panel1.Controls.Add(this.mapQuit);
            this.splitContainer1.Panel1.Controls.Add(this.mapSearchTxt);
            this.splitContainer1.Panel1.Controls.Add(this.mapSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1029, 598);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // mapQuit
            // 
            this.mapQuit.BackColor = System.Drawing.Color.Transparent;
            this.mapQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mapQuit.BackgroundImage")));
            this.mapQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapQuit.FlatAppearance.BorderSize = 0;
            this.mapQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.mapQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mapQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapQuit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mapQuit.Location = new System.Drawing.Point(17, 526);
            this.mapQuit.Name = "mapQuit";
            this.mapQuit.Size = new System.Drawing.Size(134, 47);
            this.mapQuit.TabIndex = 2;
            this.mapQuit.Text = "Exit Map View";
            this.mapQuit.UseVisualStyleBackColor = false;
            this.mapQuit.Click += new System.EventHandler(this.mapQuit_Click);
            // 
            // mapSearchTxt
            // 
            this.mapSearchTxt.Location = new System.Drawing.Point(35, 109);
            this.mapSearchTxt.Name = "mapSearchTxt";
            this.mapSearchTxt.Size = new System.Drawing.Size(100, 20);
            this.mapSearchTxt.TabIndex = 1;
            // 
            // mapSearch
            // 
            this.mapSearch.BackColor = System.Drawing.Color.Transparent;
            this.mapSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mapSearch.BackgroundImage")));
            this.mapSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapSearch.FlatAppearance.BorderSize = 0;
            this.mapSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.mapSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mapSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mapSearch.Location = new System.Drawing.Point(17, 56);
            this.mapSearch.Name = "mapSearch";
            this.mapSearch.Size = new System.Drawing.Size(134, 47);
            this.mapSearch.TabIndex = 0;
            this.mapSearch.Text = "Search";
            this.mapSearch.UseVisualStyleBackColor = false;
            this.mapSearch.Click += new System.EventHandler(this.mapSearch_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(853, 598);
            this.webBrowser1.TabIndex = 0;
            // 
            // MapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 598);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MapView";
            this.Text = "Form3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button mapSearch;
        private System.Windows.Forms.TextBox mapSearchTxt;
        private System.Windows.Forms.Button mapQuit;
        private System.Windows.Forms.WebBrowser webBrowser1;

    }
}