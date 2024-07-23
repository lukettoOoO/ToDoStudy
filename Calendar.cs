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
    public partial class Calendar : UserControl
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            string[] date = DateTime.Now.ToString().Split(' ');
            dateLabel.Text = date[0];

            DateTime today = DateTime.Now;
            int daysInYear = 365;
            if (DateTime.IsLeapYear(today.Year))
            {
                daysInYear++;
            }
            daysLabel.Text = (daysInYear - today.DayOfYear).ToString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string selectedDate = monthCalendar1.SelectionRange.Start.DayOfWeek.ToString();
            if(selectedDate == "Monday")
            {
                timetable_listBox.Items.Clear();
                timetable_timeBox.Items.Clear();
                using (StreamReader sr_mon = new StreamReader("mon_timetable.csv"))
                {
                    while (!sr_mon.EndOfStream)
                    {
                        string[] line = sr_mon.ReadLine().ToString().Split(';');
                        timetable_timeBox.Items.Add(line[0]);
                        timetable_listBox.Items.Add(line[1]);
                    }
                }
            }
            if (selectedDate == "Tuesday")
            {
                timetable_listBox.Items.Clear();
                timetable_timeBox.Items.Clear();
                using (StreamReader sr_tue = new StreamReader("tue_timetable.csv"))
                {
                    while (!sr_tue.EndOfStream)
                    {
                        string[] line = sr_tue.ReadLine().ToString().Split(';');
                        timetable_timeBox.Items.Add(line[0]);
                        timetable_listBox.Items.Add(line[1]);
                    }
                }
            }
            if (selectedDate == "Wednesday")
            {
                timetable_listBox.Items.Clear();
                timetable_timeBox.Items.Clear();
                using (StreamReader sr_wed = new StreamReader("wed_timetable.csv"))
                {
                    while (!sr_wed.EndOfStream)
                    {
                        string[] line = sr_wed.ReadLine().ToString().Split(';');
                        timetable_timeBox.Items.Add(line[0]);
                        timetable_listBox.Items.Add(line[1]);
                    }
                }
            }
            if (selectedDate == "Thursday")
            {
                timetable_listBox.Items.Clear();
                timetable_timeBox.Items.Clear();
                using (StreamReader sr_thu = new StreamReader("thu_timetable.csv"))
                {
                    while (!sr_thu.EndOfStream)
                    {
                        string[] line = sr_thu.ReadLine().ToString().Split(';');
                        timetable_timeBox.Items.Add(line[0]);
                        timetable_listBox.Items.Add(line[1]);
                    }
                }
            }
            if (selectedDate == "Friday")
            {
                timetable_listBox.Items.Clear();
                timetable_timeBox.Items.Clear();
                using (StreamReader sr_fri = new StreamReader("fri_timetable.csv"))
                {
                    while (!sr_fri.EndOfStream)
                    {
                        string[] line = sr_fri.ReadLine().ToString().Split(';');
                        timetable_timeBox.Items.Add(line[0]);
                        timetable_listBox.Items.Add(line[1]);
                    }
                }
            }
            if(selectedDate == "Saturday" || selectedDate == "Sunday")
            {
                timetable_listBox.Items.Clear();
                timetable_timeBox.Items.Clear();
            }
        }
    }
}
