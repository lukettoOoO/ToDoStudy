using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoStudy
{
    public partial class addGrade : Form
    {
        public addGrade()
        {
            InitializeComponent();
        }
        Image close_light = Image.FromFile("close_light.png");
        Image close_dark = Image.FromFile("close_dark.png");
        public int grade;
        public string subject;
        bool mouseDown;
        private Point offset;
        private void addGrade_Load(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }

        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            addButton.BackColor = Color.Black;
            addButton.ForeColor = Color.White;
        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackColor = Color.White;
            addButton.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                grade = int.Parse(textBox2.Text);
            }
            catch
            {
                errorLabel.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            subject = textBox1.Text;
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
                Point currentScrreenPos = PointToScreen(e.Location);
                Location = new Point(currentScrreenPos.X - offset.X, currentScrreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
