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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }
        bool mouseDown;
        private Point offset;
        Image close_light = Image.FromFile("close_light.png");
        Image close_dark = Image.FromFile("close_dark.png");
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.Black;
            cancelButton.ForeColor = Color.White;
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.White;
            cancelButton.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = close_light;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = close_dark;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(";"))
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }
    }
}
