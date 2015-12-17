using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group8CodeProj
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchForm frm = new SearchForm();
            this.Hide();
            frm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ExitForm frm = new ExitForm();
            frm.ShowDialog();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsDialog frm = new SettingsDialog();
            frm.ShowDialog();
        }
    }
}
