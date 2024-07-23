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
    public partial class PomodoroTechnique : UserControl
    {
        public PomodoroTechnique()
        {
            InitializeComponent();
        }
        private int totalSeconds;
        private int currentSeconds = 0;
        private int currentMinutes = 25;
        private int cycle = 0;
        private void helpButton_MouseEnter(object sender, EventArgs e)
        {
            helpButton.BackColor = Color.Black;
            helpButton.ForeColor = Color.White;
        }

        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            helpButton.BackColor = Color.White;
            helpButton.ForeColor = Color.Black;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            pomodoroHelp f_help = new pomodoroHelp();
            f_help.Show();
        }

        private void PomodoroTechnique_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;

            int minutes = currentMinutes;
            int seconds = currentSeconds;

            totalSeconds = (minutes * 60) + seconds;

            timer1.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            startButton.Enabled = true;
            string[] time = timerLabel.Text.Split(':');
            currentMinutes = int.Parse(time[0]);
            currentSeconds = int.Parse(time[1]);
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--; 
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                if (minutes < 10 && seconds < 10)
                    timerLabel.Text = "0" + minutes.ToString() + ":" + "0" + seconds.ToString();
                else if (seconds < 10)
                    timerLabel.Text = minutes.ToString() + ":" + "0" + seconds.ToString();
                else if (minutes < 10)
                    timerLabel.Text = "0" + minutes.ToString() + ":" + seconds.ToString();
                else
                    timerLabel.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                cycle++;
                if (cycle % 2 != 0)
                {
                    statusLabel.Text = "Take a short break!";
                    statusLabel.Location = new Point(135, 166);
                    currentSeconds = 0;
                    currentMinutes = 5;
                    totalSeconds = (currentMinutes * 60) + currentSeconds;
                }
                if(cycle % 2 == 0)
                {
                    statusLabel.Text = "Get to work!";
                    statusLabel.Location = new Point(169, 166);
                    currentSeconds = 0;
                    currentMinutes = 25;
                    totalSeconds = (currentMinutes * 60) + currentSeconds;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            cycle = 0;
            stopButton.Enabled = false;
            startButton.Enabled = true;
            statusLabel.Text = "Get to work!";
            statusLabel.Location = new Point(169, 166);
            currentSeconds = 0;
            currentMinutes = 25;
            timerLabel.Text = "25:00";
            timer1.Stop();
        }

        
    }
}
