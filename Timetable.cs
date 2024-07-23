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
    public partial class Timetable : UserControl
    {
        public Timetable()
        {
            InitializeComponent();
        }
        

        private void mon_addButton_Click(object sender, EventArgs e)
        {
            addClass addClass = new addClass();
            if(addClass.ShowDialog() == DialogResult.OK)
            {
                if(addClass.textBox1.Text != "")
                {
                    mon_listBox.Items.Add(addClass.textBox1.Text.ToString());
                    mon_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
                else
                {
                    mon_listBox.Items.Add("???");
                    mon_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
            }
            else
            {
                addClass.Close();
            }
        }

        private void tue_addButton_Click(object sender, EventArgs e)
        {
            addClass addClass = new addClass();
            if (addClass.ShowDialog() == DialogResult.OK)
            {
                if (addClass.textBox1.Text != "")
                {
                    tue_listBox.Items.Add(addClass.textBox1.Text.ToString());
                    tue_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
                else
                {
                    tue_listBox.Items.Add("???");
                    tue_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
            }
            else
            {
                addClass.Close();
            }
        }

        private void wed_addButton_Click(object sender, EventArgs e)
        {
            addClass addClass = new addClass();
            if (addClass.ShowDialog() == DialogResult.OK)
            {
                if (addClass.textBox1.Text != "")
                {
                    wed_listBox.Items.Add(addClass.textBox1.Text.ToString());
                    wed_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
                else
                {
                    wed_listBox.Items.Add("???");
                    wed_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
            }
            else
            {
                addClass.Close();
            }
        }

        private void thu_addButton_Click(object sender, EventArgs e)
        {
            addClass addClass = new addClass();
            if (addClass.ShowDialog() == DialogResult.OK)
            {
                if (addClass.textBox1.Text != "")
                {
                    thu_listBox.Items.Add(addClass.textBox1.Text.ToString());
                    thu_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
                else
                {
                    thu_listBox.Items.Add("???");
                    thu_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
            }
            else
            {
                addClass.Close();
            }
        }

        private void fri_addButton_Click(object sender, EventArgs e)
        {
            addClass addClass = new addClass();
            if (addClass.ShowDialog() == DialogResult.OK)
            {
                if (addClass.textBox1.Text != "")
                {
                    fri_listBox.Items.Add(addClass.textBox1.Text.ToString());
                    fri_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
                else
                {
                    fri_listBox.Items.Add("???");
                    fri_timeBox.Items.Add(addClass.comboBox1.SelectedItem.ToString() + ":" + addClass.comboBox2.SelectedItem.ToString());
                }
            }
            else
            {
                addClass.Close();
            }
        }

        private void mon_deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                mon_timeBox.Items.RemoveAt(mon_listBox.Items.Count - 1);
                mon_listBox.Items.RemoveAt(mon_listBox.Items.Count - 1);
            }
            catch
            {

            }
        }

        private void tue_deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                tue_timeBox.Items.RemoveAt(tue_listBox.Items.Count - 1);
                tue_listBox.Items.RemoveAt(tue_listBox.Items.Count - 1);
            }
            catch
            {

            }
        }

        private void wed_deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                wed_timeBox.Items.RemoveAt(wed_listBox.Items.Count - 1);
                wed_listBox.Items.RemoveAt(wed_listBox.Items.Count - 1);
            }
            catch
            {

            }
        }

        private void thu_deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                thu_timeBox.Items.RemoveAt(thu_listBox.Items.Count - 1);
                thu_listBox.Items.RemoveAt(thu_listBox.Items.Count - 1);
            }
            catch
            {

            }
        }

        private void fri_deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                fri_timeBox.Items.RemoveAt(fri_listBox.Items.Count - 1);
                fri_listBox.Items.RemoveAt(fri_listBox.Items.Count - 1);
            }
            catch
            {

            }
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            using(StreamReader sr_mon = new StreamReader("mon_timetable.csv"))
            {
                while (!sr_mon.EndOfStream)
                {
                    string[] line = sr_mon.ReadLine().ToString().Split(';');
                    mon_timeBox.Items.Add(line[0]);
                    mon_listBox.Items.Add(line[1]);
                }
            }

            using (StreamReader sr_tue = new StreamReader("tue_timetable.csv"))
            {
                while (!sr_tue.EndOfStream)
                {
                    string[] line = sr_tue.ReadLine().ToString().Split(';');
                    tue_timeBox.Items.Add(line[0]);
                    tue_listBox.Items.Add(line[1]);
                }
            }

            using (StreamReader sr_wed = new StreamReader("wed_timetable.csv"))
            {
                while (!sr_wed.EndOfStream)
                {
                    string[] line = sr_wed.ReadLine().ToString().Split(';');
                    wed_timeBox.Items.Add(line[0]);
                    wed_listBox.Items.Add(line[1]);
                }
            }

            using (StreamReader sr_thu = new StreamReader("thu_timetable.csv"))
            {
                while (!sr_thu.EndOfStream)
                {
                    string[] line = sr_thu.ReadLine().ToString().Split(';');
                    thu_timeBox.Items.Add(line[0]);
                    thu_listBox.Items.Add(line[1]);
                }
            }

            using (StreamReader sr_fri = new StreamReader("fri_timetable.csv"))
            {
                while (!sr_fri.EndOfStream)
                {
                    string[] line = sr_fri.ReadLine().ToString().Split(';');
                    fri_timeBox.Items.Add(line[0]);
                    fri_listBox.Items.Add(line[1]);
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw_mon = new StreamWriter("mon_timetable.csv"))
            {
                for (int i = 0; i < mon_listBox.Items.Count; i++)
                {
                    sw_mon.Write(mon_timeBox.Items[i].ToString() + ";" + mon_listBox.Items[i].ToString());
                    sw_mon.Write(System.Environment.NewLine);
                }
            }

            using (StreamWriter sw_tue = new StreamWriter("tue_timetable.csv"))
            {
                for (int i = 0; i < tue_listBox.Items.Count; i++)
                {
                    sw_tue.Write(tue_timeBox.Items[i].ToString() + ";" + tue_listBox.Items[i].ToString());
                    sw_tue.Write(System.Environment.NewLine);
                }
            }

            using (StreamWriter sw_wed = new StreamWriter("wed_timetable.csv"))
            {
                for (int i = 0; i < wed_listBox.Items.Count; i++)
                {
                    sw_wed.Write(wed_timeBox.Items[i].ToString() + ";" + wed_listBox.Items[i].ToString());
                    sw_wed.Write(System.Environment.NewLine);
                }
            }

            using (StreamWriter sw_thu = new StreamWriter("thu_timetable.csv"))
            {
                for (int i = 0; i < thu_listBox.Items.Count; i++)
                {
                    sw_thu.Write(thu_timeBox.Items[i].ToString() + ";" + thu_listBox.Items[i].ToString());
                    sw_thu.Write(System.Environment.NewLine);
                }
            }

            using (StreamWriter sw_fri = new StreamWriter("fri_timetable.csv"))
            {
                for (int i = 0; i < fri_listBox.Items.Count; i++)
                {
                    sw_fri.Write(fri_timeBox.Items[i].ToString() + ";" + fri_listBox.Items[i].ToString());
                    sw_fri.Write(System.Environment.NewLine);
                }
            }
        }

        private void save_button_MouseEnter(object sender, EventArgs e)
        {
            save_button.BackColor = Color.Black;
            save_button.ForeColor = Color.White;
        }

        private void save_button_MouseLeave(object sender, EventArgs e)
        {
            save_button.BackColor = Color.White;
            save_button.ForeColor = Color.Black;
        }
    }
}
