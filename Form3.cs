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
    public partial class MapView : Form
    {
        public MapView()
        {
            InitializeComponent();
        }

        public void initialSearch(String s)
        {
            mapSearchTxt.Text = s;
            search();
        }

        private void search()
        {
            string neighborhood = mapSearchTxt.Text;
            string city = "Chicago";
            try
            {
                StringBuilder query = new StringBuilder();
                query.Append("http://www.bing.com/maps?q=");

                if (neighborhood != string.Empty)
                    query.Append(neighborhood + ",+" + city);

                webBrowser1.Navigate(query.ToString());
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void mapSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void mapQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
