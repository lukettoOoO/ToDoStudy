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
    public partial class GradeBook : UserControl
    {
        public GradeBook()
        {
            InitializeComponent();
        }

        Image plus_light = Image.FromFile("plus_light.png");
        Image plus_dark = Image.FromFile("plus_dark.png");
        Image trash_light = Image.FromFile("trash_light.png");
        Image trash_dark = Image.FromFile("trash_dark.png");
        string subject;
        int grade;
        double total = 0;
        double items = 0;
        double average = 0;
        int[] grades = new int[1001];
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
            addGrade addGrade = new addGrade();
            if(addGrade.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    subject = addGrade.subject;
                    grade = addGrade.grade;
                    subjectBox.Items.Add(subject);
                    gradeBox.Items.Add(grade);
                    total = 0;
                    items = 0;
                    for(int i = 0; i < gradeBox.Items.Count; i++)
                    {
                        if (int.Parse(gradeBox.Items[i].ToString()) != 0)
                        {
                            total = total + int.Parse(gradeBox.Items[i].ToString());
                            items++;
                        }
                    }
                    average = total / items;
                    yearAvg.Text = "Total Average: " + average.ToString();
                }
                catch
                {
                    subjectBox.Items.Add("???");
                    gradeBox.Items.Add(0);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            subject = null;
            try
            {
                int j = gradeBox.SelectedIndex;
                subjectBox.Items.RemoveAt(j);
                gradeBox.Items.RemoveAt(j);
                total = 0;
                items = 0;
                for (int i = 0; i < gradeBox.Items.Count; i++)
                {
                    if (int.Parse(gradeBox.Items[i].ToString()) != 0)
                    {
                        total = total + int.Parse(gradeBox.Items[i].ToString());
                        items++;
                    }
                }
                average = total / items;
                yearAvg.Text = "Total Average: " + average.ToString();
            }
            catch
            {
                int j = subjectBox.SelectedIndex;
                subjectBox.Items.RemoveAt(j);
                gradeBox.Items.RemoveAt(j);
                total = 0;
                items = 0;
                for (int i = 0; i < gradeBox.Items.Count; i++)
                {
                    if (int.Parse(gradeBox.Items[i].ToString()) != 0)
                    {
                        total = total + int.Parse(gradeBox.Items[i].ToString());
                        items++;
                    }
                }
                average = total / items;
                yearAvg.Text = "Total Average: " + average.ToString();
            }
        }

        private void gradeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorLabel.ForeColor = Color.DimGray;
        }

        private void GradeBook_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("gradebook.csv");
                for (int i = 0; i < gradeBox.Items.Count; i++)
                {
                    sw.WriteLine(subjectBox.Items[i].ToString() + ";" + gradeBox.Items[i].ToString());
                }
                sw.Close();
                total = 0;
                items = 0;
                for (int i = 0; i < gradeBox.Items.Count; i++)
                {
                    if (int.Parse(gradeBox.Items[i].ToString()) != 0)
                    {
                        total = total + int.Parse(gradeBox.Items[i].ToString());
                        items++;
                    }
                }
                average = total / items;
                yearAvg.Text = "Total Average: " + average.ToString();
            }
            catch
            {

            }
        }

        private void GradeBook_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("gradebook.csv");
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    subjectBox.Items.Add(line[0]);
                    gradeBox.Items.Add(line[1]);
                }
                sr.Close();
            }
            catch
            {

            }
        }

        private void subjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                subject = subjectBox.SelectedItem.ToString();
                double total = 0;
                double items = 0;
                double average = 0;
                for (int i = 0; i < gradeBox.Items.Count; i++)
                    if (subjectBox.Items[i].ToString() == subject)
                    {
                        total = total + int.Parse(gradeBox.Items[i].ToString());
                        items++;
                    }
                average = total / items;
                subjectAvg.Text = "Average for " + subject + ": " + average.ToString();
            }
            catch
            {
                subjectAvg.Text = "Average for: <Selected Subject>:";
                subject = null;
            }
        }
    }
}
