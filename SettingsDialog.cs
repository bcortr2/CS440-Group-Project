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
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TIFHelpButton_Click(object sender, EventArgs e)
        {
            TIFHelp frm = new TIFHelp();
            frm.ShowDialog();
        }

        private void CrimeHelpButton_Click(object sender, EventArgs e)
        {
            CrimeHelp frm = new CrimeHelp();
            frm.ShowDialog();
        }

        private void IncomeHelpButton_Click(object sender, EventArgs e)
        {
            IncomeHelp frm = new IncomeHelp();
            frm.ShowDialog();
        }

        private void TopTenHelp_Click(object sender, EventArgs e)
        {
            TopTenHelpFrm frm = new TopTenHelpFrm();
            frm.ShowDialog();
        }

        private void NSearchHelp_Click(object sender, EventArgs e)
        {
            NSearchHelpFrm frm = new NSearchHelpFrm();
            frm.ShowDialog();
        }

    }
}
