using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using FileHelpers;

namespace group8CodeProj
{
    public partial class SearchForm : Form
    {
        String[] neighborhoods = new String[77] 
        {"Rogers Park",
        "West Ridge",
        "Uptown",
        "Lincoln Square",
        "North Center",
        "Lake View",
        "Lincoln Park",
        "Near North Side",
        "Edison Park",
        "Norwood Park",
        "Jefferson Park",
        "Forest Glen",
        "North Park",
        "Albany Park",
        "Portage Park",
        "Irving Park",
        "Dunning",
        "Montclaire",
        "Belmont Cragin",
        "Hermosa",
        "Avondale",
        "Logan Square",
        "Humbolt park",
        "West Town",
        "Austin",
        "West Garfield Park",
        "East Garfield Park",
        "Near West Side",
        "North Lawndale",
        "South Lawndale",
        "Lower West Side",
        "Loop",
        "Near South Side",
        "Armour Square",
        "Douglas",
        "Oakland",
        "Fuller Park",
        "Grand Boulevard",
        "Kenwood",
        "Washington Park",
        "Hyde Park",
        "Woodland",
        "South Shore",
        "Chatham",
        "Avalon Park",
        "South Chicago",
        "Burnside",
        "Calumet Heights",
        "Roseland",
        "Pullman",
        "South Deering",
        "East Side",
        "West Pullman",
        "Riverdale",
        "Hegewisch",
        "Garfield Ridge",
        "Archer Heights",
        "Brighton Park",
        "McKinley Park",
        "Bridgeport",
        "New City",
        "West Elsdon",
        "Gage Park",
        "Clearing",
        "West Lawn",
        "Chicago Lawn",
        "West Englewood",
        "Englewood",
        "Greater Grand Crossing",
        "Ashburn",
        "Auburn Gresham",
        "Beverly",
        "Washington Height",
        "Mount Greenwood",
        "Morgan Park",
        "O'Hare",
        "Edgewater"};
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchExit_Click(object sender, EventArgs e)
        {
            ExitForm frm = new ExitForm();
            frm.ShowDialog();
        }

        private void TIF_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://data.cityofchicago.org/api/views/mex4-ppfc/rows.csv?accessType=DOWNLOAD", "TIF.csv");
            }
            try
            {
                //create a CSV engine using FileHelpers for your CSV file, in this case for 'MyProduct'
                var engine = new FileHelperEngine(typeof(TIF));
                //read the CSV file into your object Arrary
                var products = (TIF[])engine.ReadFile("TIF.csv");

                if (products.Any())
                {
                    //process your records as per your requirements
                    foreach (var product in products)
                    {
                        listBox1.Items.Add(product.TIFDistrict + ": " + product.approvedAmmount + " approved for " + product.projectName);
                    }
                }
            }
            
