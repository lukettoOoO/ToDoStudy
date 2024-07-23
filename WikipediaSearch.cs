using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoStudy
{
    public partial class WikipediaSearch : UserControl
    {
        public WikipediaSearch()
        {
            InitializeComponent();
        }
        Image search_light = Image.FromFile("search_light.png");
        Image search_dark = Image.FromFile("search_dark.png");
        private void wiki_searchButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "Look it up...")
            {
                searchbox_errorLabel.Text = "";
                Form2 wiki = new Form2();
                wiki.Show();
                string search_item = textBox1.Text;
                wiki.Text = "Looking up: " + search_item;
                wiki.webBrowser1.Navigate("https://en.wikipedia.org/wiki/" + search_item.Replace(" ", "_"));
            }
            else
                searchbox_errorLabel.Text = "~ Please enter data in the search bar! ~";
        }
        

        private void wiki_searchButton_MouseEnter(object sender, EventArgs e)
        {
            wiki_searchButton.BackgroundImage = search_dark;
        }

        private void wiki_searchButton_MouseLeave(object sender, EventArgs e)
        {
            wiki_searchButton.BackgroundImage = search_light;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
