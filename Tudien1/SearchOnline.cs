using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tudien1
{
    public partial class SearchOnline : Form
    {
        public SearchOnline()
        {
            InitializeComponent();
        }

        private void SearchOnline_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = "http://tratu.soha.vn/dict/en_vn/";
            string link;
            link = url + txtSearch.Text;
            WebBrowser wb = new WebBrowser();
            wb.Width = 1200;
            wb.Height = 600;
            wb.ScriptErrorsSuppressed = true;
            pnlWeb.Controls.Add(wb);
            wb.Navigate(link);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            pnlWeb.Controls.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void SearchOnline_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
