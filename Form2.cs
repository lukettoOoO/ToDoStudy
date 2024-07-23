using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoStudy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool mouseDown;
        private Point offset;
        Image close_light = Image.FromFile("close_light.png");
        Image close_dark = Image.FromFile("close_dark.png");
        Image minimize_light = Image.FromFile("minimize.png");
        Image minimize_dark = Image.FromFile("minimize(1).png");
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = close_light;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackgroundImage = close_dark;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackgroundImage = minimize_light;
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackgroundImage = minimize_dark;
            minimizeButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.SelectAll();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "" && toolStripTextBox1.Text != "Look it up...")
            {
                webBrowser1.Navigate("https://en.wikipedia.org/wiki/" + toolStripTextBox1.Text.Replace(" ", "_"));
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
    }
}
