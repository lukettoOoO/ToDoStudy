using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ToDoStudy
{
    public partial class FocusSounds : UserControl
    {
        public FocusSounds()
        {
            InitializeComponent();
        }
        SoundPlayer lofi1 = new SoundPlayer("lofi1.wav");
        SoundPlayer lofi2 = new SoundPlayer("lofi2.wav");
        SoundPlayer nature = new SoundPlayer("nature.wav");
        SoundPlayer sea = new SoundPlayer("sea.wav");
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            lofi1_label.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lofi1_label.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            nature_label.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            nature_label.Visible = false;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            lofi2_label.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            lofi2_label.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            sea_label.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            sea_label.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1++;
            if(p1 % 2 != 0)
            {
                lofi1.Play();
                button1.Text = "□";
                button1.TextAlign = ContentAlignment.MiddleCenter;
            }
            if(p1 % 2 == 0)
            {
                lofi1.Stop();
                button1.Text = "▷";
                button1.TextAlign = ContentAlignment.TopLeft;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p2++;
            if(p2 % 2 != 0)
            {
                nature.Play();
                button2.Text = "□";
                button2.TextAlign = ContentAlignment.MiddleCenter;
            }
            if (p2 % 2 == 0)
            {
                nature.Stop();
                button2.Text = "▷";
                button2.TextAlign = ContentAlignment.TopLeft;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p3++;
            if (p3 % 2 != 0)
            {
                lofi2.Play();
                button3.Text = "□";
                button3.TextAlign = ContentAlignment.MiddleCenter;
            }
            if (p3 % 2 == 0)
            {
                lofi2.Stop();
                button3.Text = "▷";
                button3.TextAlign = ContentAlignment.TopLeft;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p4++;
            if (p4 % 2 != 0)
            {
                sea.Play();
                button4.Text = "□";
                button4.TextAlign = ContentAlignment.MiddleCenter;
            }
            if (p4 % 2 == 0)
            {
                sea.Stop();
                button4.Text = "▷";
                button4.TextAlign = ContentAlignment.TopLeft;
            }
        }
    }
}