            catch (Exception ex) 
            { 
                listBox1.Items.Add(ex); 
            }
        
        }

        private void AverageIncome_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://data.cityofchicago.org/api/views/kn9c-c2s2/rows.csv?accessType=DOWNLOAD", "income.csv");
            }
            try
            {
                //create a CSV engine using FileHelpers for your CSV file, in this case for 'MyProduct'
                var engine = new FileHelperEngine(typeof(Income));
                //read the CSV file into your object Arrary
                var uproducts = (Income[])engine.ReadFile("income.csv");
                var products = uproducts.OrderBy(Income => Income.neighborhood);
                if (products.Any())
                {
                    //process your records as per your requirements
                    foreach (var product in products)
                    {
                        listBox1.Items.Add(product.neighborhood + ": " + product.income.ToString());
                    }
                }


            }
            catch (Exception ex) 
            { 
                listBox1.Items.Add(ex); 
            }
        }

        private void CrimeRate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://data.cityofchicago.org/api/views/x2n5-8w5q/rows.csv?accessType=DOWNLOAD", "crime.csv");
            }
            try
            {
                //create a CSV engine using FileHelpers for your CSV file, in this case for 'MyProduct'
                var engine = new FileHelperEngine(typeof(Crime));
                //read the CSV file into your object Arrary
                var products = (Crime[])engine.ReadFile("Crime.csv");
                products.OrderBy(x =>x.block);
                List<Tuple<String, int>> l = new List<Tuple<String, int>>();
                int n = 0;
                for(int i = 0; i < products.Length - 1; i++)
                {
                    n++;
                    if(!products[i].block.Equals(products[i + 1].block))
                    {
                        l.Add(new Tuple<string,int>(products[i].block, n));
                        n = 0;
                    }
                    if(i == products.Length - 2)
                    {
                        l.Add(new Tuple<String, int>(products[i + 1].block, n + 1));
                    }
                }
                foreach(var x in l)
                {
                    listBox1.Items.Add(x.Item1 + ": " + x.Item2 + " crimes in the past year");
                }
            }

            catch (Exception ex)
            {
                listBox1.Items.Add(ex);
            }
            
        }

        private void TopTen_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            
            if (radioButton1.Checked)
            {
                SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile("https://data.cityofchicago.org/api/views/kn9c-c2s2/rows.csv?accessType=DOWNLOAD", "income.csv");
                }
                try
                {
                    //create a CSV engine using FileHelpers for your CSV file, in this case for 'MyProduct'
                    var engine = new FileHelperEngine(typeof(Income));
                    //read the CSV file into your object Arrary
                    var products = (Income[])engine.ReadFile("income.csv");

                    if (products.Any())
                    {
                        //process your records as per your requirements
                        foreach (var product in products)
                        {

                            dict.Add(product.neighborhood, (int)product.income);
                            //listBox1.Items.Add(product.neighborhood + ": " + product.income.ToString());
                        }
                        var items = (from pair in dict orderby pair.Value descending select pair).Take(10);
                        //var topTen = from pair in items 
                        int i = 0;
                        foreach (KeyValuePair<string, int> pair in items)
                            listBox1.Items.Add("#" + ++i + ". " + pair.Key.ToString() + ": " + pair.Value);
                    }


                }
                catch (Exception ex)
                {
                    listBox1.Items.Add(ex);
                }
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.Clear();
                SortedDictionary<string, string> dict = new SortedDictionary<string, string>();
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile("https://data.cityofchicago.org/api/views/mex4-ppfc/rows.csv?accessType=DOWNLOAD", "TIF.csv");
                }
                try
                {
                    //create a CSV engine using FileHelpers for your CSV file, in this case for 'MyProduct'
                    var engine = new FileHelperEngine(typeof(TIF));
                    //read the CSV file into your object Arrary
                    var products = (TIF[])engine.ReadFile("TIF.csv");

                    if (products.Any())
                    {
                        //process your records as per your requirements
                        foreach (var product in products)
                        {
                            if (!dict.ContainsKey(product.TIFDistrict))
                            dict.Add(product.TIFDistrict, product.approvedAmmount);
                            //listBox1.Items.Add(product.TIFDistrict + ": " + product.approvedAmmount + " approved for " + product.projectName);
                        }
                        var items = (from pair in dict orderby pair.Value descending select pair).Take(10);
                        //var topTen = from pair in items 
                        int i = 0;
                        foreach (KeyValuePair<string, string> pair in items)
                            listBox1.Items.Add(++i + ". " + pair.Key.ToString() + " " + pair.Value);
                    }
                }

                catch (Exception ex)
                {
                    listBox1.Items.Add(ex);
                }
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void NeighborhoodSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://data.cityofchicago.org/api/views/kn9c-c2s2/rows.csv?accessType=DOWNLOAD", "income.csv");
            }
            try
            {
                //create a CSV engine using FileHelpers for your CSV file, in this case for 'MyProduct'
                var engine = new FileHelperEngine(typeof(Income));
                //read the CSV file into your object Arrary
                var products = (Income[])engine.ReadFile("income.csv");
                Boolean found = false;
                if (products.Any())
                {
                    //process your records as per your requirements
                    foreach (var product in products)
                    {

                        if (NSearchText.Text.ToUpper() == product.neighborhood.ToUpper())
                        {
                            listBox1.Items.Add(product.neighborhood + ": " + product.income.ToString());
                            found = true;
                        }
                                       
                    }
                    if (!found)
                    {
                        listBox1.Items.Clear();
                        using (WebClient wc = new WebClient())
                        {
                            wc.DownloadFile("https://data.cityofchicago.org/api/views/mex4-ppfc/rows.csv?accessType=DOWNLOAD", "TIF.csv");
                        }
                        try
                        {
                            //create a CSV engine using FileHelpers for your CSV file, in this case for 'MyProduct'
                            var engine2 = new FileHelperEngine(typeof(TIF));
                            //read the CSV file into your object Arrary
                            var products2 = (TIF[])engine2.ReadFile("TIF.csv");

                            if (products2.Any())
                            {
                                //process your records as per your requirements
                                foreach (var product in products2)
                                {
                                    if (NSearchText.Text.ToUpper() == product.TIFDistrict.ToUpper())
                                    {
                                        listBox1.Items.Add(product.TIFDistrict + ": " + product.approvedAmmount + " approved for " + product.projectName);
                                        found = true;
                                    }
                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            listBox1.Items.Add(ex);
                        }
                    }
                   if(!found)
                    listBox1.Items.Add("No such neighborhood found");
             
                }


            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex);
            }
        }

        private void mapSearch_Click(object sender, EventArgs e)
        {
            MapView mapV = new MapView();
            mapV.Show();
            if(listBox1.SelectedIndex >= 0)
            {
                String itemText = listBox1.SelectedItem.ToString();
                int x = itemText.IndexOf(':');
                String place;
                if(itemText.Substring(0, 1).Equals("#"))
                {
                    place = itemText.Substring(4, x - 4);
                }
                else
                {
                    place = itemText.Substring(0, x);
                }
                mapV.initialSearch(place);
            }
        }
    }
}
