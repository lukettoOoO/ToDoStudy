using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDoStudy
{
    public partial class ToDoList : UserControl
    {
        public ToDoList()
        {
            InitializeComponent();
        }
        Image plus_light = Image.FromFile("plus_light.png");
        Image plus_dark = Image.FromFile("plus_dark.png");
        Image pencil_light = Image.FromFile("pencil_light.png");
        Image pencil_dark = Image.FromFile("pencil_dark.png");
        Image trash_light = Image.FromFile("trash_light.png");
        Image trash_dark = Image.FromFile("trash_dark.png");

        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            addButton.BackgroundImage = plus_dark;
            addButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackgroundImage = plus_light;
            addButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void modifyButton_MouseEnter(object sender, EventArgs e)
        {
            modifyButton.BackgroundImage = pencil_dark;
            modifyButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void modifyButton_MouseLeave(object sender, EventArgs e)
        {
            modifyButton.BackgroundImage = pencil_light;
            modifyButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.BackgroundImage = trash_dark;
            deleteButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.BackgroundImage = trash_light;
            deleteButton.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addForm add_form = new addForm();
            if (add_form.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter("ToDoList.csv", true);
                dateList.Items.Add(add_form.dateTimePicker1.Text);
                sw.Write(add_form.dateTimePicker1.Text + ";");
                if (add_form.textBox1.Text == "")
                {
                    taskList.Items.Add("Unknown");
                    sw.Write("Unknown" + ";");
                }
                else
                {
                    taskList.Items.Add(add_form.textBox1.Text);
                    sw.Write(add_form.textBox1.Text + ";");
                }
                if (add_form.radioButtonLow.Checked)
                {
                    priorityList.Items.Add("▬");
                    sw.Write("▬" + ";");
                }
                else if (add_form.radioButtonMedium.Checked)
                {
                    priorityList.Items.Add("▬ ▬");
                    sw.Write("▬ ▬" + ";");
                }
                else if (add_form.radioButtonHigh.Checked)
                {
                    priorityList.Items.Add("▬ ▬ ▬");
                    sw.Write("▬ ▬ ▬" + ";");
                }
                else if (add_form.radioButtonHigh.Checked == false 
                    && add_form.radioButtonMedium.Checked == false 
                    && add_form.radioButtonLow.Checked == false)
                {
                    priorityList.Items.Add("???");
                    sw.Write("???" + ";");
                }
                sw.Write("notChecked");
                sw.Write(System.Environment.NewLine);
                sw.Close();
            }
            else
                add_form.Close();
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                dateList.Items.RemoveAt(taskList.SelectedIndex);
                priorityList.Items.RemoveAt(taskList.SelectedIndex);
                taskList.Items.RemoveAt(taskList.SelectedIndex);
                StreamWriter sw = new StreamWriter("ToDoList.csv");
                for(int i = 0; i < taskList.Items.Count; i++)
                {
                    sw.Write(dateList.Items[i].ToString() + ";");
                    sw.Write(taskList.Items[i].ToString() + ";");
                    sw.Write(priorityList.Items[i].ToString() + ";");
                    if (taskList.GetItemCheckState(i) == CheckState.Checked)
                        sw.Write("Checked");
                    else
                        sw.Write("notChecked");
                    sw.Write(System.Environment.NewLine);
                }
                sw.Close();
            }
            catch
            {
                label3.ForeColor = Color.Red;
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

            try
            {
                modifyForm modify_form = new modifyForm();
                modify_form.dateTimePicker1.Text = dateList.Items[taskList.SelectedIndex].ToString();
                modify_form.textBox1.Text = taskList.Items[taskList.SelectedIndex].ToString();
                if (priorityList.Items[taskList.SelectedIndex].ToString() == "▬")
                    modify_form.radioButtonLow.Checked = true;
                if (priorityList.Items[taskList.SelectedIndex].ToString() == "▬ ▬")
                    modify_form.radioButtonMedium.Checked = true;
                if (priorityList.Items[taskList.SelectedIndex].ToString() == "▬ ▬ ▬")
                    modify_form.radioButtonHigh.Checked = true;
                if (modify_form.ShowDialog() == DialogResult.OK)
                {
                    dateList.Items[taskList.SelectedIndex] = modify_form.dateTimePicker1.Text;
                    taskList.Items[taskList.SelectedIndex] = modify_form.textBox1.Text;
                    if (modify_form.radioButtonHigh.Checked)
                        priorityList.Items[taskList.SelectedIndex] = "▬ ▬ ▬";
                    else if (modify_form.radioButtonMedium.Checked)
                        priorityList.Items[taskList.SelectedIndex] = "▬ ▬";
                    else if (modify_form.radioButtonLow.Checked)
                        priorityList.Items[taskList.SelectedIndex] = "▬";
                    StreamWriter sw = new StreamWriter("ToDoList.csv");
                    for (int i = 0; i < taskList.Items.Count; i++)
                    {
                        sw.Write(dateList.Items[i].ToString() + ";");
                        sw.Write(taskList.Items[i].ToString() + ";");
                        sw.Write(priorityList.Items[i].ToString() + ";");
                        if (taskList.GetItemCheckState(i) == CheckState.Checked)
                            sw.Write("Checked");
                        else
                            sw.Write("notChecked");
                        sw.Write(System.Environment.NewLine);
                    }
                    sw.Close();
                }
                else
                    modify_form.Close();
            }
            catch
            {
                label3.ForeColor = Color.Red;
            }
        }

        private void taskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DimGray;
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("ToDoList.csv");
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    dateList.Items.Add(line[0]);
                    taskList.Items.Add(line[1]);
                    priorityList.Items.Add(line[2]);
                    if (line[3] == "Checked")
                        taskList.SetItemChecked(taskList.Items.Count - 1, true);
                    else
                        taskList.SetItemChecked(taskList.Items.Count - 1, false);
                }
                sr.Close();
            }
            catch
            {

            }
        }

        private void ToDoList_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("ToDoList.csv");
                for (int i = 0; i < taskList.Items.Count; i++)
                {
                    sw.Write(dateList.Items[i].ToString() + ";");
                    sw.Write(taskList.Items[i].ToString() + ";");
                    sw.Write(priorityList.Items[i].ToString() + ";");
                    if (taskList.GetItemCheckState(i) == CheckState.Checked)
                        sw.Write("Checked");
                    else
                        sw.Write("notChecked");
                    sw.Write(System.Environment.NewLine);
                }
                sw.Close();
            }
            catch
            {

            }
        }
    }
}
